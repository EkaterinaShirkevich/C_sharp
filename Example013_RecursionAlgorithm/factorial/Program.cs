// написать метод, кот. принимает число и возвращает его факториал

double Factorial(int n)
{
    if(n==1)
    return 1;
    else 
    return n*Factorial(n-1);
}
for(int i=1; i<40; i++) // смотрим факт-лы от 1 до 39 например
Console.WriteLine($"{i}!={Factorial(i)}");
