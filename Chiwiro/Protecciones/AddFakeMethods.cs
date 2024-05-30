using dnlib.DotNet.Emit;
using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Protecciones
{
    internal class AddFakeMethods
    {
        public static void AddFakeMethodsp(ModuleDefMD module, int numberOfFakes)
        {

            var entryPoint = module.EntryPoint;
            if (entryPoint == null)
            {
                Console.WriteLine("No se encontró el punto de entrada del ensamblado.");
                return;
            }


            string entryClassName = entryPoint.DeclaringType.Name;

            for (int i = 0; i < numberOfFakes; i++)
            {

                TypeDefUser fakeType = new TypeDefUser(entryClassName, $"FakeType{i}",
                                                       module.CorLibTypes.Object.TypeDefOrRef);
                module.Types.Add(fakeType);

                MethodDefUser fakeMethod = new MethodDefUser("FakeMethod", MethodSig.CreateInstance(module.CorLibTypes.Void), MethodImplAttributes.IL | MethodImplAttributes.Managed, MethodAttributes.Public | MethodAttributes.Static);
                fakeType.Methods.Add(fakeMethod);

                CilBody body = new CilBody();
                body.Instructions.Add(OpCodes.Ret.ToInstruction());
                fakeMethod.Body = body;
            }
        }
    }
}
