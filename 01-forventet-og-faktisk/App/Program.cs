using SpaceAcademy;

int actualI = FuelCalculator.Calculate(3, 4);
int actualII =  FuelCalculator.Calculate(0, 4);
int actualIII =  FuelCalculator.Calculate(3, 0);
int actualIV =  FuelCalculator.Calculate(1, 1);
int actualV =  FuelCalculator.Calculate(20, 30);

Console.WriteLine($"Forventet: 24. Faktisk: {actualI}");
Console.WriteLine($"forventet: 0.  Faktisk: {actualII}");
Console.WriteLine($"forventet: 0.  Faktisk: {actualIII}");
Console.WriteLine($"forventet: 2.  Faktisk: {actualIV}");
Console.WriteLine($"forventet: 1200.  Faktisk: {actualV}");
