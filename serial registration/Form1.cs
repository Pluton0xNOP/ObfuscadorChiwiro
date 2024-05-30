using dnlib.DotNet;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.Metadata;
using ICSharpCode.Decompiler.TypeSystem;
using ICSharpCode.Decompiler;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace serial_registration
{
    public partial class Serialdb : Form
    {
        public Serialdb()
        {
            InitializeComponent();
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

            int selectionStart = richTextBox1.SelectionStart;

            richTextBox1.SuspendLayout();

            foreach (var palabra in palabrasClaveMetodos)
            {
                int startIndex = 0;
                while (startIndex < richTextBox1.TextLength)
                {
                    int wordStartIndex = richTextBox1.Find(palabra.Key, startIndex, RichTextBoxFinds.WholeWord);
                    if (wordStartIndex == -1) break;

                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionLength = palabra.Key.Length;
                    richTextBox1.SelectionColor = palabra.Value;

                    startIndex = wordStartIndex + palabra.Key.Length;
                }
            }

            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = 0;
            richTextBox1.ResumeLayout();
        }


        private void Serialdb_Load(object sender, EventArgs e)
        {
            string assemblyFile = "App.exe";
            StringBuilder sb = new StringBuilder();

            try
            {
                // Cargar el ensamblado con dnlib
                ModuleDefMD module = ModuleDefMD.Load(assemblyFile);

                // Obtener el punto de entrada del ensamblado
                var entryPoint = module.EntryPoint;
                TypeDef mainClass = null;

                if (entryPoint != null)
                {
                    mainClass = entryPoint.DeclaringType; // La clase que declara el método de entrada
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

                // Si se encontró la clase del punto de entrada, procedemos a decompilar
                if (mainClass != null)
                {
                    // Mostrar las clases y métodos encontrados hasta el momento
                    richTextBox1.Text = sb.ToString();

                    // Configurar el decompilador
                    var resolver = new UniversalAssemblyResolver(assemblyFile, false, module.RuntimeVersion);
                    var decompilerSettings = new DecompilerSettings(LanguageVersion.Latest);
                    var decompiler = new CSharpDecompiler(assemblyFile, resolver, decompilerSettings);

                    // Decompilar la clase del punto de entrada
                    var fullTypeName = new FullTypeName(mainClass.FullName);
                    var decompiledSource = decompiler.DecompileTypeAsString(fullTypeName);

                    // Mostrar el código fuente decompilado en el RichTextBox
                    richTextBox1.AppendText("\nCódigo Fuente de la Clase Principal:\n\n");
                    richTextBox1.AppendText(decompiledSource);
                    // Aquí llamarías a ResaltarSintaxis() si deseas resaltar la sintaxis en el RichTextBox
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
    }
}
