var n = int.Parse(Console.ReadLine());
double c =0;


for (int i = 1; i < n; i++)
{
    c += 1.0 / i;
}
Console.WriteLine(c);