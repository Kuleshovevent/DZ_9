void Zadacha64()
{
    /* Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который
    выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    M = 1; N = 9. -> "3, 6, 9"
    M = 13; N = 20. -> "15, 18"*/

    Console.WriteLine("Введите число A");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    Console.WriteLine("Введите число B");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");

    Console.WriteLine("Числа которые делятся на 3 в данном диапозоне:");
    NaturalNumb(A,B);
}

void Zadacha66()
{
    /* Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который
    найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30 */
    Console.WriteLine("Введите первое число");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    Console.WriteLine("Введите второе число");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    Console.WriteLine("Сумма натуральных элементов:");
    Console.WriteLine(" ");
    Console.WriteLine(SumNatural(A,B));

}

void Zadacha68()
{
    /* Задача 68: Напишите программу вычисления функции Аккермана с помощью
    рекурсии. Даны два неотрицательных числа m и n.
    m = 3, n = 2 -> A(m,n) = 29 */
    
    Console.WriteLine("Введите первое число");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    Console.WriteLine("Введите второе число");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");

    if(m<0 & n<0)
    {
        Console.WriteLine("Функция не работает");
    }  
    else
    {
        Console.WriteLine($"Итог функции={FunctionAkk(m,n)}");
    }

}

void NaturalNumb(int number,int number2)
{
    if(number>number2)  return;
    if(number%3==0)
    {
        Console.Write($"{number} ");
    }
    number++;
    NaturalNumb(number,number2);

}

int SumNatural(int number,int number2, int sum=0)
{
    if(number>number2) return sum;

    sum=sum+number;
    number++;

    return SumNatural(number,number2,sum);
}

int FunctionAkk(int m, int n, int A=0)
{
    if(A>0) 
    {
        return(A);
    }
        if(m==0)
        {
            A=n+1;
        }
        else if(m>0 & n==0)
            {
                A=FunctionAkk(m-1,1);
            }
            else if(m>0 & n>0)
            {
                A=FunctionAkk(m-1,FunctionAkk(m,n-1));
            }
        return FunctionAkk(m,n,A);
}

//Zadacha64();
//Zadacha66();
Zadacha68();