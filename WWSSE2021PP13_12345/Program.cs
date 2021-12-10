/*
    Napisz program obliczający sumę n kolejnych liczb całkowitych zawartych pomiędzy 
    wartościami minimum i maksimum wprowadzonymi przez operatora.
*/

int value_min, value_max, sum = 0;

Console.Write("Wprowadź wartość minimum: ");
value_min = int.Parse(Console.ReadLine());

Console.Write("Wprowadź wartość maksimum: ");
value_max = int.Parse(Console.ReadLine());

for (int i = value_min; i <= value_max; i++)
{
    sum += i;
}
Console.WriteLine("Suma liczb wynosi: {0}.", sum);