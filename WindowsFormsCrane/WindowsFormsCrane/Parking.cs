using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCrane
{
    public class Parking<T> where T : class, ITransport
    {

        private readonly T[] _places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int _placeSizeWidth = 170;
        private readonly int _placeSizeHeight = 155;

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        public static bool operator +(Parking<T> p, T parking)
        {
            int leffHelper = 26;
            int rightHelper = 65;
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    parking.SetPosition(p._placeSizeWidth * (int)(i / (int)(p.pictureHeight / p._placeSizeHeight)) - leffHelper, rightHelper + p._placeSizeHeight * (int)(i % (int)(p.pictureHeight / p._placeSizeHeight)), p.pictureWidth, p.pictureHeight);
                    p._places[i] = parking;
                    return true;
                }
            }
            return false;
        }
        public static T operator -(Parking<T> p, int index)
        {
            if ((index < p._places.Length) && (index >= 0))
            {
                T parking = p._places[index];
                p._places[index] = null;
                return parking;
            }
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth + 5, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2 + 70, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth + 5, 0, i * _placeSizeWidth + 5, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}