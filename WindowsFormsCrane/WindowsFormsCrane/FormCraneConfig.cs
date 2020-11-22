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
    public partial class FormCraneConfig : Form
    {
        Vehicle crane = null;

        private event Action<Vehicle> addCrane;

        public FormCraneConfig()
        {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += (panelColor_MouseDown);
            panelBlack.MouseDown += (panelColor_MouseDown);
            panelWhite.MouseDown +=(panelColor_MouseDown);
            panelGray.MouseDown += (panelColor_MouseDown);
            panelOrange.MouseDown += (panelColor_MouseDown);
            panelGreen.MouseDown += (panelColor_MouseDown);
            panelBlue.MouseDown += (panelColor_MouseDown);
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawTransport()
        {
            if (crane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCrane.Width, pictureBoxCrane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                crane.SetPosition(5, 55, pictureBoxCrane.Width, pictureBoxCrane.Height);
                crane.DrawTransport(gr);
                pictureBoxCrane.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (addCrane == null)
            {
                addCrane = new Action<Vehicle>(ev);
            }
            else
            {
                addCrane += ev;
            }
        }

        private void labelCrane_MouseDown(object sender, MouseEventArgs e)
        {
            labelCrane.DoDragDrop(labelCrane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelSuperCrane_MouseDown(object sender, MouseEventArgs e)
        {
            labelSuperCrane.DoDragDrop(labelSuperCrane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelCrane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelCrane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Кран":
                    crane = new Crane((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Супер Кран":
                    crane = new SuperCrane((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
                        checkBoxCounterWeight.Checked, checkBoxLiftingDevice.Checked);
                    break;
            }
            DrawTransport();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel).DoDragDrop((sender as Panel).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(Color)) != null)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (crane != null)
            {
                crane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTransport();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (crane is SuperCrane && crane != null)
            {
                (crane as SuperCrane).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawTransport();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            addCrane?.Invoke(crane);
            Close();
        }

    }
}