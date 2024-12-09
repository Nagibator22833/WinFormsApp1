using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Circle Circle;
        private Square Square;
        private Romb Romb;
        
        
        
        
        public Form1()
        {
            InitializeComponent();
        }
    }
 abstract class Figure
    {
        public int x;
        public int y;
        public abstract void DrawBkack(Graphics g);
        public abstract void HideDrawingBackGround(Graphics g);
        public void MoveRight()
        {
            for (int i = 0; i < 10; i++)
            {
                HideDrawingBackGround(null);
                x += 10;
                DrawBkack(null);
                System.Threading.Thread.Sleep(100);
            }

        }

    }
    class Circle : Figure
    {
       private int radius;
        public Circle(int x,int y,int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
       public override void DrawBkack(Graphics g)
        {
            g.FillEllipse(Brushes.Black, x - radius, y - radius, 2 * radius, 2 * radius);
        }
        public override void HideDrawingBackGround(Graphics g)
        {
            g.FillEllipse(Brushes.Black, x - radius, y - radius, 2 * radius, 2 * radius);
        }
        



    }
    class Square : Figure
    {
        private int sideLength;
        public Square(int x, int y, int sideLength)
        {
            this.x = x;
            this.y = y;
            this.sideLength = sideLength;

        }
        public override void DrawBkack(Graphics g)
        {
            g.FillRectangle(Brushes.Black, x - sideLength / 2, y - sideLength / 2, sideLength, sideLength);
        }
        public override void HideDrawingBackGround(Graphics g)
        {
            g.FillRectangle(Brushes.Black, x - sideLength / 2, y - sideLength / 2, sideLength, sideLength);
        }


    }
   class Romb : Figure
    {
        private int horDiaglen;
        private int vertDiaglen;
        public Romb(int x,int y,int horDiaglen,int vertDiaglen)
        {
            this.y=y;
            this.horDiaglen=horDiaglen;
            this.vertDiaglen=vertDiaglen;
            this.x=x;

             
        }
        public override void DrawBkack(Graphics g)
        {
            Point[] points =
            {
                new Point(x, y - vertDiaglen / 2),
                new Point(x +horDiaglen / 2, y),
                new Point(x, y + vertDiaglen / 2),
                new Point(x - horDiaglen / 2, y)
            };
            g.FillPolygon(Brushes.AliceBlue, points);
        }

        public override void HideDrawingBackGround(Graphics g)
        {
            Point[] points =
              {
                new Point(x, y - vertDiaglen / 2),
                new Point(x +horDiaglen / 2, y),
                new Point(x, y + vertDiaglen / 2),
                new Point(x - horDiaglen / 2, y)
            };
            g.FillPolygon(Brushes.AliceBlue, points);
        }
    }






}
