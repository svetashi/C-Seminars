//10 for 99 

int number = new Random().Next(10,100); //запомнить 
int a1 = number / 10;
int a2 = number % 10;

if (a1 > a2) 
{
   Console.WriteLine($"наибольшая цифра : {a1}"); 
}
if (a2 < a1)
{
   Console.WriteLine($"наименьшая цифра : {a2}"); 
}
if (a1 ==a2)
{
   Console.WriteLine("равны :"); 
}
Console.WriteLine(number);
Console.ReadKey(); 