namespace PaintShop;
public class Wall
{
    double _width;
    double _height;

    public double Width
    {
        get { return _width; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Width must be greater than zero");
            _width = value;
        }
    }
    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Height must be greater than zero");
            _height = value;
        }
    }
    public double ExcludedArea { get; set; }
    public double PaintableArea
    {
        get { return (Width * Height) - ExcludedArea; }
    }

    public Wall(double width, double height)
    {
        Width = width;
        Height = height;
    }
}
