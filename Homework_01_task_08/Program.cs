Console.WriteLine("Введите значение: ");
string inputa = Console.ReadLine();
int inputA = Int32.Parse(inputa);
Console.WriteLine("Ваш числовой ряд до введённого вами значения: ");
while (inputA > 1){
    if(inputA %2 == 0) {
        Console.WriteLine(inputA);
    }
    else{
        Console.WriteLine(inputA-1);
    }
    inputA=inputA-2;
}

