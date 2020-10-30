using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WinAppElementosInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxImagen.Visible = false;
            pictureBox1.Visible = false;
        }

        private void buttonMostrarImagen_Click(object sender, EventArgs e)
        {
            pictureBoxImagen.Visible = true;
        }

        private void buttonBeep_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            pictureBox1.Visible = true;
        }

        private void comboBoxPunteros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPunteros.SelectedIndex == 0) {
                this.Cursor = Cursors.Hand;
            }else if (comboBoxPunteros.SelectedIndex == 1)
            {
                this.Cursor = Cursors.WaitCursor;
            }else 
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            pictureBox1.Visible = true;
        }

        private void buttonExclamacion_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            pictureBox1.Visible = true;
        }

        private void buttonMano_Click(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
            pictureBox1.Visible = true;
        }

        private void buttonPregunta_Click(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
            pictureBox1.Visible = true;
        }
    }
}
