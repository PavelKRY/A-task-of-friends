Console.WriteLine("Введите значение: ");
string inputa = Console.ReadLine();
int inputA = Int32.Parse(inputa);
int inputB = inputA - 1;
int repeat = inputB/2;
int n = 0;
int firstnumber = 2;
Console.WriteLine("Ваш числовой ряд до введённого вами значения: ");
while(n<=repeat)
    {
    int temp = firstnumber;
    Console.WriteLine(temp);
    firstnumber=firstnumber+2;
    n++; 
    }
