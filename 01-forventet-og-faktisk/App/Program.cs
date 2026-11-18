using SpaceAcademy;

int actual = FuelCalculator.Calculate(3, 4);
int calcI =  FuelCalculator.Calculate(0, 4);
int calcII =  FuelCalculator.Calculate(3, 0);
int calcIII =  FuelCalculator.Calculate(1, 1);
int calcIV =  FuelCalculator.Calculate(20, 30);
Console.WriteLine($"Forventet: 24. Faktisk: {actual}");
Console.WriteLine($"forventet: 0.  Faktisk: {calcI}");
Console.WriteLine($"forventet: 0.  Faktisk: {calcII}");
Console.WriteLine($"forventet: 2.  Faktisk: {calcIII}");
Console.WriteLine($"forventet: 1200.  Faktisk: {calcIV}");
// TODO: Kjør de andre eksemplene og noter resultatene.
