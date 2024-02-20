using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuProyectos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirMyProyecto(string ruta)
        {
            try
            {
                string directorioActual = Directory.GetCurrentDirectory();

                
                string directorioPadre = Directory.GetParent(directorioActual).FullName;
                
                string directorioPadre2 = Directory.GetParent(directorioPadre).FullName;
                
                string otraRuta = Path.Combine(directorioPadre2, ruta,ruta,"bin","Debug",$"{ruta}.exe");
                
                Process.Start(otraRuta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar el proyecto externo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditorTexto_Click(object sender, EventArgs e)
        {
            AbrirMyProyecto("TextEditor");
        }

        private void PaintDibujo_Click(object sender, EventArgs e)
        {
            AbrirMyProyecto("PaintDibujos");
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            AbrirMyProyecto("calculadora");
        }
    }
}
