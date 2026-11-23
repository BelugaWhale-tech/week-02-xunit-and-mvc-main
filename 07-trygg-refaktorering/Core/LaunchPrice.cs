namespace SpaceAcademy;

public static class LaunchPrice
{
    public static int Calculate(int Passengers, bool priority)
    {
        int expectedPrice = 0;
        if (priority)
        {
            expectedPrice = Passengers * 100;
            expectedPrice = expectedPrice + Passengers * 20;
        }
        else
        {
            expectedPrice = Passengers * 100;
        }
        return expectedPrice;
    }
}
