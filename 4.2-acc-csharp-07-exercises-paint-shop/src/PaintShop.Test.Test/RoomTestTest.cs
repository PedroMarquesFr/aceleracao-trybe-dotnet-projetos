namespace PaintShop.Test.Test;

public class RoomTestTest
{
    public static TheoryData<Wall, Wall, Wall, Wall> RoomData
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

    public static TheoryData<Wall, Wall, Wall, Wall> InvalidRoomData =>
        new TheoryData<Wall, Wall, Wall, Wall>
        {
            { new Wall(10, 10), new Wall(5, 5), new Wall(1, 1), new Wall(1, 1) },
        };

    private RoomTest _instance = new RoomTest();

    [Trait("Category", "1 - Criou testes para o TestRoomInstantiation")]
    [Theory(DisplayName = "TestRoomInstantiation deve ser executado com sucesso ao atribuir paredes")]
    [MemberData(nameof(RoomData))]
    public void TestSuccessTestRoomInstantiation(Wall wall1, Wall wall2, Wall expectedWall1, Wall expectedWall2)
    {
        // Arrange
        Action act = () => _instance.TestRoomInstantiation(wall1, wall2, expectedWall1, expectedWall2);

        // Assert
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "1 - Criou testes para o TestRoomInstantiation")]
    [Theory(DisplayName = "TestRoomInstantiation deve lançar esceção ao não atribuir paredes")]
    [MemberData(nameof(InvalidRoomData))]
    public void TestFailTestRoomInstantiation(Wall wall1, Wall wall2, Wall expectedWall1, Wall expectedWall2)
    {
        // Arrange
        Action act = () => _instance.TestRoomInstantiation(wall1, wall2, expectedWall1, expectedWall2);

        // Assert
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}


public class Test2 {
    private RoomTest _instance = new RoomTest();
     public static TheoryData<Wall, Wall, double> PaintableAreaData =>
        new TheoryData<Wall, Wall, double>
        {
            { new Wall(10, 10), new Wall(5, 5), 125 },
        };

    public static TheoryData<Wall, Wall, double> InvalidPaintableAreaData =>
        new TheoryData<Wall, Wall, double>
        {
            { new Wall(10, 10), new Wall(5, 5), 0 },
        };
    
    [Trait("Category", "2 - Criou testes para o TestTotalPaintableAreaCalculation")]
    [Theory(DisplayName = "TestTotalPaintableAreaCalculation deve ser executado com sucesso ao calcular área correta")]
    [MemberData(nameof(PaintableAreaData))]
    public void TestSuccessTestTotalPaintableAreaCalculation(Wall wall1, Wall wall2, double expectedPaintableArea)
    {
        // Arrange
        Action act = () => _instance.TestTotalPaintableAreaCalculation(wall1, wall2, expectedPaintableArea);

        // Assert
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Criou testes para o TestTotalPaintableAreaCalculation")]
    [Theory(DisplayName = "TestTotalPaintableAreaCalculation deve lançar exceção ao calcular área errada")]
    [MemberData(nameof(InvalidPaintableAreaData))]
    public void TestFailTestTotalPaintableAreaCalculation(Wall wall1, Wall wall2, double expectedPaintableArea)
    {
        // Arrange
        Action act = () => _instance.TestTotalPaintableAreaCalculation(wall1, wall2, expectedPaintableArea);

        // Assert
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}
