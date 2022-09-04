namespace SNAKEandLADDER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SNAKE & LADDER!");
            Console.WriteLine("Choose option\n 1. Single player position\t 2.Rolls the Die");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    SinglePlayerPosition.position();
                    break;
                    case 2:
                    RollTHEDies.RollDie();
                        break;
                    default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}