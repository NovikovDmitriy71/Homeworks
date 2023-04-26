// Tast1    Принимает 2 числа выдает максимальное
// Console.WriteLine("Imput namber1 ");
// int nam1=Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Imput namber2 ");
//  int nam2=Convert.ToInt32(Console.ReadLine());
// if (nam1>nam2)
// {
//  Console.WriteLine($"a={nam1} , b={nam2}, max={nam1}");
// }
// else if (nam1<nam2)
// {
//  Console.WriteLine($"a={nam1} , b={nam2}, max={nam2}");
// }
// else
// {
//   Console.WriteLine($"a={nam1} , b={nam2}, числа равны");
// }

//task 2  Ввести 3 числа вывод максимального
// Console.WriteLine("Imput namber1 ");
// int nam1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Imput namber2 ");
// int nam2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Imput namber3 ");
// int nam3=Convert.ToInt32(Console.ReadLine());
// int max=nam1;
// if (nam2>max) max=nam2;
// if (nam3>max) max=nam3;
// Console.WriteLine($"{nam1},{nam2},{nam3}  - > {max}");

//Task 3  проверка вводимого числа на четность
// Console.WriteLine("Imput namber1 ");
// int nam=Convert.ToInt32(Console.ReadLine());
// if ((nam%2)==0)
// {
//  Console.WriteLine($"{nam} четное число");
// }
// else 
// {
//  Console.WriteLine($"{nam} нечетное число");
// }


 //Task 4 ввод число N-выход все четные числа
Console.WriteLine("input N");
int n=Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=n;i++)
if (i%2==0)
{
    Console.Write(i+ " ");
}