using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chiwiro.Protecciones.ChangeName;
using dnlib.DotNet.Emit;
namespace Core.Protecciones
{
    internal class ObfuscateEntryPoint
    {
        public static void ObfuscateEntryPointp(ModuleDefMD module)
        {
            MethodDef entryPoint = module.EntryPoint;
            if (entryPoint == null)
            {
                Console.WriteLine("No se encontró el punto de entrada del ensamblado.");
                return;
            }

            foreach (var instr in entryPoint.Body.Instructions)
            {
                if (instr.OpCode == OpCodes.Call && instr.Operand.ToString().Contains("WriteLine"))
                {
                    instr.OpCode = OpCodes.Call;
                    instr.Operand = module.Import(typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }));
                }

                if (instr.Operand is string && !string.IsNullOrEmpty(instr.Operand as string))
                {
                    instr.Operand = GenerateRandomIdentifier();
                }

                if (instr.OpCode == OpCodes.Ret)
                {
                    instr.OpCode = OpCodes.Br;
                    instr.Operand = entryPoint.Body.Instructions[0];
                }
            }
        }

        public static string GenerateRandomIdentifier()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
