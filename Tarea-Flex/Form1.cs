using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tarea_Flex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvTokens.Visible = false;
        }

        private bool AnalizarSintaxis(string texto)
        {
            string patron = @"^int\s+[a-zA-Z_][a-zA-Z0-9_]*\s*=\s*(\d+|""[^""]*"")\s*;$";
            return Regex.IsMatch(texto.Trim(), patron);
        }

        private bool AnalizarSemantica(string texto)
        {
            // Semántica real: int NO puede recibir texto
            string patron = @"^int\s+[a-zA-Z_][a-zA-Z0-9_]*\s*=\s*\d+\s*;$";
            return Regex.IsMatch(texto.Trim(), patron);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            dgvTokens.Rows.Clear();

            string texto = txtCodigo.Text;

            string[] operadores =
            {
                "==", "!=", "<=", ">=", "++", "--",
                "+", "-", "*", "/", "=",
                "<", ">", "(", ")", "{", "}",
                ";", ","
            };

            foreach (string op in operadores)
            {
                texto = texto.Replace(op, " " + op + " ");
            }

            string[] palabras = texto.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string palabra in palabras)
            {
                if (
                    palabra == "abstract" || palabra == "as" || palabra == "base" ||
                    palabra == "bool" || palabra == "break" || palabra == "byte" ||
                    palabra == "case" || palabra == "catch" || palabra == "char" ||
                    palabra == "checked" || palabra == "class" || palabra == "const" ||
                    palabra == "continue" || palabra == "decimal" || palabra == "default" ||
                    palabra == "delegate" || palabra == "do" || palabra == "double" ||
                    palabra == "else" || palabra == "enum" || palabra == "event" ||
                    palabra == "explicit" || palabra == "extern" || palabra == "false" ||
                    palabra == "finally" || palabra == "fixed" || palabra == "float" ||
                    palabra == "for" || palabra == "foreach" || palabra == "goto" ||
                    palabra == "if" || palabra == "implicit" || palabra == "in" ||
                    palabra == "int" || palabra == "interface" || palabra == "internal" ||
                    palabra == "is" || palabra == "lock" || palabra == "long" ||
                    palabra == "namespace" || palabra == "new" || palabra == "null" ||
                    palabra == "object" || palabra == "operator" || palabra == "out" ||
                    palabra == "override" || palabra == "params" || palabra == "private" ||
                    palabra == "protected" || palabra == "public" || palabra == "readonly" ||
                    palabra == "ref" || palabra == "return" || palabra == "sbyte" ||
                    palabra == "sealed" || palabra == "short" || palabra == "sizeof" ||
                    palabra == "stackalloc" || palabra == "static" || palabra == "string" ||
                    palabra == "struct" || palabra == "switch" || palabra == "this" ||
                    palabra == "throw" || palabra == "true" || palabra == "try" ||
                    palabra == "typeof" || palabra == "uint" || palabra == "ulong" ||
                    palabra == "unchecked" || palabra == "unsafe" || palabra == "ushort" ||
                    palabra == "using" || palabra == "virtual" || palabra == "void" ||
                    palabra == "volatile" || palabra == "while"
                )
                {
                    dgvTokens.Rows.Add("PALABRA_RESERVADA", palabra);
                }
                else if (int.TryParse(palabra, out _))
                {
                    dgvTokens.Rows.Add("NUMERO", palabra);
                }
                else if (
                    palabra == "+" || palabra == "-" || palabra == "*" ||
                    palabra == "/" || palabra == "=" || palabra == "==" ||
                    palabra == "!=" || palabra == "<" || palabra == ">" ||
                    palabra == "<=" || palabra == ">=" || palabra == "++" ||
                    palabra == "--"
                )
                {
                    dgvTokens.Rows.Add("OPERADOR", palabra);
                }
                else if (
                    palabra == "(" || palabra == ")" || palabra == "{" ||
                    palabra == "}" || palabra == ";" || palabra == ","
                )
                {
                    dgvTokens.Rows.Add("DELIMITADOR", palabra);
                }
                else if (Regex.IsMatch(palabra, @"^[a-zA-Z_][a-zA-Z0-9_]*$"))
                {
                    dgvTokens.Rows.Add("IDENTIFICADOR", palabra);
                }
                else
                {
                    dgvTokens.Rows.Add("ERROR_LEXICO", palabra);
                }
            }

            // -------------------------
            // ANALISIS SINTÁCTICO
            // -------------------------
            if (AnalizarSintaxis(txtCodigo.Text))
            {
                lblSintaxis.Text = "Sintaxis correcta";
            }
            else
            {
                lblSintaxis.Text = "Error sintáctico";
            }

            // -------------------------
            // ANALISIS SEMÁNTICO
            // -------------------------
            if (AnalizarSemantica(txtCodigo.Text))
            {
                lblSemantica.Text = "Semántica correcta";
            }
            else
            {
                lblSemantica.Text = "Error semántico";
            }
        }

        private void lblSintaxis_Click(object sender, EventArgs e)
        {
        }
    }
}