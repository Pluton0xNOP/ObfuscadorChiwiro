using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet.Emit;

namespace Core.Protecciones
{
    internal class AddFlowObfuscation
    {
        public static void AddFlowObfuscationp(ModuleDefMD module)
        {
            foreach (var type in module.Types)
            {
                foreach (var method in type.Methods)
                {
                    if (!method.HasBody || !method.Body.HasInstructions) continue;

                    var instructions = method.Body.Instructions;
                    for (int i = 0; i < instructions.Count; i++)
                    {
                        if (instructions[i].OpCode == OpCodes.Ret && i > 0)
                        {
                            var nop = OpCodes.Nop.ToInstruction();
                            var ldcI4 = OpCodes.Ldc_I4.ToInstruction(0);
                            var brfalse = OpCodes.Brfalse_S.ToInstruction(nop);
                            instructions.Insert(i++, ldcI4);
                            instructions.Insert(i++, brfalse);
                            instructions.Insert(i++, nop);
                        }
                    }
                    method.Body.OptimizeMacros();
                }
            }
        }
    }
}
