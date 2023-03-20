using System.Drawing;
using System.Windows.Forms;

public class SquareFactory : IShapeFactory
{
        public Shape CreateShape() => new Square();
}
public class LineFactory : IShapeFactory
{
    public Shape CreateShape() => new Line();
}
public class CircleFactory : IShapeFactory
{
    public Shape CreateShape() => new Circle();
}
public interface IShapeFactory
{
    Shape CreateShape();
}
public abstract class Shape
{
    public abstract void Draw(Graphics g, Point location);
}

public class Square : Shape
{
    public override void Draw(Graphics g, Point location)
    {
        g.DrawRectangle(Pens.Black, location.X, location.Y, 50, 50);
    }
}

public class Circle : Shape
{
    public override void Draw(Graphics g, Point location)
    {
        g.DrawEllipse(Pens.Black, location.X, location.Y, 50, 50);
    }
}
public class Line : Shape
{
    public override void Draw(Graphics g, Point location)
    {
        g.DrawLine(Pens.Black, location.X, location.Y, 50, 50);
    }
}

