using Xunit;
using SpaceAcademy;
using Xunit.Abstractions;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Pop_EmptyStack_ThrowsInvalidOperationException()
    {
        var stack = new CargoStack<string>();
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
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
        Assert.Equal("Trolls", itemPopped);
        Assert.Equal(2,stack.Count);

        var itemPoppedII = stack.Pop();

        Assert.Equal("Elfs", itemPoppedII);
        Assert.Equal(1, stack.Count);

        var itemPoppedIII = stack.Pop();

        Assert.Equal("Gnomes", itemPoppedIII);
        Assert.Equal(0, stack.Count);
        
    }
    [Fact]
    public void AddInt_PopStackAndWhatNot()
    {
        // Given
        var stack = new CargoStack<int>();
        stack.Push (7);
        // When
        var intPopped = stack.Pop();
        // Then
        Assert.Equal(7, intPopped);
        Assert.Equal(1, stack.Count);
    }
}
