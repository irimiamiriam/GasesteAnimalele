using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasesteAnimalele
{
    public partial class Form1 : Form
    {

        Button currbutton;
        PictureBox currpb;
        int corecte = 0;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void buttonPisica_Click(object sender, EventArgs e)
        {
           Button button = (Button)sender;
            if (currpb != null) {
                if (currpb.Tag.ToString() == button.Tag.ToString())
                {
                    currpb.Dispose();
                    button.Dispose();
                    currbutton = null; currpb = null;
                    corecte++;
                    if (corecte == 6) { MessageBox.Show("Felicitari!", "Ai castigat!"); this.Close(); }
                }
                else {
                    currpb = null;
                }
            }else
            {
                currbutton = (Button)sender;
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (currbutton != null)
            {
                if (currbutton.Tag.ToString().Equals(pictureBox.Tag.ToString())) { currbutton.Dispose(); pictureBox.Dispose(); currbutton = null; currpb = null; corecte++;
                    if (corecte == 6) { MessageBox.Show("Felicitari!", "Ai castigat!"); this.Close(); }
                }
                else { currbutton = null; }

            }
            else {
                currpb= (PictureBox)sender;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls) {
                if(control is Button)
                {
                    Button button = (Button)control;
                    button.Click += buttonPisica_Click;
                }
            }
            foreach (Control control in panel1.Controls) {
                if (control is PictureBox) {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Click += pictureBox8_Click;
                }
            }
        }
    }
}
