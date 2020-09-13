using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    class Crane
    {
        private float _startPosX; //левая координата отрисовки крана
        private float _startPosY; //правая координата отрисовки крана
        private int _pictureWidth; //ширина окна отрисовки
        private int _pictureHeight; //длинна окна отрисовки
        private const int carWidth = 100; // Ширина отрисовки самолета
        private const int carHeight = 60; // Длина отрисовки самолета
        public int MaxSpeed { private set; get;  } //максимальная скорость крана
        public float Weight { private set; get; } //вес крана
        public Color MainColor { private set; get; } //основной цвет самого крана
        public Color DopColor { private set; get; } //дополнительный цвет
        public bool CounterWeight { private set; get; } //признак наличия противовесного контейнера
        public bool LiftingDevice { private set; get; } //признак наличия подъемного устройства
        //Конструктор
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес крана</param>
        /// <param name="mainColor">Основной цвет крана</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="counterWeight">Признак наличия противовесного устрйства</param>
        /// <param name="liftingDevice">Признак наличия подъемного устройства</param>
        public Crane(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool counterWeight, bool liftingDevice)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            CounterWeight = counterWeight;
            LiftingDevice = liftingDevice;
        }
        /// Установка позиции крана
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth - 10)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0 + 50)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight + 50)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }






    }
}
