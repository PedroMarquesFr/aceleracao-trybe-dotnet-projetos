namespace Geometry;
public class Cube : Parallelepiped
{
    public double Side { get; set; }
    public new Square FaceA
    {
        get { return new Square(Side); }
    }
    public new Square FaceB
    {
        get { return new Square(Side); }
    }
    public new Square FaceC
    {
        get { return new Square(Side); }
    }
    public Cube(double side) : base(side, side, side) { Side = side; }
}