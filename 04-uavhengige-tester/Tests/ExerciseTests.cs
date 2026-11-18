using Xunit;
using SpaceAcademy;
using System.ComponentModel;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Constructor_StartsEmpty()
    {
        var bay = new CargoBay();
        Assert.Equal(0, bay.Count);
    }
    // TODO: Flere tester. Opprett et nytt CargoBay i hver test.
    [Fact]
    public void Constructor_StartsEmpty_AddItem()
    {
        // Given
        var bay = new CargoBay();
        // When
        bay.TryAdd("Mat");
        // Then
        Assert.Equal(1, bay.Count);
    }
}
