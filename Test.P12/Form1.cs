using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Test.P12
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Validación firma eleclectrónica (.P12)";
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void BtnValidar_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Validamos que exista el archivo
                if (!File.Exists(textBox1.Text))
                {
                    MessageBox.Show($"No se encuntra la firma electrónica");
                    return;
                }

                // Validamos que el archivo sea .P12
                FileInfo fileInfo = new FileInfo(textBox1.Text);
                if (fileInfo.Extension.ToLower() != ".p12")
                {
                    MessageBox.Show($"La extensión de la firma electrónica debe ser .P12");
                    return;
                }

                // Validamos la firma
                X509Certificate2 x509Certificate2 = new X509Certificate2(textBox1.Text, textBox2.Text, X509KeyStorageFlags.DefaultKeySet);

                // Colocamos las fechas
                lblFechaEmision.Text = $"Fecha de emisión: {x509Certificate2.NotBefore:dd/MM/yyyy}";
                lblFechaVencimiento.Text = $"Fecha de vencimiento: {x509Certificate2.NotAfter:dd/MM/yyyy}";

                MessageBox.Show("Firma electrónica correcta");
            }
            catch (Exception ex)
            {
                // Colocamos las fechas
                lblFechaEmision.Text = $"Fecha de emisión:";
                lblFechaVencimiento.Text = $"Fecha de vencimiento:";

                MessageBox.Show($"Ah ocurido un error; {ex.Message}");
            }
        }
    }
}