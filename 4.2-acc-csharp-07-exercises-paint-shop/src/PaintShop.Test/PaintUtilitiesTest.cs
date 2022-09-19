namespace PaintShop.Test;

public class PaintUtilitiesTest
{
    public static TheoryData<double, Wall, Room, int> ValidOverloadData =>
        new TheoryData<double, Wall, Room, int>
        {
            {
                1000,
                new Wall(100, 10),
                new Room(new Wall(100, 5), new Wall(100, 5)),
                5
            },
        };

    [Theory]
    [InlineData(20, 10, 200, 40, 20, 800)]
    public void TestPaintUtilitiesInitialValues(
        int bucketSize,
        int sqMtPerLiter,
        int sqMtPerBucket,
        int newBucketSize,
        int newSqMtPerLiter,
        int newSqMtPerBucket)
    {
        PaintUtilities.BucketSizeLiters.Should().Be(bucketSize);
        PaintUtilities.SquareMetersPerLiter.Should().Be(sqMtPerLiter);
        PaintUtilities.SquareMetersPerBucket.Should().Be(sqMtPerBucket);

        PaintUtilities.BucketSizeLiters = newBucketSize;
        PaintUtilities.SquareMetersPerLiter = newSqMtPerLiter;
        PaintUtilities.BucketSizeLiters.Should().Be(newBucketSize);
        PaintUtilities.SquareMetersPerLiter.Should().Be(newSqMtPerLiter);
        PaintUtilities.SquareMetersPerBucket.Should().Be(newSqMtPerBucket);

        PaintUtilities.BucketSizeLiters = bucketSize;
        PaintUtilities.SquareMetersPerLiter = sqMtPerLiter;
    }

    [Theory]
    [MemberData(nameof(ValidOverloadData))]
    public void TestGetNeededPaintBucketsCalculation(double area, Wall wall, Room room, int expectedBuckets)
    {
        PaintUtilities.BucketSizeLiters = 20;
        PaintUtilities.SquareMetersPerLiter = 10;
        PaintUtilities.GetNeededPaintBuckets(area).Should().Be(expectedBuckets);
        PaintUtilities.GetNeededPaintBuckets(wall).Should().Be(expectedBuckets);
        PaintUtilities.GetNeededPaintBuckets(room).Should().Be(expectedBuckets);
    }

    [Theory]
    [MemberData(nameof(ValidOverloadData))]
    public void TestCalculateCostCalculation(double area, Wall wall, Room room, int expectedBuckets)
    {
        decimal paintBucketPrice = 20.00M;
        double expected = Convert.ToDouble(paintBucketPrice * expectedBuckets);
        PaintUtilities.CalculateCost(paintBucketPrice, area).Should().Be(expected);
        PaintUtilities.CalculateCost(paintBucketPrice, wall).Should().Be(expected);
        PaintUtilities.CalculateCost(paintBucketPrice, room).Should().Be(expected);
    }
}