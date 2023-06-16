Console.WriteLine("Insert five-digit number");
int num = Convert.ToInt32(Console.ReadLine());
int num1, num2 = 0;
int pal = num;
while (num > 0)
{
    num1 = num%10;
    num2 = (num2*10) + num1;
    num = num/10;
}
if (pal == num2 && pal>10000 && pal<=100000)
{
    Console.WriteLine("It is palindome");
}
else
{
    Console.WriteLine("Nope, try again");
}