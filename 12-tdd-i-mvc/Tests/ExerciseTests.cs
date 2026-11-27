using Xunit;
using SpaceAcademy;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

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
    public void GetPending_MixedBoard_ReturnsOnlyIncompleteTask()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        board.Complete(first.Id);
        var pending = board.GetPending();
        Assert.Single(pending);
        Assert.Same(second, pending[0]);
        Assert.Equal(2, board.Count);
    }
    [Fact]
    public void CreateNewMissionBoard_GetPendingReturnsNewList()
    {
        var board = new MissionBoard();
        var pending = board.GetPending();
        Assert.Empty(pending);
    }
    [Fact]
    public void CreatenewMissionBoard_AddTwoMissions_GetPendingReturnsListWithMissionsIncomplet()
    {
        var board = new MissionBoard();
        board.Add("Sjekk antenne");
        board.Add("Lade rover");
        var pending = board.GetPending();
        Assert.Equal(2, pending.Count); 
        
    }
    [Fact]
    public void AllMissionComplete_TableCount2()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lade rover");
        board.Complete(first.Id);
        board.Complete(second.Id);
        var pending = board.GetPending();
        Assert.Empty(pending);
        Assert.Equal(2, board.Count);
    }
    [Fact]
    public void AddMissions_TheyStayInTheirLane()
    {
        var board = new MissionBoard();
        var first = board.Add("1. Sjekk antenne");
        var second = board.Add("2. Lad rover");
        var third = board.Add("3. Kontroller drivstoff");
        board.Complete(second.Id);
        var pending = board.GetPending();
        Assert.Equal(3,board.Count);
        Assert.Equal(2, pending.Count);
        Assert.Same(first, pending[0]);
        Assert.Same(third, pending[1]);
    }
    [Fact]
    public void ResultListIsCopy_Clear_ClearOriginal_CopyRemains()
    {
        // Given
        var board = new MissionBoard();
        var first = board.Add("1. Sjekk antenne");
        var second = board.Add("2. Lad rover");
        // When
        var pending = board.GetPending();
        // Then
        Assert.Equal(2, pending.Count);
        Assert.Equal(2, board.Count);
        pending.Clear();
        Assert.Empty(pending);
        Assert.Equal(2, board.Count);
        var pendingI = board.GetPending();
        Assert.Equal(2, pendingI.Count);
    }   
}
