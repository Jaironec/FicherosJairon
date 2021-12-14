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
    public partial class frmExplorador : Form
    {
        public frmExplorador()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string Carpeta=this.textCarpeta.Text;
            DirectoryInfo di = new DirectoryInfo(Carpeta);

            //recorre la lista y almacena en lisbox
            this.listaDeArchivos.Items.Clear();
            foreach(var archivo in di.GetFiles())
            {
                this.listaDeArchivos.Items.Add(archivo);
            }
        }
    }
}
