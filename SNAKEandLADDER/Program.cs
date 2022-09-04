namespace SNAKEandLADDER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SNAKE & LADDER!");
            Console.WriteLine("Choose option\n 1. Single player position");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    SinglePlayerPosition.position();
                    break;
                    default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}