namespace SpaceAcademy;

public static class LaunchPrice
{
    public static int Calculate(int passengers, bool priority)
    {
        int expectedPrice = passengers * 100;
        
        if (priority)
        {
            expectedPrice = expectedPrice + passengers * 20;
        }
        
        return expectedPrice;
    }
}
