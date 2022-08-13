using System.Windows.Forms;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESGSStudioCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider(new Dictionary<string, string>(){{"CompilerVersion", frameworkTextbox.Text}});
            CompilerParameters parameters = new CompilerParameters(new string[] {"mscorlib.dll", "System.Core.dll"}, nameTaxtbox.Text, true);
            parameters.GenerateExecutable = true;

            CompilerResults results = provider.CompileAssemblyFromSource(parameters, codeBox.Text);

            if (results.Errors.HasErrors)
            {
                foreach (CompilerError error in results.Errors.Cast<CompilerError>())
                    statusCode.Text = $"Line {error.Line}:      {error.ErrorText}";
            }
            else
            {
                statusCode.Text = $"<---Success--->";

                Process.Start($"{Application.StartupPath}/{nameTaxtbox.Text}");
            }
        }

        private void codeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
