namespace SpaceAcademy;

public static class LaunchPrice
{
    public static int Calculate(int Passengers, bool priority)
    {
        int expectedPrice = 0;
        expectedPrice = Passengers * 100;
        
        if (priority)
        {
            expectedPrice = expectedPrice + Passengers * 20;
        }
        
        return expectedPrice;
    }
} // to ting jeg kanskje ser her, int= expectedPrice og den siste utregningen ser ut til å være unødvendig?

