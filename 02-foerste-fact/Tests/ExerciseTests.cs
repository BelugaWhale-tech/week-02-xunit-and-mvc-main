using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Calculate_ThreeCrewForFourDays_Returns24()
    {
        // Arrange
        int crewCount = 3;
        int days = 4;
        // Act
        int actual = FuelCalculator.Calculate(crewCount, days);
        // Assert
        Assert.Equal(24, actual);
    }
    // TODO: Skriv to selvstendige Fact-tester.
    [Fact]
    public void Calculate_ZeroCrewFourDays_ReturnsZero()
    {
        // Given
        int crewCount = 0;
        int days = 4;
        // When
        int actual = FuelCalculator.Calculate(crewCount, days);
        // Then
        Assert.Equal(0, actual);
    }
    [Fact]
    public void Calculate_OneCrewForOneDay_ReturnsTwo()
    {
        // Given
        int crewCount = 1;
        int days = 1;
        // When
        int actual = FuelCalculator.Calculate(crewCount, days);
        // Then
        Assert.Equal(2, actual);
    }
}
