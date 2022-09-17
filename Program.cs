decimal cap, tj, tmp, jur, mon;

Console.Write("\nCapital (R$): ");
cap =  Convert.ToDecimal(Console.ReadLine());
Console.Write("Taxa de juros (%): ");
tj = Convert.ToDecimal(Console.ReadLine());
Console.Write("Tempo (meses): ");
tmp = Convert.ToDecimal(Console.ReadLine());

jur = cap * (tj / 100) * tmp;

mon = cap + jur;

Console.WriteLine($"\nJuros R$): {jur}");
Console.WriteLine($"Total (R$): {mon}\n");
