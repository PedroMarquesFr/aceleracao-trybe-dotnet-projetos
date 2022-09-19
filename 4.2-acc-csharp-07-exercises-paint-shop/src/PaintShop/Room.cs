namespace PaintShop;

public class Room
{
    public Wall[] Walls { get; }
    public double TotalPaintableArea { get; set; }
    public Room(params Wall[] walls)
    {
        Walls = walls;
        for (int i = 0; i < walls.Length; i++)
        {
            TotalPaintableArea += walls[i].PaintableArea;
        }
    }
}