namespace SpaceAcademy;

public static class LaunchPrice
{
    public static int Calculate(int Passengers, bool priority)
    {
        int expectedPrice = Passengers * 100;
        
        if (priority)
        {
            expectedPrice = expectedPrice + Passengers * 20;
        }
        
        return expectedPrice;
    }
}
