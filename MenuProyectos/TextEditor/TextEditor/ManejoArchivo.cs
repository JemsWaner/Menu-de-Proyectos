using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    internal class ManejoArchivo
    {
        public static string ruta;
        public SaveFileDialog archivo;

        public void Guardar(RichTextBox texto) { 

            archivo= new SaveFileDialog();
            archivo.DefaultExt = "*.rtf";
            archivo.Filter = "RTF Files | *.rtf | PDF Files | *.pdf | TXT Files | *.txt | Word Documents | *.doc;*.docx";

            if (texto.Text.Length > 0)
            {
                if (!string.IsNullOrEmpty(ruta)) {
                    texto.SaveFile(ruta, RichTextBoxStreamType.PlainText);
                }
                else if (archivo.ShowDialog() == DialogResult.OK)
                {
                    texto.SaveFile(archivo.FileName, RichTextBoxStreamType.PlainText);
                    ruta = archivo.FileName;
                    MessageBox.Show(ruta);

                }
               
            }

            else
            {
                MessageBox.Show("El campo esta vacio, no se puede guardar nada");
            }
           
        }

        public void GuardarComo(RichTextBox texto) {

            archivo = new SaveFileDialog();
            archivo.DefaultExt = "*.rtf";
            archivo.Filter = "RTF Files | *.rtf | PDF Files | *.pdf | TXT Files | *.txt | Word Documents | *.doc;*.docx";

            if (texto.Text.Length > 0)
            {
                MessageBox.Show(texto.Text);
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    texto.SaveFile(archivo.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            else
            {
                MessageBox.Show("El campo esta vacio, no se puede guardar nada, ingrese un texto");
            }
            
        }

        public string Abrir(RichTextBox textoDefault) {
            ruta = "";
            string resultadoTexto = textoDefault.Text;

            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.DefaultExt = "*.rtf";
            abrirArchivo.Filter = "RTF Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            abrirArchivo.RestoreDirectory = true;
            
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                ruta = abrirArchivo.FileName;
                resultadoTexto = File.ReadAllText(ruta);
            }

            return resultadoTexto;
        }
    }
}
