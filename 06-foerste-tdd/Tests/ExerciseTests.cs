using Xunit;
using SpaceAcademy;
using System.Reflection.Metadata;
using System.Buffers;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Constructor_PreservesDataAndStartsIncomplete()
    {
        var task = new MissionTask(7, "Sjekk antenne");
        Assert.Equal(7, task.Id);
        Assert.Equal("Sjekk antenne", task.Title);
        Assert.False(task.IsCompleted);
    }
    // TODO: Skriv fullføringstesten før du implementerer Complete.
    [Fact]
    public void IsCompleted_IsTrue()
    {
        // Given
        var taskII = new MissionTask(11, "Clean out ooze from vent");
        // When
        Assert.Equal(11, taskII.Id); 
        taskII.Complete();
        // Then
        Assert.True(taskII.IsCompleted);
    
    } 

    [Fact]
    public void MissionTask_IsCreated_IsIncomplete()
    {
        // Given
        var taskIII = new MissionTask(01, "Brew coffe");
        // When
        Assert.Equal(01, taskIII.Id);
        Assert.Equal("Brew coffe", taskIII.Title);
        // Then
        Assert.False(taskIII.IsCompleted);
    }

    [Fact]
    public void MissionTask_RepetedCompletings()
    {
        // Given
        var TaskIV = new MissionTask(02, "Clean floor");
        // When
        TaskIV.Complete();
        TaskIV.Complete();
        TaskIV.Complete();
        TaskIV.Complete();
        // Then
        Assert.Equal(02, TaskIV.Id);
        Assert.Equal("Clean floor", TaskIV.Title);
        Assert.True(TaskIV.IsCompleted);
    }
}
