namespace PaintShop.Test;

public class RoomTest
{
    public static TheoryData<Wall, Wall, Wall, Wall> ValidRoomData
    {
        get
        {
            var wall1 = new Wall(10, 10);
            var wall2 = new Wall(5, 5);
            var wall1Copy = wall1;
            var wall2Copy = wall2;

            return new TheoryData<Wall, Wall, Wall, Wall>
            {
                { wall1, wall2, wall1Copy, wall2Copy },
            };
        }
    }

    public static TheoryData<Wall, Wall, double> ValidPaintableAreaData =>
        new TheoryData<Wall, Wall, double>
        {
            { new Wall(10, 10), new Wall(5, 5), 125 },
        };

    [Theory]
    [MemberData(nameof(ValidRoomData))]
    public void TestRoomInstantiation(Wall wall1, Wall wall2, Wall expectedWall1, Wall expectedWall2)
    {
        Room room = new(wall1, wall2);
        Wall[] array = { expectedWall1, expectedWall2 };
        room.Walls.Should().Equal(array);
    }

    [Theory]
    [MemberData(nameof(ValidPaintableAreaData))]
    public void TestTotalPaintableAreaCalculation(Wall wall1, Wall wall2, double expectedPaintableArea)
    {
        Room room = new(wall1, wall2);
        room.TotalPaintableArea.Should().Be(expectedPaintableArea);
    }
}