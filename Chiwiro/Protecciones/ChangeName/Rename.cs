using dnlib.DotNet;
using Chiwiro.Protecciones.ChangeName.Analy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiwiro.Protecciones.ChangeName
{
    internal class Rename
    {
        public static void Execute(ModuleDefMD module)
        {
            foreach (var type in module.Types)
            {
                if (CanRename(type))
                {
                    type.Name = Chiwiro.Utilidades.Randoms.RandomString();
                }

                foreach (var method in type.Methods)
                {
  
                    if (CanRename(method))
                    {
                        method.Name = Chiwiro.Utilidades.Randoms.RandomString();
                    }

                    foreach (var param in method.Parameters)
                    {
                        param.Name = Chiwiro.Utilidades.Randoms.RandomString();
                    }
                }

                foreach (var property in type.Properties)
                {
                    if (CanRename(property))
                    {
                        property.Name = Chiwiro.Utilidades.Randoms.RandomString();
                    }
                }

                foreach (var field in type.Fields)
                {
                    if (CanRename(field))
                    {
                        field.Name = Chiwiro.Utilidades.Randoms.RandomString();
                    }
                }
            }
        }


        public static bool CanRename(object obj)
        {
            Chiwiro.Protecciones.ChangeName.Analy.iAnalyze analyze = null;

            if (obj is TypeDef)
            {
                analyze = new TypeDefAnalyzer();
            }
            else if (obj is MethodDef)
            {
                analyze = new MethodDefAnalyzer();
            }
            else if (obj is EventDef)
            {
                analyze = new EventDefAnalyzer();
            }
            else if (obj is FieldDef)
            {
                analyze = new FieldDefAnalyzer();
            }


            if (analyze == null)
            {
                return false;
            }
            return analyze.Execute(obj);
        }


    }
}

