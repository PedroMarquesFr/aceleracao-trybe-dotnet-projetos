namespace PaintShop.Test;

public static class PaintUtilities
{
    private static int _bucketSizeLiters = 20;
    private static int _squareMetersPerLiter = 10;
    public static int BucketSizeLiters
    {
        get
        {
            return _bucketSizeLiters;
        }
        set { _bucketSizeLiters = value; }
    }
    public static int SquareMetersPerLiter
    {
        get
        {
            return _squareMetersPerLiter;
        }
        set { _squareMetersPerLiter = value; }
    }
    public static int SquareMetersPerBucket
    {
        get
        {
            return BucketSizeLiters * SquareMetersPerLiter;
        }
    }
    public static int GetNeededPaintBuckets(double area)
    {
        return Convert.ToInt32(Math.Ceiling(area / SquareMetersPerBucket));
    }
    public static int GetNeededPaintBuckets(Wall wall)
    {
        return Convert.ToInt32(Math.Ceiling(wall.PaintableArea / SquareMetersPerBucket));
    }
    public static int GetNeededPaintBuckets(Room room)
    {
        return Convert.ToInt32(Math.Ceiling(room.TotalPaintableArea / SquareMetersPerBucket));
    }

    public static double CalculateCost(decimal paintBucketPrice, double area)
    {
        return Convert.ToDouble(GetNeededPaintBuckets(area) * paintBucketPrice);
    }
    public static double CalculateCost(decimal paintBucketPrice, Wall wall)
    {
        return Convert.ToDouble(GetNeededPaintBuckets(wall) * paintBucketPrice);
    }
    public static double CalculateCost(decimal paintBucketPrice, Room room)
    {
        return Convert.ToDouble(GetNeededPaintBuckets(room) * paintBucketPrice);
    }
}