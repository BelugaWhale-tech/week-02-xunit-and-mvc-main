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
    [Fact]
    public void Constructor_StartsEmpty_AddTwoItems()
    {
        // Given
        var bay = new CargoBay();
        // When
        bay.TryAdd("Mat");
        bay.TryAdd("Vann");
        // Then
        Assert.Equal(2, bay.Count);
    }
    [Fact]
    public void Constructor_StartsEmpty_AddThreeItems()
    {
        var bay = new CargoBay();
        bay.TryAdd("Mat");
        bay.TryAdd("vann");
        bay.TryAdd("luft?");

        Assert.Equal(3, bay.Count);

        //testen feiler da constructor bare tillater at beholderen skal kunne lagre 2 items? 
    }
    [Fact]
    public void Constructor_MakesTwo_OneGetsItem_SecondEmpty()
    {
        // Given
         var bayI = new CargoBay();
         var bayII= new CargoBay();
        // When
        bayI.TryAdd("Deftones");
        // Then
        Assert.Equal(1, bayI.Count);
        Assert.Equal(0, bayII.Count);
    }
}
