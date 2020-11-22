using System.Drawing;


namespace WindowsFormsCrane
{

    public class Crane : Vehicle
    {     
        /// <summary>
        /// Ширина отрисовки крана
        /// </summary>
        private readonly int carWidth = 100;
        /// <summary>
        /// Высота отрисовки крана
        /// </summary>
        private readonly int carHeight = 60;
        
        public Crane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        protected Crane(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.carWidth = carWidth;
            this.carHeight = carHeight;

        }

        /// Изменение направления пермещения
        public override void MoveTransport(Direction direction)
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
                    if (_startPosY - step > boarderTop)
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
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            //рисую главную часть крана
            g.DrawRectangle(pen, _startPosX + 54, _startPosY + 20, 25, 40);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 30, 80, 30);
            Brush mainPart = new SolidBrush(MainColor);
            g.FillRectangle(mainPart, _startPosX + 55, _startPosY + 21, 24, 38);
            g.FillRectangle(mainPart, _startPosX + 80, _startPosY + 31, 80, 29);
            g.FillRectangle(mainPart, _startPosX + 141, _startPosY + 20, 12, 5);

            //гусеница
            g.DrawEllipse(pen, _startPosX + 61, _startPosY + 66, 90, 20);
            g.DrawEllipse(pen, _startPosX + 127, _startPosY + 68, 15, 15);
            g.DrawEllipse(pen, _startPosX + 66, _startPosY + 69, 62, 14);
            Brush caterpillar = new SolidBrush(MainColor);
            g.FillEllipse(caterpillar, _startPosX + 127, _startPosY + 68, 15, 15);
            g.FillEllipse(caterpillar, _startPosX + 66, _startPosY + 69, 63, 15);
        }
    }
}