Console.WriteLine("Введите значение: ");
string firstNumber = Console.ReadLine();
int FirstNumber = Int32.Parse(firstNumber);
if(FirstNumber%2 == 0) {
    Console.WriteLine("Ваше значение чётное");
}
else {
    Console.WriteLine("Ваше значение нечётное");
}