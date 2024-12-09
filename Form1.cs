namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
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


    }








}
