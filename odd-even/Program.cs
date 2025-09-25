// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("please give me a number ill tell you if its odd or even");
int num = Convert.ToInt32(Console.ReadLine());
int check = num % 2;
if (check == 1)
{
    Console.WriteLine("odd");
}
else
{
    Console.WriteLine("even");
}