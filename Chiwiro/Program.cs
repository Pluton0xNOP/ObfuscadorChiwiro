using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Chiwiro.Protecciones.ChangeName;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using static Chiwiro.Protecciones.Random;
using Core.Protecciones;


namespace Chiwiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                MessageBox.Show("Debe proporcionar la ruta del archivo como argumento.");
                return;
            }

            string modulePath = args[0];
            ModuleDefMD module = ModuleDefMD.Load(modulePath);
            AddDecryptMethodIfNeeded.AddDecryptMethodIfNeededp(module);
            InlineMethodIfNeeded.InlineMethodIfNeededp(module);
            AddFlowObfuscation.AddFlowObfuscationp(module);
            AddFakeMethods.AddFakeMethodsp(module, 30);
            ObfuscateEntryPoint.ObfuscateEntryPointp(module);
            Execute(module);

            string outputPath = Environment.CurrentDirectory + @"\Unprotected.exe";
            module.Write(outputPath);
            System.Threading.Thread.Sleep(4000);

           
        }

        private static void Execute(ModuleDefMD module)
        {
            Rename.Execute(module);
            RandomOutlinedMethods.Execute(module);
        }

        
    }
}
