using System.Drawing;


namespace WindowsFormsCrane
{
    public class Crane
    {
        /// <summary>
        /// Левая координата отрисовки крана
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки крана
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки крана
        /// </summary>

        private readonly int carWidth = 100;
        /// <summary>
        /// Высота отрисовки крана
        /// </summary>
        private readonly int carHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес крана
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет крана
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        public Color DopColor2 { private set; get; }
        /// <summary>
        /// Признак наличия главной части крана
        /// </summary>
        public bool MainPartOfCrane { private set; get; }
        /// <summary>
        /// Признак наличия противовеса
        /// </summary>
        public bool Counterweight { private set; get; }
        /// <summary>
        /// Признак наличия гусениц
        /// </summary>
        public bool Сaterpillar { private set; get; }
        /// <summary>
        /// Признак наличия подъемного устройства
        /// </summary>
        public bool LiftingDevice { private set; get; }

        public Crane(int maxSpeed, float weight, Color mainColor, Color dopColor, Color dopColor2, bool mainPartOfCrane, bool counterweight, bool caterpillar, bool liftingDevice)
        {
            MaxSpeed = maxSpeed;

            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            DopColor2 = dopColor2;
            MainPartOfCrane = mainPartOfCrane;
            Counterweight = counterweight;
            Сaterpillar = caterpillar;
            LiftingDevice = liftingDevice;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// Изменение направления пермещения
        public void MoveTransport(Direction direction)
        {
            const int boarderTop = 43;
            const int boarderLeft = -40;
            const int boarderRight = 73;
            const int boarderDown = 20;
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth - boarderRight)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > boarderLeft)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > boarderTop )
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight - boarderDown)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка крана
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
             
                //рисую главную часть крана
                g.DrawRectangle(pen, _startPosX + 54, _startPosY + 20, 25, 40);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 30, 80, 30);
                Brush mainPart = new SolidBrush(DopColor);
                g.FillRectangle(mainPart, _startPosX + 55, _startPosY + 21, 24, 38);
                g.FillRectangle(mainPart, _startPosX + 80, _startPosY + 31, 80, 29);
                g.FillRectangle(mainPart, _startPosX + 141, _startPosY + 20, 12, 5);


            // Противовес
            if (Counterweight)
            {

                g.DrawRectangle(pen, _startPosX + 160, _startPosY + 20, 22, 44);
                g.DrawLine(pen, _startPosX + 140, _startPosY + 30, _startPosX + 140, _startPosY + 20);
                g.DrawLine(pen, _startPosX + 153, _startPosY + 30, _startPosX + 153, _startPosY + 20);
                g.DrawRectangle(pen, _startPosX + 140, _startPosY + 19, 13, 6);
                g.DrawRectangle(pen, _startPosX + 85, _startPosY + 60, 45, 5);
                g.DrawRectangle(pen, _startPosX + 60, _startPosY + 30, 10, 20);
                Brush counterweight = new SolidBrush(MainColor);
                g.FillRectangle(counterweight, _startPosX + 161, _startPosY + 21, 21, 43);
                g.FillRectangle(counterweight, _startPosX + 141, _startPosY + 20, 12, 5);
                g.FillRectangle(counterweight, _startPosX + 86, _startPosY + 61, 44, 4);
                Brush window = new SolidBrush(DopColor2);
                g.FillRectangle(window, _startPosX + 61, _startPosY + 31, 9, 19);
            }
            
            //гусеница
                g.DrawEllipse(pen, _startPosX + 61, _startPosY + 66, 90, 20);
                g.DrawEllipse(pen, _startPosX + 127, _startPosY + 68, 15, 15);
                g.DrawEllipse(pen, _startPosX + 66, _startPosY + 69, 62, 14);
                Brush caterpillar = new SolidBrush(MainColor);
                g.FillEllipse(caterpillar, _startPosX + 127, _startPosY + 68, 15, 15);
                g.FillEllipse(caterpillar, _startPosX + 66, _startPosY + 69, 63, 15);

           
            // подъемное устройство
            if (LiftingDevice)
            {
                g.DrawRectangle(pen, _startPosX + 162, _startPosY - 10, 3, 30);
                g.DrawLine(pen, _startPosX + 125, _startPosY + 30, _startPosX + 162, _startPosY - 10);
                g.DrawLine(pen, _startPosX + 126, _startPosY + 30, _startPosX + 72, _startPosY - 15);
                g.DrawLine(pen, _startPosX + 80, _startPosY + 60, _startPosX + 72, _startPosY - 15);
                g.DrawLine(pen, _startPosX + 80, _startPosY + 60, _startPosX + 45, _startPosY - 13);
                g.DrawLine(pen, _startPosX + 45, _startPosY - 13, _startPosX + 53, _startPosY - 45);
                g.DrawLine(pen, _startPosX + 72, _startPosY - 15, _startPosX + 53, _startPosY - 45);
                g.DrawLine(pen, _startPosX + 164, _startPosY - 10, _startPosX + 53, _startPosY - 45);
                g.DrawRectangle(pen, _startPosX + 38, _startPosY - 45, 18, 3);
                g.DrawLine(pen, _startPosX + 38, _startPosY - 45, _startPosX + 38, _startPosY + 10);
                g.DrawRectangle(pen, _startPosX + 72, _startPosY - 13, 8, 5);
                g.DrawRectangle(pen, _startPosX + 53, _startPosY - 44, 8, 5);
                g.DrawLine(pen, _startPosX + 128, _startPosY + 30, _startPosX + 53, _startPosY - 45);
                g.DrawLine(pen, _startPosX + 105, _startPosY + 30, _startPosX + 55, _startPosY - 45);
                Brush liftingDevice = new SolidBrush(MainColor);
                g.FillRectangle(liftingDevice, _startPosX + 163, _startPosY - 9, 2, 29);
                g.FillRectangle(liftingDevice, _startPosX + 72, _startPosY - 13, 8, 5);
                g.FillRectangle(liftingDevice, _startPosX + 53, _startPosY - 44, 8, 5);
            }

        }
    }
}