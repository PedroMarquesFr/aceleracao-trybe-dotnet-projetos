namespace Geometry;
public class Parallelepiped
{
    public double Width;
    public double Height;
    public double Depth;

    public double Volume { get { return Width * Height * Depth; } }
    public Rectangle FaceA { get { return new Rectangle(Width,Height); } }
    public Rectangle FaceB { get { return new Rectangle(Width, Depth); } }
    public Rectangle FaceC { get { return new Rectangle(Height, Depth); } }

    public double SurfaceArea { get { return 2 * FaceA.Area + 2 * FaceB.Area + 2 * FaceC.Area; } }

    public Parallelepiped(double width, double height, double depth)
    {
        if (width <= 0 || height <= 0 || depth <= 0) throw new ArgumentException("All sides must be greater than zero");
        Width = width;
        Height = height;
        Depth = depth;
    }
}
