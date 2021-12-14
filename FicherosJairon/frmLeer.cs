using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FicherosJairon
{
    public partial class frmLeer : Form
    {
        public frmLeer()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                string file = this.textArchivo.Text;
                FileStream archivo = new FileStream(file, FileMode.Open);
                StreamReader sr = new StreamReader(archivo);
                string cad, aux = "";
                cad = sr.ReadLine();
                while (cad != null)
                {
                    aux += cad + Environment.NewLine;
                    cad = sr.ReadLine();
                }
                this.textResultado.Text=aux;
                sr.Close();

            }
            catch (IOException e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //configuracion  de algunos parametros del openFileDialog
            // directorio inicial donde se abrira
            openFileDialog1.InitialDirectory = "C:\\";
            // filtro de archivos.
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";

            // codigo para abrir el cuadro de dialogo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string str_RutaArchivo = openFileDialog1.FileName;
                    textArchivo.Text = str_RutaArchivo;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
