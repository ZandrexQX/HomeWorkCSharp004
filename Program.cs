Console.Clear();
Console.WriteLine("Task 25");
Console.WriteLine("------");

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 0; i < numB; i++) result *= numA;

Console.WriteLine($"{numA} в степени {numB} равно {result}");

Console.ReadLine();

/*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task 27");
Console.WriteLine("------");

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine()), sumNumbers = 0;
while(num1>0){
    sumNumbers += num1%10;
    num1 /= 10;
}
Console.WriteLine($"Сумма чисел равна {sumNumbers}");

Console.ReadLine();

/*--------------------------------------------*/