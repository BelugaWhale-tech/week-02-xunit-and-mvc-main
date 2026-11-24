using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Add_TwoTasks_AssignsIdsAndStoresTitles()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        Assert.Equal(1, first.Id);
        Assert.Equal(2, second.Id);
        Assert.Equal("Sjekk antenne", first.Title);
        Assert.Equal("Lad rover", second.Title);
        Assert.Equal(2, board.Count);
        Assert.False(first.IsCompleted);
        Assert.False(second.IsCompleted);
    }

    [Fact]
    public void Complete_KnownId_CompletesOnlySelectedTask()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        bool result = board.Complete(second.Id);
        Assert.True(result);
        Assert.False(first.IsCompleted);
        Assert.True(second.IsCompleted);
        Assert.Equal(2, board.Count);
    }

    [Fact]
    public void Complete_UnknownId_DoesNotChangeTasks()
    {
        var board = new MissionBoard();
        var task = board.Add("Lad rover");
        Assert.False(board.Complete(99));
        Assert.False(task.IsCompleted);
        Assert.Equal(1, board.Count);
    }

    [Fact]
    public void GetAll_ReturnsCollectionCopy()
    {
        var board = new MissionBoard();
        board.Add("Lad rover");
        var copy = board.GetAll();
        copy.Clear();
        Assert.Equal(1, board.Count);
    }
    [Fact]
    public void NewBoard_IsEmpty()
    {
        var board = new MissionBoard();
    
        Assert.Equal(0, board.Count);
        
    }
    [Fact]
    public void SameMission_CompletesTwice()
    {
        var board = new MissionBoard();
        var task = board.Add("Dusting moondust");

        Assert.Equal(1,task.Id);    
        board.Complete(1);

        Assert.True(task.IsCompleted);

        Assert.True(task.IsCompleted);
    }
    [Fact]
    public void TwoBoards_SeperateChristmases()
    {
        // Given
        var boardI = new MissionBoard();
        var boardII = new MissionBoard();

        var taskI = boardI.Add("WindowCleaner");
    
        // Then
        Assert.Equal(1, boardI.Count);
        Assert.Equal(0, boardII.Count);

        var taskII = boardII.Add("Floor remover");

        Assert.Equal(1,taskII.Id);
    }
    [Fact]
    public void ListCopy_ContainsSameasOriginal()
    {
        // Given
        var boardI = new MissionBoard();
    
        // When
        var taskI = boardI.Add("Tire change");
        var copyBoardI = boardI.GetAll();

    
        // Then
        Assert.Same(taskI, copyBoardI[0]);
    }
}
