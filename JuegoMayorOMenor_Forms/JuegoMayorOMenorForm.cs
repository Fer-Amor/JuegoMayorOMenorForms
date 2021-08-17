using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMayorOMenor_Forms
{
    public partial class JuegoMayorOMenorForm : Form
    {
        //Atributos
        //MazoDeCartas cartasDeTruco;
        string cartaImagePath;
        Image imagenCarta;
        JuegoMayorOMenorEventos juegoMOM;

        public JuegoMayorOMenorForm()
        {
            InitializeComponent();
            //cartasDeTruco = new(MazoDeCartas.Tipos.Truco);
            //cartasDeTruco.Mezclar();

            juegoMOM = new(5);
            juegoMOM.CambioDeEstado += JuegoMOM_CambioDeEstado;
            botonDeReset.Text = "Comenzar";
            botonDeReset.Enabled = true;
            botonMayor.Enabled = false;
            botonMenor.Enabled = false;
            labelPuntuacion.Visible = false;
            labelChancesRestantes.Visible = false;
        }

        private void JuegoMOM_CambioDeEstado(object sender, EventArgs e)
        {
            var juegoMOM = sender as JuegoMayorOMenorEventos;
            
            if (juegoMOM.Estado == JuegoMayorOMenor.Estados.perdio)
            {
                botonDeReset.Enabled = true;
                botonMayor.Enabled = false;
                botonMenor.Enabled = false;
                labelPuntuacion.Visible = true;
                labelChancesRestantes.Visible = false;
                ImprimirPuntuacion();
            }
            if (juegoMOM.Estado == JuegoMayorOMenor.Estados.jugando)
            {
                botonDeReset.Enabled = false;
                botonMayor.Enabled = true;
                botonMenor.Enabled = true;
                labelPuntuacion.Visible = false;
                labelChancesRestantes.Visible = true;
                ImprimirCartaEnPictureBox();
                ImprimirChancesRestantes();
            }
        }

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {
            cartaImagePath = juegoMOM.DameUltimaCarta().ImagePath;
            imagenCarta = Image.FromFile(cartaImagePath);
            Graphics gfx = pictureBox1.CreateGraphics();
            gfx.DrawImage(imagenCarta, new Point(0, 0));
        }*/

        private void botonMayor_Click(object sender, EventArgs e)
        {
            juegoMOM.Apostar(JuegoMayorOMenor.TiposDeEleccion.Mayor);
            ImprimirChancesRestantes();
            ImprimirCartaEnPictureBox();
        }

        private void botonMenor_Click(object sender, EventArgs e)
        {
            juegoMOM.Apostar(JuegoMayorOMenor.TiposDeEleccion.Menor);
            ImprimirChancesRestantes();
            ImprimirCartaEnPictureBox();
        }

        private void botonDeReset_Click(object sender, EventArgs e)
        {
            botonDeReset.Text = "Resetear";
            juegoMOM.Resetear();
        }
        private void ImprimirCartaEnPictureBox()
        {
            cartaImagePath = juegoMOM.DameUltimaCarta().ImagePath;
            imagenCarta = Image.FromFile(cartaImagePath);
            Graphics gfx = pictureBox1.CreateGraphics();
            gfx.DrawImage(imagenCarta, new Point(0, 0));

            imagenCarta.Dispose();
            gfx.Dispose();
        }
        private void ImprimirChancesRestantes()
        {
            labelChancesRestantes.Text = "Chances restantes: " +juegoMOM.ChancesRestantes().ToString();
        }
        private void ImprimirPuntuacion()
        {
            labelPuntuacion.Text = "Puntuación: " + juegoMOM.Puntuacion().ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ImprimirCartaEnPictureBox();
        }
    }
}
