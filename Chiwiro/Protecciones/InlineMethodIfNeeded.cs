using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet.Emit;


namespace Core.Protecciones
{
    internal class InlineMethodIfNeeded
    {
        public static void InlineMethodIfNeededp(ModuleDefMD module)
        {
            foreach (var type in module.GetTypes())
            {
                foreach (var method in type.Methods)
                {
                    if (method.IsPrivate && !method.IsConstructor && !method.IsStatic && method.HasBody)
                    {
                
                        if (method.Body.Instructions.Count < 50) 
                        {
                            InlineMethod(module, method);
                        }
                    }
                }
            }
        }

        static void InlineMethod(ModuleDefMD module, MethodDef methodToInline)
        {
            var instructionsToInline = methodToInline.Body.Instructions;
            foreach (var type in module.GetTypes())
            {
                foreach (var method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    var instructions = method.Body.Instructions;
                    for (int i = 0; i < instructions.Count; i++)
                    {
                        if (instructions[i].OpCode == OpCodes.Call && instructions[i].Operand is IMethod && instructions[i].Operand == methodToInline)
                        {
                            instructions.RemoveAt(i);
                            foreach (var inliningInstruction in instructionsToInline)
                            {
                                instructions.Insert(i++, inliningInstruction.Clone());
                            }
                        }
                    }
                }
            }
        }
    }
}
