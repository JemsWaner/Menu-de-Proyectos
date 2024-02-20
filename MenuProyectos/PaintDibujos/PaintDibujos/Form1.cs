using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintDibujos
{
    public partial class Form1 : Form
    {
        Graphics grap;
        Pen lapiz;
        int x = -1;
        int y = -1;
        bool moviendose=false;
        public int anchoLapiz=5;

        public Form1()
        {
            InitializeComponent();
            grap = panel1.CreateGraphics();
            grap.SmoothingMode= System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            lapiz= new Pen(Color.Black, anchoLapiz);
            lapiz.StartCap = lapiz.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox Pic = (PictureBox)sender;
            Pic.BorderStyle = BorderStyle.Fixed3D;
            lapiz.Color = Pic.BackColor;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moviendose = true;
            x= e.X;
            y= e.Y;
            panel1.Cursor = Cursors.Cross;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {   
            if(moviendose && x!=-1 && y != -1)
            {
                grap.DrawLine(lapiz,new Point(x,y),e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moviendose = false;
             x = -1;
             y = -1;
            panel1.Cursor = Cursors.Default;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int contadorValor = Convert.ToInt32(FontSize.Value);
            anchoLapiz = contadorValor;
            lapiz.Width = anchoLapiz;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
