using Xunit;
using SpaceAcademy;

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
}
