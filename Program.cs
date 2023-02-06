// Console.Clear();
// Console.WriteLine("Task 25");
// Console.WriteLine("------");

// Console.Write("Введите число A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine()), result = 1;
// for (int i = 0; i < numB; i++) result *= numA;

// Console.WriteLine($"{numA} в степени {numB} равно {result}");

// Console.ReadLine();

// /*--------------------------------------------*/

// Console.Clear();
// Console.WriteLine("Task 27");
// Console.WriteLine("------");

// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine()), sumNumbers = 0;
// while(num1>0){
//     sumNumbers += num1%10;
//     num1 /= 10;
// }
// Console.WriteLine($"Сумма чисел равна {sumNumbers}");

// Console.ReadLine();

// /*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task 29");
Console.WriteLine("------");

Console.Write("Введите число учеников (от 1 до 100): ");
int num2 = Convert.ToInt32(Console.ReadLine());
while(num2 < 1 || num2 > 100){
    Console.Write("Ошибка! Введите число учеников (от 1 до 100): ");
    num2 = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите рост Пети (от 100 до 200): ");
int height = Convert.ToInt32(Console.ReadLine());
while(height  < 100 || height  > 200){
    Console.Write("Ошибка! Введите рост Пети (от 100 до 200): ");
    height = Convert.ToInt32(Console.ReadLine());
}

int[] students = new int [num2];
for (int i = 0; i < students.Length; i++) 
    students[i] = new Random().Next(100,201);

int temp;
for (int i = 0; i < students.Length-1; i++){
    for (int j = i + 1; j < students.Length; j++){
        if (students[i]<students[j]){
            temp = students[i];
            students[i] = students[j];
            students[j] = temp;
        }
    }
}

Console.WriteLine(string.Join(", ", students));

int Find(int n, int [] arr){
    for (int i = 0; i < arr.Length; i++){
        if(n > arr[i]) return i+1;
    }
    return 1;
}

Console.WriteLine($"Место в шеренге: {Find(height, students)}");

Console.ReadLine();

/*--------------------------------------------*/