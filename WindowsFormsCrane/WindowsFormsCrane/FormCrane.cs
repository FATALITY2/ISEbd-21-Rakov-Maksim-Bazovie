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
    public partial class FormCrane : Form
    {
        private ITransport crane;
        public FormCrane()
        {
            InitializeComponent();
        }
        public void SetCrane(ITransport crane)
        {
            this.crane = crane;
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCrane.Width, pictureBoxCrane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            crane.DrawTransport(gr);
            pictureBoxCrane.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    crane?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    crane?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    crane?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    crane?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}