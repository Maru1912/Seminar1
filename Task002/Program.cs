Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(  Console.ReadLine()  );

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(  Console.ReadLine()  );

int max = a;
int min = b;

if (a > b) max = a;
if (b > a) max = b;
if (a < b) min = a;
if (b < a) min = b;

{
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
