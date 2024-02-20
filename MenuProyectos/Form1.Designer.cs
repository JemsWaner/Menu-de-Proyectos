namespace MenuProyectos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Calculadora = new System.Windows.Forms.Button();
            this.PaintDibujo = new System.Windows.Forms.Button();
            this.EditorTexto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Calculadora);
            this.panel1.Controls.Add(this.PaintDibujo);
            this.panel1.Controls.Add(this.EditorTexto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 491);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Calculadora
            // 
            this.Calculadora.BackColor = System.Drawing.Color.LightGreen;
            this.Calculadora.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculadora.Location = new System.Drawing.Point(199, 313);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(330, 82);
            this.Calculadora.TabIndex = 3;
            this.Calculadora.Text = "Calculadora";
            this.Calculadora.UseVisualStyleBackColor = false;
            this.Calculadora.Click += new System.EventHandler(this.Calculadora_Click);
            // 
            // PaintDibujo
            // 
            this.PaintDibujo.BackColor = System.Drawing.Color.MistyRose;
            this.PaintDibujo.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaintDibujo.Location = new System.Drawing.Point(199, 207);
            this.PaintDibujo.Name = "PaintDibujo";
            this.PaintDibujo.Size = new System.Drawing.Size(330, 82);
            this.PaintDibujo.TabIndex = 2;
            this.PaintDibujo.Text = "Paint Dibujo";
            this.PaintDibujo.UseVisualStyleBackColor = false;
            this.PaintDibujo.Click += new System.EventHandler(this.PaintDibujo_Click);
            // 
            // EditorTexto
            // 
            this.EditorTexto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditorTexto.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorTexto.Location = new System.Drawing.Point(199, 99);
            this.EditorTexto.Name = "EditorTexto";
            this.EditorTexto.Size = new System.Drawing.Size(330, 82);
            this.EditorTexto.TabIndex = 1;
            this.EditorTexto.Text = "Editor de texto";
            this.EditorTexto.UseVisualStyleBackColor = false;
            this.EditorTexto.Click += new System.EventHandler(this.EditorTexto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.label1.Size = new System.Drawing.Size(400, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyectos Disponibles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 491);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculadora;
        private System.Windows.Forms.Button PaintDibujo;
        private System.Windows.Forms.Button EditorTexto;
    }
}

