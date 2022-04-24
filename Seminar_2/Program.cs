/*int ShowNumber()
{
    int num = new Random().Next(10, 99);
    int firstnum = num/10;
    int secondnum = num%10;

    Console.Write(num + "-> ");

    if (firstnum > secondnum)
    {
       return firstnum;
    }
    else
    {
        return secondnum;
    }
}

int a = ShowNumber();
Console.WriteLine(a);

*/

void ReduceNumber()
{
    int num = new Random().Next(100, 999);
    int n1 = num / 10;
    int n2 = n1 % 10;
    Console.WriteLine(n2);
}
ReduceNumber();

/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

void Ifmultiple()
{
    if (num > 999)
    {
       int a = num/10;
       if (num > 100 && num < 999)
       {
           int a1 = num % 10;
        Console.WriteLine("third digit of the number: " + a1);
        if (num < 100)
        {
            Console.WriteLine("no third digit ");
        }
       }
    }
}

Ifmultiple();


//Console.Write("Enter the day of the week: ");
//int num = Convert.ToInt32(Console.ReadLine());
*/