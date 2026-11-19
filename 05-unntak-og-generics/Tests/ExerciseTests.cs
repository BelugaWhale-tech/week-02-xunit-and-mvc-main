using Xunit;
using SpaceAcademy;
using Xunit.Abstractions;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Pop_EmptyStack_ThrowsArgumentOutOfRangeException()
    {
        var stack = new CargoStack<string>();
        Assert.Throws<ArgumentOutOfRangeException>(() => stack.Pop());
        Assert.Equal(0, stack.Count);
    }
    // TODO: Test LIFO, telling, gjenbruk og en annen type.
    [Fact]
    public void AddItems_PopStack()
    {
        // Given
        var stack = new CargoStack<string>();
        stack.Push("Gnomes");
        stack.Push("Elfs");
        stack.Push("Trolls");
        // When
        var itemPopped = stack.Pop();
        // Then
        Assert.Equal(2,stack.Count);
        Assert.Equal("Trolls", itemPopped);
        //pop fjerner item fra stack, så count her er 2, test for å sjekke om pop faktisk fjerner fra stack? 
    }
}
