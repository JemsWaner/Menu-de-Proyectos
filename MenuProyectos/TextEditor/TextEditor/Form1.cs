using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        ManejoArchivo manejoArchivo= new ManejoArchivo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manejoArchivo.Guardar(richTextBox1);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manejoArchivo.GuardarComo(richTextBox1);
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textoDatos= manejoArchivo.Abrir(richTextBox1);
            richTextBox1.Text = textoDatos;

        }
    }
}
