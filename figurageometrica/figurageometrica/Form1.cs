using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace figurageometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void POLIGONOREGULAR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ESPERA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            
            {
                DATOS.Clear();
                Rectangulo.Checked = false;
                Prisma.Checked = false;
                Cuadrado.Checked = false;
                Poligonoirregular.Checked = false;
                Poligonoregular.Checked = false;
                Esfera.Checked = false;
                Cubo.Checked = false;
                Circulo.Checked = false;
                Triangulo.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            {
                if (Cuadrado.Checked)
                {
                    MessageBox.Show("Los datos de la figura cuadrado estan actualizados");
                }
                if (Triangulo.Checked)
                {
                    MessageBox.Show("Los datos de la figura triangulo estan actualizados");
                }
                if (Circulo.Checked)
                {
                    MessageBox.Show("Los datos de la figura circulo estan actualizados");
                }
                if (Cubo.Checked)
                {
                    MessageBox.Show("Los datos de la figura cubo estan actualizados");
                }
                if (Esfera.Checked)
                {
                    MessageBox.Show("Los datos de la figura esfera estan actualizados");
                }
                if (Poligonoirregular.Checked)
                {
                    MessageBox.Show("Los datos del poligono irregular estan actualizados");
                }
                if (Poligonoregular.Checked)
                {
                    MessageBox.Show("Los datos del poligono regular estan actualizados");
                }
                if (Prisma.Checked)
                {
                    MessageBox.Show("Los datos de la figura prisma estan actualizados");
                }
                if (Rectangulo.Checked)
                {
                    MessageBox.Show("Los datos del rectangulo estan actualizados");
                }

            }
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {

        }

        private void DIBUJAR_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked)
            {
                string rutaImagen = "D:\\Leeeo\\figurageometrica\\figurageometrica\\imagenes\\images.jpg";
                IMAGEN .BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Triangulo.Checked)
            {
                string rutaImagen = "D:\\Leeeo\\figurageometrica\\figurageometrica\\imagenes\\Figura-1-Triangulo-mediacional-Fuente-Cole-2003_Q320.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Circulo.Checked)
            {
                string rutaImagen = "D:\\Leeeo\\figurageometrica\\figurageometrica\\imagenes\\images.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Cubo.Checked)
            {
                string rutaImagen = "D:\\Leeeo\\figurageometrica\\figurageometrica\\imagenes\\cubo-1.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Esfera.Checked)
            {
                string rutaImagen = "D:\\Leeeo\\figurageometrica\\figurageometrica\\imagenes\\sphere-red-3d-ball-illustration-vector.jpg";
                IMAGEN .BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Poligonoirregular.Checked)
            {
                string rutaImagen = "D:\\Leeeo\\figurageometrica\\figurageometrica\\imagenes\\6564674799110feb4078af1f5ab519de.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Poligonoregular.Checked)
            {
                string rutaImagen = "D:\\Leeeo\\figurageometrica\\figurageometrica\\imagenes\\5007b2cb84d45832cce50d88f14d605a.jpg";
                IMAGEN .BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Prisma.Checked)
            {
                string rutaImagen = "D:\\Leeeo\\figurageometrica\\figurageometrica\\imagenes\\como_sacar_el_area_de_un_prisma_37156_600.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Rectangulo.Checked)
            {
                string rutaImagen = "D:\\Leeeo\\figurageometrica\\figurageometrica\\imagenes\\como_calcular_el_perimetro_de_un_rectangulo_40006_600.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
        }
    }
}
