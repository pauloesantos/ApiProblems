namespace ProblemsApi.Helpers
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Rectangle
    {
        public Point L { get; set; }
        public Point R { get; set; }
    }

    public class Rectangles
    {
        public Rectangle RectA { get; set; }
        public Rectangle RectB { get; set; }
    }
}