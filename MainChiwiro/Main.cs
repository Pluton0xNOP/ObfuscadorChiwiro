using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnlib.DotNet;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.Metadata;
using ICSharpCode.Decompiler.TypeSystem;
using ICSharpCode.Decompiler;
using System.Reflection;


namespace MainChiwiro
{
    public partial class Main : MaterialForm
    {
        private string filePath;
        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void decompileapp()
        {
            string assemblyFile = filePath;
            StringBuilder sb = new StringBuilder();

            try
            {
        
                ModuleDefMD module = ModuleDefMD.Load(filePath);

    
                var entryPoint = module.EntryPoint;
                TypeDef mainClass = null;

                if (entryPoint != null)
                {
                    mainClass = entryPoint.DeclaringType; 
                    sb.AppendLine($"Punto de entrada: {entryPoint.FullName}");
                }

                sb.AppendLine("\nClases y Métodos en el ensamblado:");
                foreach (var type in module.GetTypes())
                {
                    sb.AppendLine($"Clase: {type.FullName}");
                    foreach (var method in type.Methods)
                    {
                        sb.AppendLine($"  Método: {method.Name}");
                    }
                }
                if (mainClass != null)
                {
                    original_code.Text = sb.ToString();
                    var resolver = new UniversalAssemblyResolver(assemblyFile, false, module.RuntimeVersion);
                    var decompilerSettings = new DecompilerSettings(LanguageVersion.Latest);
                    var decompiler = new CSharpDecompiler(assemblyFile, resolver, decompilerSettings);


                    var fullTypeName = new FullTypeName(mainClass.FullName);
                    var decompiledSource = decompiler.DecompileTypeAsString(fullTypeName);

                    original_code.AppendText("\nCódigo Fuente de la Clase Principal:\n\n");
                    original_code.AppendText(decompiledSource);
                    ResaltarSintaxis();
        
                }
                else
                {
                    MessageBox.Show("No se encontró la clase principal mediante el punto de entrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el ensamblado: {ex.Message}");
            }


        }

        //======================================
        public void decompileobf()
        {
            string assemblyFile = "Unprotected.exe";
            StringBuilder sb = new StringBuilder();

            try
            {
                System.Threading.Thread.Sleep(8000);
              
                ModuleDefMD module = ModuleDefMD.Load(assemblyFile);

              
                var entryPoint = module.EntryPoint;
                TypeDef mainClass = null;

                if (entryPoint != null)
                {
                    mainClass = entryPoint.DeclaringType; 
                    sb.AppendLine($"Punto de entrada: {entryPoint.FullName}");
                }

                // Listar todas las clases y métodos
                sb.AppendLine("\nClases y Métodos en el ensamblado:");
                foreach (var type in module.GetTypes())
                {
                    sb.AppendLine($"Clase: {type.FullName}");
                    foreach (var method in type.Methods)
                    {
                        sb.AppendLine($"  Método: {method.Name}");
                    }
                }

                if (mainClass != null)
                {
                    codepro.Text = sb.ToString();

                    var resolver = new UniversalAssemblyResolver(assemblyFile, false, module.RuntimeVersion);
                    var decompilerSettings = new DecompilerSettings(LanguageVersion.Latest);
                    var decompiler = new CSharpDecompiler(assemblyFile, resolver, decompilerSettings);

                    var fullTypeName = new FullTypeName(mainClass.FullName);
                    var decompiledSource = decompiler.DecompileTypeAsString(fullTypeName);
                    codepro.AppendText("\nCódigo Fuente de la Clase Principal:\n\n");
                    codepro.AppendText(decompiledSource);
 
 
                }
                else
                {
                    MessageBox.Show("No se encontró la clase principal mediante el punto de entrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el ensamblado: {ex.Message}");
            }




        }
        //======================================

        private void Main_Load(object sender, EventArgs e)
        {


        }

        private void ResaltarSintaxis()
        {
            var palabrasClaveMetodos = new Dictionary<string, Color>
            {
        { "void", Color.Blue },
        { "int", Color.Blue },
        { "string", Color.Blue },
        { "public", Color.Red },
        { "private", Color.Red },
        { "protected", Color.Red },
        { "class", Color.Blue },
        { "Console.Write", Color.Red },
         { "Write", Color.Gray },

        };

            int selectionStart = codepro.SelectionStart;

            codepro.SuspendLayout();

            foreach (var palabra in palabrasClaveMetodos)
            {
                int startIndex = 0;
                while (startIndex < codepro.TextLength)
                {
                    int wordStartIndex = codepro.Find(palabra.Key, startIndex, RichTextBoxFinds.WholeWord);
                    if (wordStartIndex == -1) break;

                    codepro.SelectionStart = wordStartIndex;
                    codepro.SelectionLength = palabra.Key.Length;
                    codepro.SelectionColor = palabra.Value;

                    startIndex = wordStartIndex + palabra.Key.Length;
                }
            }

            codepro.SelectionColor = Color.Black;
            codepro.SelectionStart = selectionStart;
            codepro.SelectionLength = 0;
            codepro.ResumeLayout();
        }

        private void loadfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Archivos ejecutables (*.exe)|*.exe";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                path.Text = filePath;
            }

            decompileapp();
       


        }

        public void Log()
        {
      
            string fechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

         
            string[] mensajes = {
                "Se añadió encriptación a las strings.",
                "Se añadió método de líneas nuevas.",
                "Se arregló flujo de obfuscación.",
                "Se agregaron módulos falsos.",
                "Se encriptó el punto de entrada."
            };

          
            StringBuilder registro = new StringBuilder();
            registro.AppendLine("Registro de cambios - " + fechaHora);
            registro.AppendLine("--------------------------------------");
            foreach (string mensaje in mensajes)
            {
                
                registro.AppendLine("- " + mensaje).AppendLine();
            }
            registro.AppendLine("--------------------------------------");

            log_text.Text = registro.ToString();

           
            log_text.Select(0, "Registro de cambios - 2024-04-03 04:36:52".Length);
            log_text.SelectionColor = Color.Red;
        }

        private void obfuscar_Click(object sender, EventArgs e)
        {
            string executablePath = "Core.exe";


            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Por favor, selecciona un archivo antes de intentar obfuscarlo.");
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = executablePath;
            startInfo.Arguments = filePath;

            Process.Start(startInfo);

            Log();
            
            decompileobf();
        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void logtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
