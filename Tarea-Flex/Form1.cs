using System;
using System.Windows.Forms;

namespace Tarea_Flex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            dgvTokens.Rows.Clear();

            string texto = txtCodigo.Text;

            string[] palabras = texto.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string palabra in palabras)
            {
                if (palabra == "inicio" ||
                    palabra == "fin" ||
                    palabra == "si" ||
                    palabra == "sino")
                {
                    dgvTokens.Rows.Add("PALABRA_RESERVADA", palabra);
                }
                else if (int.TryParse(palabra, out _))
                {
                    dgvTokens.Rows.Add("NUMERO", palabra);
                }
                else if (palabra == "+" ||
                         palabra == "-" ||
                         palabra == "*" ||
                         palabra == "/" ||
                         palabra == "=")
                {
                    dgvTokens.Rows.Add("OPERADOR", palabra);
                }
                else
                {
                    dgvTokens.Rows.Add("IDENTIFICADOR", palabra);
                }
            }
        }
    }
}