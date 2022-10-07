// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
/*
Console.Write("Enter a five digit number: ");
String X = Console.ReadLine()!;

if (X.Length == 5){
    if ((X[0] == X[4]) && (X[1] == X[3])){
        Console.Write("Entered number is a palindrome");
    } else{
        Console.Write("Entered number isn't a palindrome");
    }
} else{
    Console.Write("Not a five digit number entered! Please, try again!");
}
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine("Enter the coordinates of point A ");
Console.Write("Ax coordinate: ");
double Ax = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Ay coordinate: ");
double Ay = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Az coordinate: ");
double Az = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Enter the coordinates of point B ");
Console.Write("Bx coordinate: ");
double Bx = Convert.ToDouble(Console.ReadLine()!);
Console.Write("By coordinate: ");
double By = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Bz coordinate: ");
double Bz = Convert.ToDouble(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(Bx-Ax, 2) + 
                            Math.Pow(Bx-Ax, 2) + 
                            Math.Pow(Bx-Ax, 2));
Console.WriteLine($"The distance between points = {result}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Write("Enter a number N: ");
int N = int.Parse(Console.ReadLine()!);
if (N >= 1){
    for (int i = 1; i <= N; i++){
        double res = Math.Pow(i, 3);
        Console.Write(res+ " ");
    }
} else {
    Console.Write("Enter an invalid number N");
}
*/