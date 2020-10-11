using System;

namespace switchStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int switchOneInput = 0;

            //Console.Write("Enter a number between 1 and 3: ");
            //int switchOneInput = Convert.ToInt32(Console.ReadLine());

            //string switchOneOutput;

            //switch (switchOneInput)
            //{
            //    case 1:
            //        switchOneOutput = "One";
            //        Console.WriteLine(switchOneOutput);
            //        break;
            //    case 2:
            //        switchOneOutput = "Two";
            //        Console.WriteLine(switchOneOutput);
            //        break;
            //    case 3:
            //        switchOneOutput = "Three";
            //        Console.WriteLine(switchOneOutput);
            //        break;
            //    default:
            //        switchOneOutput = "Unknown Input";
            //        Console.WriteLine(switchOneOutput);
            //        break;
            //}

            //int switchTwoInput = 0;

            //Console.Write("Enter a number betweein 1 and 3: ");

            //switchTwoInput = Convert.ToInt32(Console.ReadLine());

            //switch (switchTwoInput)
            //{
            //    case 1:
            //        Console.WriteLine("One");
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        Console.WriteLine("Two");
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //    default:
            //        Console.WriteLine("Other");
            //        break;
            //}

            //Console.Write("Enter a number between 1 and 3: ");
            //int switchThreeInput = Convert.ToInt32(Console.ReadLine());

            //switch (switchThreeInput)
            //{
            //    case 1:
            //        Console.WriteLine("One");
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //        // No default section.
            //}

            //Console.Write("Enter a number between 1 and 3: ");

            //int switchFourInput = Convert.ToInt32(Console.ReadLine());

            //switch (switchFourInput)
            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine("One or Two");
            //        //case 2:
            //        //Console.WriteLine("Two);
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //    default:
            //        Console.WriteLine("Other");
            //        break;
            //}

            //State stateCheck = State.Active;

            //switch (stateCheck)
            //{
            //    case State.Active:
            //        Console.WriteLine(State.Active);
            //        break;
            //    case State.Inactive:
            //        Console.WriteLine(State.Inactive);
            //        break;
            //    default:
            //        throw new Exception(String.Format("Unknown state: {0}", stateCheck));
            //        //break;
            //}

            Console.WriteLine("Enter 'Start' or 'Stop'");

            string stringInput = Console.ReadLine();

            switch (stringInput)
            {
                case "Start":
                    Console.WriteLine("Starting service ...");
                    break;
                case "Stop":
                    Console.WriteLine("Stopping service ...");
                    break;
                default:
                    Console.WriteLine(String.Format("Unknown command: {0}", stringInput));
                    break;
            }
        }

        enum State
        {
            Active = 1,
            Inactive = 2
        }
    }
}
