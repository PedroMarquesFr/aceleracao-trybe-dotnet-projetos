namespace PaintShop.Test.Test;

public class PaintUtilitiesTestTest
{
    private PaintUtilitiesTest _instance = new PaintUtilitiesTest();

    [Trait("Category", "3 - Criou testes para o TestSuccessTestPaintUtilitiesInitialValues")]
    [Theory(DisplayName = "TestSuccessTestPaintUtilitiesInitialValues deve ser executado com sucesso ao modificar os valores iniciais")]
    [InlineData(20, 10, 200, 40, 20, 800)]
    public void TestSuccessTestPaintUtilitiesInitialValues(
        int bucketSize,
        int sqMtPerLiter,
        int sqMtPerBucket,
        int newBucketSize,
        int newSqMtPerLiter,
        int newSqMtPerBucket)
    {
        PaintUtilities.BucketSizeLiters = 20;
        PaintUtilities.SquareMetersPerLiter = 10;
        // Arrange
        Action act = () => _instance.
            TestPaintUtilitiesInitialValues(
                bucketSize,
                sqMtPerLiter,
                sqMtPerBucket,
                newBucketSize,
                newSqMtPerLiter,
                newSqMtPerBucket);

        // Assert
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - Criou testes para o TestSuccessTestPaintUtilitiesInitialValues")]
    [Theory(DisplayName = "TestSuccessTestPaintUtilitiesInitialValues deve lançar exceção se não modificar propriedades corretamente")]
    [InlineData(20, 10, 200)]
    public void TestFailTestPaintUtilitiesInitialValues(int bucketSize, int sqMtPerLiter, int sqMtPerBucket)
    {
        // Arrange
        Action act = () => _instance.
            TestPaintUtilitiesInitialValues(
                bucketSize,
                sqMtPerLiter,
                sqMtPerBucket,
                bucketSize * 2,
                sqMtPerLiter * 2,
                sqMtPerBucket);

        // Assert
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}


public class Test4 {
    private PaintUtilitiesTest _instance = new PaintUtilitiesTest();
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
    
    [Trait("Category", "4 - Criou testes para o TestGetNeededPaintBucketsCalculation")]
    [Theory(DisplayName = "TestGetNeededPaintBucketsCalculation deve ser executado com sucesso ao calcular baldes da forma correta")]
    [MemberData(nameof(ValidOverloadData))]
    public void TestSuccessTestGetNeededPaintBucketsCalculation(double area, Wall wall, Room room, int expectedBuckets)
    {
        // Arrange
        Action act = () => _instance.
            TestGetNeededPaintBucketsCalculation(
                area,
                wall,
                room,
                expectedBuckets);

        // Assert
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "4 - Criou testes para o TestGetNeededPaintBucketsCalculation")]
    [Theory(DisplayName = "TestGetNeededPaintBucketsCalculation deve lançar exceção ao calcular baldes da forma incorreta")]
    [MemberData(nameof(ValidOverloadData))]
    public void TestFailTestGetNeededPaintBucketsCalculation(double area, Wall wall, Room room, int expectedBuckets)
    {
        // Arrange
        Action act = () => _instance.
            TestGetNeededPaintBucketsCalculation(
                area,
                wall,
                room,
                expectedBuckets + 1);

        // Assert
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }

}

public class Test5 {
    private PaintUtilitiesTest _instance = new PaintUtilitiesTest();
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
    [Trait("Category", "5 - Criou testes para o TestCalculateCostCalculation")]
    [Theory(DisplayName = "TestCalculateCostCalculation deve ser executado com sucesso ao calcular o custo da forma correta")]
    [MemberData(nameof(ValidOverloadData))]
    public void TestSuccessTestCalculateCostCalculation(double area, Wall wall, Room room, int expectedBuckets)
    {
        // Arrange
        Action act = () => _instance.
            TestCalculateCostCalculation(
                area,
                wall,
                room,
                expectedBuckets);

        // Assert
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "5 - Criou testes para o TestCalculateCostCalculation")]
    [Theory(DisplayName = "TestCalculateCostCalculation deve lançar exceção ao calcular o custo da forma incorreta")]
    [MemberData(nameof(ValidOverloadData))]
    public void TestFailTestCalculateCostCalculation(double area, Wall wall, Room room, int expectedBuckets)
    {
        // Arrange
        Action act = () => _instance.
            TestCalculateCostCalculation(
                area,
                wall,
                room,
                expectedBuckets + 1);

        // Assert
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}