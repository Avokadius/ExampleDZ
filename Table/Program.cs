namespace Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое булево значение (true или false): ");
            bool valueOne = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Введите второе булево значение (true или false): ");
            bool valueTwo = Convert.ToBoolean(Console.ReadLine());

            bool andBitwise = valueOne & valueTwo;      
            bool orBitwise = valueOne | valueTwo;       
            bool xorBitwise = valueOne ^ valueTwo;      
            bool andLogical = valueOne && valueTwo;     
            bool orLogical = valueOne || valueTwo;      
            bool notValueOne = !valueOne;               
            bool notValueTwo = !valueTwo;               

            Console.WriteLine($"\nРезультаты логических операций:");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("&\t|\t^\t&&\t||\t!\t!");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"{valueOne & valueTwo}\t{valueOne | valueTwo}\t{valueOne ^ valueTwo}\t{valueOne && valueTwo}\t{valueOne || valueTwo}\t{!valueOne}\t{!valueTwo}");
            Console.WriteLine("--------------------------------------------------------");


        }
    }
}
