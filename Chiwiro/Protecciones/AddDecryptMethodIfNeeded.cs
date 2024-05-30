using dnlib.DotNet.Emit;
using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Protecciones
{
    internal class AddDecryptMethodIfNeeded
    {
        public static void AddDecryptMethodIfNeededp(ModuleDef module)
        {
            TypeDef stringDecryptorTypeDef = module.Find("StringDecryptor", false);
            if (stringDecryptorTypeDef == null)
            {
                stringDecryptorTypeDef = new TypeDefUser("", "StringDecryptor", module.CorLibTypes.Object.TypeDefOrRef);
                module.Types.Add(stringDecryptorTypeDef);
                stringDecryptorTypeDef.Attributes = TypeAttributes.Public | TypeAttributes.Abstract | TypeAttributes.Sealed;

                MethodDef decryptMethod = new MethodDefUser(
                    "Decrypt",
                    MethodSig.CreateStatic(module.CorLibTypes.String, module.CorLibTypes.String),
                    MethodAttributes.Public | MethodAttributes.Static);
                stringDecryptorTypeDef.Methods.Add(decryptMethod);

                CilBody il = new CilBody();
                decryptMethod.Body = il;
                il.MaxStack = 2;

                il.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
                il.Instructions.Add(OpCodes.Call.ToInstruction(module.Import(typeof(Convert).GetMethod("FromBase64String", new[] { typeof(string) }))));
                Local localVar = new Local(module.ImportAsTypeSig(typeof(byte[])));
                decryptMethod.Body.Variables.Add(localVar);
                il.Instructions.Add(OpCodes.Stloc.ToInstruction(localVar));

                il.Instructions.Add(OpCodes.Call.ToInstruction(module.Import(typeof(Encoding).GetProperty("UTF8").GetMethod)));
                il.Instructions.Add(OpCodes.Ldloc.ToInstruction(localVar));
                il.Instructions.Add(OpCodes.Callvirt.ToInstruction(module.Import(typeof(Encoding).GetMethod("GetString", new[] { typeof(byte[]) }))));
                il.Instructions.Add(OpCodes.Ret.ToInstruction());
            }

            EncryptStringsInModule(module, stringDecryptorTypeDef.Methods.First(m => m.Name == "Decrypt"));
        }

        private static void EncryptStringsInModule(ModuleDef module, MethodDef decryptMethod)
        {
            foreach (var type in module.Types)
            {
                foreach (var method in type.Methods)
                {
                    if (method.Body == null) continue;

                    for (int i = 0; i < method.Body.Instructions.Count; i++)
                    {
                        Instruction instr = method.Body.Instructions[i];
                        if (instr.OpCode == OpCodes.Ldstr)
                        {
                            string encryptedString = EncryptString(instr.Operand as string);
                            instr.Operand = encryptedString;
                            Instruction callDecrypt = Instruction.Create(OpCodes.Call, decryptMethod);
                            method.Body.Instructions.Insert(i + 1, callDecrypt);
                            i++;
                        }
                    }
                }
            }
        }
        private static string EncryptString(string input)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }
    }
}
