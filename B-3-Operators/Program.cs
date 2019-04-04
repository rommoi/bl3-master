using System;

namespace B_3_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson.Examples();

            Console.WriteLine("Hello.");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Please select function and press enter:");

                Practice.PrintFuncList();

                int input = 0;
                int.TryParse(Console.ReadLine(), out input);
                

                switch (input)
                {
                    case 1:// "B3_P1_9_NumbersAddition":
                        Practice.B3_P1_9_NumbersAddition();
                        break;
                    case 2:// "B3_P2_9_CheckResultAddition":
                        Practice.B3_P2_9_CheckResultAddition();
                        break;
                    case 3:// "B3_P3_9_CheckResultAdditionWithTips":
                        Practice.B3_P3_9_CheckResultAdditionWithTips();
                        break;
                    case 4:// "B3_P4_9_CheckResultWithOperator":
                        Practice.B3_P4_9_CheckResultWithOperator();
                        break;
                    case 5:// "B3_P5_9_CheckResultWithAttemps":
                        Practice.B3_P5_9_CheckResultWithAttemps();
                        break;
                    case 6:// "B3_P6_9_FiveNumbersAddition":
                        Practice.B3_P6_9_FiveNumbersAddition();
                        break;
                    case 7:// "B3_P7_9_NumbersResultWithInfoIfCorrect":
                        Practice.B3_P7_9_NumbersResultWithInfoIfCorrect();
                        break;
                    case 8:// "B3_P8_9_CircleArea":
                        Practice.B3_P8_9_CircleArea();
                        break;
                    case 9:// "B3_P9_9_CreaditCalculator":
                        Practice.B3_P9_9_CreaditCalculator();
                        break;
                    default:
                        Console.WriteLine("\n No such function. \n");
                        break;
                }


                Console.WriteLine("\nWould you like to continue? Press Enter button. Enter \"quit\" to close application.");
            } while (String.Compare(Console.ReadLine(), "quit") != 0);

            //Practice.B3_P1_9_NumbersAddition();
            //Practice.B3_P2_9_CheckResultAddition();
            //Practice.B3_P3_9_CheckResultAdditionWithTips();
            //Practice.B3_P4_9_CheckResultWithOperator();
            //Practice.B3_P5_9_CheckResultWithAttemps();
            //Practice.B3_P6_9_FiveNumbersAddition();
            //Practice.B3_P7_9_NumbersResultWithInfoIfCorrect();
            //Practice.B3_P8_9_CircleArea();
            //Practice.B3_P9_9_CreaditCalculator();

            //Console.ReadLine();
        }
    }
}
