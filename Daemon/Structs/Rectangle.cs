namespace Daemon
{
    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public bool ContainsPoint(Point p)
        {
            if (p.X < X || p.X > X+Width || p.Y < Y || p.Y > Y + Height)
            {
                return false;
            }
            return true;
        }
    }
}