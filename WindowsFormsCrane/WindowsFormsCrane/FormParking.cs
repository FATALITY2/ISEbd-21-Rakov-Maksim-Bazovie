using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCrane
{
    public partial class FormParking : Form
    {
        private readonly Parking<Crane> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Crane>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetCrane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var crane = new Crane(100, 1000, dialog.Color);
                if (parking + crane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonSetSuperCrane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var superCrane = new SuperCrane(100, 1000, dialog.Color, dialog.Color, true, true);
                    if (parking + superCrane)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNumber.Text != "")
            {
                var crane = parking - Convert.ToInt32(maskedTextBoxNumber.Text);
                if (crane != null)
                {
                    FormCrane form = new FormCrane();
                    form.SetCrane(crane);
                    form.ShowDialog();
                }
                Draw();
            }
        }

       
    }
}
