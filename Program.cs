

class Program
{
    public void summation(int number1, int number2)
    {
        Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
    }
    public void subtraction(int number1, int number2)
    {
        Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
    }
    public void divide(int number1, int number2)
    {
        Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
    }
    public void multiplication(int number1, int number2)
    {
        Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        int number1, number2;
        string process;
        while(true){
            Console.WriteLine("Please enter your first number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your process");
            process = Console.ReadLine();
            if (process == null)
            {
                Console.WriteLine("Process is null");
            }
            else if (process == "+")
            {
                program.summation(number1, number2);
            }
            else if (process == "-")
            {
                program.subtraction(number1, number2);
            }
            else if (process == "/")
            {
                program.divide(number1, number2);
            }
            else if (process == "*")
            {
                program.multiplication(number1, number2);
            }
        }
        
    }
   
}