using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    public class SuperCrane : Crane
    {
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected const int carHeight = 60;

        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия противовеса
        /// </summary>
        public bool CounterWeight { private set; get; }
        /// <summary>
        /// Признак наличия подъемного устройства
        /// </summary>
        public bool LiftingDevice { private set; get; }
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет</param>
        public SuperCrane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool counterweight, bool liftingDevice) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;

            CounterWeight = counterweight;

            LiftingDevice = liftingDevice;
        }

        public SuperCrane(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                CounterWeight = Convert.ToBoolean(strs[4]);
                LiftingDevice = Convert.ToBoolean(strs[5]);               
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            base.DrawTransport(g);

            if (CounterWeight)
            {
                g.DrawRectangle(pen, _startPosX + 160, _startPosY + 20, 22, 44);
                g.DrawLine(pen, _startPosX + 125, _startPosY + 30, _startPosX + 162, _startPosY - 10);
                g.DrawRectangle(pen, _startPosX + 140, _startPosY + 19, 13, 6);
                g.DrawRectangle(pen, _startPosX + 85, _startPosY + 60, 45, 5);
                g.DrawRectangle(pen, _startPosX + 60, _startPosY + 30, 10, 20);
                g.FillRectangle(dopBrush, _startPosX + 161, _startPosY + 21, 21, 43);
                g.FillRectangle(dopBrush, _startPosX + 141, _startPosY + 20, 12, 5);
                g.FillRectangle(dopBrush, _startPosX + 86, _startPosY + 61, 44, 4);
            }

            // подъемное устройство
            if (LiftingDevice)
            {
                g.DrawRectangle(pen, _startPosX + 162, _startPosY - 10, 3, 30);
                g.DrawLine(pen, _startPosX + 164, _startPosY - 10, _startPosX + 53, _startPosY - 45);
                g.DrawRectangle(pen, _startPosX + 72, _startPosY - 13, 8, 5);
                g.DrawRectangle(pen, _startPosX + 53, _startPosY - 44, 8, 5);
                g.DrawLine(pen, _startPosX + 128, _startPosY + 30, _startPosX + 53, _startPosY - 45);
                g.DrawLine(pen, _startPosX + 105, _startPosY + 30, _startPosX + 55, _startPosY - 45);
                g.FillRectangle(dopBrush, _startPosX + 163, _startPosY - 9, 2, 29);
                g.FillRectangle(dopBrush, _startPosX + 72, _startPosY - 13, 8, 5);
                g.FillRectangle(dopBrush, _startPosX + 53, _startPosY - 44, 8, 5);
                g.DrawLine(pen, _startPosX + 140, _startPosY + 30, _startPosX + 140, _startPosY + 20);
                g.DrawLine(pen, _startPosX + 153, _startPosY + 30, _startPosX + 153, _startPosY + 20);
                g.DrawRectangle(pen, _startPosX + 38, _startPosY - 45, 18, 3);
                g.DrawLine(pen, _startPosX + 126, _startPosY + 30, _startPosX + 72, _startPosY - 15);
                g.DrawLine(pen, _startPosX + 80, _startPosY + 60, _startPosX + 72, _startPosY - 15);
                g.DrawLine(pen, _startPosX + 80, _startPosY + 60, _startPosX + 45, _startPosY - 13);
                g.DrawLine(pen, _startPosX + 45, _startPosY - 13, _startPosX + 53, _startPosY - 45);
                g.DrawLine(pen, _startPosX + 38, _startPosY - 45, _startPosX + 38, _startPosY + 10);
                g.DrawLine(pen, _startPosX + 72, _startPosY - 15, _startPosX + 53, _startPosY - 45);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{CounterWeight}{separator}{LiftingDevice}";
        }
    }
}
