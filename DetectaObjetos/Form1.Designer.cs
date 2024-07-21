namespace DetectaObjetos
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
            this.components = new System.ComponentModel.Container();
            this.btnCargaImagen = new System.Windows.Forms.Button();
            this.btnCargaImagenProcesaPersonas = new System.Windows.Forms.Button();
            this.btnCargaImagenProcesaGatos = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargaImagen
            // 
            this.btnCargaImagen.Location = new System.Drawing.Point(12, 406);
            this.btnCargaImagen.Name = "btnCargaImagen";
            this.btnCargaImagen.Size = new System.Drawing.Size(415, 67);
            this.btnCargaImagen.TabIndex = 2;
            this.btnCargaImagen.Text = "CARGAR IMAGEN";
            this.btnCargaImagen.UseVisualStyleBackColor = true;
            this.btnCargaImagen.Click += new System.EventHandler(this.btnCargaImagen_Click);
            // 
            // btnCargaImagenProcesaPersonas
            // 
            this.btnCargaImagenProcesaPersonas.Location = new System.Drawing.Point(433, 406);
            this.btnCargaImagenProcesaPersonas.Name = "btnCargaImagenProcesaPersonas";
            this.btnCargaImagenProcesaPersonas.Size = new System.Drawing.Size(207, 67);
            this.btnCargaImagenProcesaPersonas.TabIndex = 3;
            this.btnCargaImagenProcesaPersonas.Text = "CARGA IMAGEN Y PROCESA PERSONAS";
            this.btnCargaImagenProcesaPersonas.UseVisualStyleBackColor = true;
            this.btnCargaImagenProcesaPersonas.Click += new System.EventHandler(this.btnCargaImagenProcesaPersonas_Click);
            // 
            // btnCargaImagenProcesaGatos
            // 
            this.btnCargaImagenProcesaGatos.Location = new System.Drawing.Point(658, 406);
            this.btnCargaImagenProcesaGatos.Name = "btnCargaImagenProcesaGatos";
            this.btnCargaImagenProcesaGatos.Size = new System.Drawing.Size(199, 67);
            this.btnCargaImagenProcesaGatos.TabIndex = 4;
            this.btnCargaImagenProcesaGatos.Text = "CARGA IMAGEN Y PROCESA GATOS";
            this.btnCargaImagenProcesaGatos.UseVisualStyleBackColor = true;
            this.btnCargaImagenProcesaGatos.Click += new System.EventHandler(this.btnCargaImagenProcesaGatos_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(415, 388);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(433, 12);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(424, 388);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 485);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnCargaImagenProcesaGatos);
            this.Controls.Add(this.btnCargaImagenProcesaPersonas);
            this.Controls.Add(this.btnCargaImagen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargaImagen;
        private System.Windows.Forms.Button btnCargaImagenProcesaPersonas;
        private System.Windows.Forms.Button btnCargaImagenProcesaGatos;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
    }
}

