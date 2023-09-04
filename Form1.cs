using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace PryKaplanCarpetas
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

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            ventanaCarpetas.ShowDialog();

            // Seleccionar una carpeta
            lblEjemplo.Text = ventanaCarpetas.SelectedPath;
        }

        private void btnGrabarArchivo_Click(object sender, EventArgs e)
        {
            // Ruta del archivo
            string ruta = lblEjemplo.Text;

            //Nombre del archivo
            ruta += "/" + txtNombreArchivo.Text;

            StreamWriter manejoArchivo = new StreamWriter(ruta);

            MessageBox.Show("Archivo Creado " + txtNombreArchivo.Text);

        }
    }
}
