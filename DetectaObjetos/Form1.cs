using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using System.Threading;


namespace DetectaObjetos
{
    public partial class Form1 : Form
    {
        private CascadeClassifier _CascadeClassifier;
       
        public Form1()
        {
            InitializeComponent();
            _CascadeClassifier = new CascadeClassifier(Application.StartupPath + "/haarcascade_frontalface_default.xml");
            _CascadeClassifier1 = new CascadeClassifier(Application.StartupPath + "/haarcascade_frontalcatface_extended.xml");
        }

        private void btnCargaImagen_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> imagen = new Image<Bgr, byte>(open.FileName);
                imageBox1.Image = imagen;
                using (var imageFrame = imagen)
                {
                    if (imageFrame != null)
                    {
                        var grayFrame = imageFrame.Convert<Bgr, Byte>();
                       
                       

                    }
                }
            }
        }

        private void btnCargaImagenProcesaPersonas_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> imagen = new Image<Bgr, byte>(open.FileName);
                imageBox2.Image = imagen;
                using (var imageFrame = imagen)
                {
                    if (imageFrame != null)
                    {
                        var grayFrame = imageFrame.Convert<Bgr, Byte>();
                        var faces = _CascadeClassifier.DetectMultiScale(grayFrame, 1.1, 10, Size.Empty);
                        


                        foreach (var face in faces)
                        {
                            imageFrame.Draw(face, new Bgr(Color.Green), 3);
                            
                        }
                    }
                }
            }
        }
        private CascadeClassifier _CascadeClassifier1;
        private void btnCargaImagenProcesaGatos_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> imagen = new Image<Bgr, byte>(open.FileName);
                imageBox2.Image = imagen;
                using (var imageFrame = imagen)
                {
                    if (imageFrame != null)
                    {
                        var grayFrame = imageFrame.Convert<Bgr, Byte>();
                        var cats = _CascadeClassifier1.DetectMultiScale(grayFrame, 1.1, 10, Size.Empty);



                        foreach (var cat in cats)
                        {
                            imageFrame.Draw(cat, new Bgr(Color.Blue), 3);

                        }
                    }
                }
            }
        }

        }
    }

