using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            double var1, var2;
            int tryCounter = 0;
            Console.WriteLine("\nPlease, enter first number:");
            do
            {
                
                if(Double.TryParse(Console.ReadLine(), out var1))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {
                    
                    if(tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return ;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }
                
            } while (true);
            Console.WriteLine("\nPlease, enter second number:");
            do
            {

                if (Double.TryParse(Console.ReadLine(), out var2))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);

            Console.WriteLine("Result : {0} + {1} = {2}", var1, var2, (var1 + var2));

        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            double var1, var2, result;
            int tryCounter = 0;
            Console.WriteLine("\nPlease, enter first number:");
            do
            {

                if (Double.TryParse(Console.ReadLine(), out var1))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);
            Console.WriteLine("\nPlease, enter second number:");
            do
            {

                if (Double.TryParse(Console.ReadLine(), out var2))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);
            Console.WriteLine("\nPlease, enter result:");
            do
            {

                if (Double.TryParse(Console.ReadLine(), out result))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);

            if (result == (var1 + var2)) Console.WriteLine("Correct!");
            else Console.WriteLine("Wrong!");
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            double var1, var2, result;
            int tryCounter = 0;
            Console.WriteLine("\nPlease, enter first number:");
            do
            {

                if (Double.TryParse(Console.ReadLine(), out var1))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);
            Console.WriteLine("\nPlease, enter second number:");
            do
            {

                if (Double.TryParse(Console.ReadLine(), out var2))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);
            Console.WriteLine("\nPlease, enter result:");
            do
            {

                if (Double.TryParse(Console.ReadLine(), out result))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);

            if (result == (var1 + var2)) Console.WriteLine("Correct!");
            else
            {
                
                Console.WriteLine("Wrong!");
                string message = (result < (var1 + var2)) ? ("Should be greater.") : ("Should be less.");
                Console.WriteLine(message);
            }
        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            double var1, var2, result, userResult;
            string oper = " ";
            int tryCounter = 0;

            Console.WriteLine("\nPlease enter first number: ");
            do
            {

                if (Double.TryParse(Console.ReadLine(), out var1))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);

            Console.WriteLine("\nPlease enter second number: ");
            do
            {

                if (Double.TryParse(Console.ReadLine(), out var2))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);

            Console.WriteLine("\nPlease enter operator number: ");
            do
            {
                oper = Console.ReadLine();
                if (String.Compare(oper, "+") == 0 || String.Compare(oper, "-") == 0)
                {
                    tryCounter = 0;
                    
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);
            Console.WriteLine("\nPlease, enter result:");
            do
            {

                if (Double.TryParse(Console.ReadLine(), out userResult))
                {
                    tryCounter = 0;
                    break;
                }
                else
                {

                    if (tryCounter > 2)
                    {
                        Console.WriteLine("Something wrong...");
                        return;
                    }
                    tryCounter++;
                    Console.WriteLine("Please, enter correct number..");
                }

            } while (true);

            if(String.Compare(oper, "+") == 0)
            {
                result = var1 + var2;
            }else if(String.Compare(oper, "-") == 0)
            {
                result = var1 - var2;
            }
            else
            {
                Console.WriteLine("Something wrong...");
                return;
            }

            if(userResult < result)
            {
                Console.WriteLine("Wrong! ");
                Console.WriteLine("Should be greater!");
            }else if(userResult > result)
            {
                Console.WriteLine("Wrong! ");
                Console.WriteLine("Should be less!");
            }
            else { Console.WriteLine("Correct!"); }


        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            decimal var1, var2, result, userResult;
            string oper = String.Empty;
            int triesCounter = 3;
            do
            {
                var1 = GetValue("First");
                var2 = GetValue("Second");
              
                oper = GetOperator();

                userResult = GetValue("User result");



                if (String.Compare(oper, "+") == 0)
                {
                    result = var1 + var2;
                }
                else if (String.Compare(oper, "-") == 0)
                {
                    result = var1 - var2;
                }
                else
                {
                    Console.WriteLine("Something wrong!...");
                    return;
                }
                if (result < userResult)
                {
                    Console.WriteLine("Wrong! Should be less!...");
                }
                else if (result > userResult)
                {
                    Console.WriteLine("Wrong! Should be greater!...");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    return;
                }
                triesCounter--;
                Console.WriteLine("Remaining number of tries: {0}", triesCounter);
            } while (triesCounter > 0);
            Console.WriteLine("Sorry... You have no tries anymore...");

        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            int numberOfTries = 3;
            do
            {
                decimal[] array = new decimal[5];
                decimal result = 0, userResult;

                for (int i = 0; i < array.Count(); i++)
                {
                    array[i] = GetValue((i+1).ToString());
                }
                string oper = GetOperator();
                userResult = GetValue("User result");
                
                if (String.Compare(oper, "+") == 0)
                {
                    foreach (decimal item in array)
                    {
                        result += item;
                    }
                }
                else if (String.Compare(oper, "-") == 0)
                {
                    foreach (decimal item in array)
                    {
                        result -= item;
                    }
                }
                else
                {
                    Console.WriteLine("Something wrong!...");
                    return;
                }

                if (result < userResult)
                {
                    Console.WriteLine("Wrong! Should be less!...");

                }
                else if (result > userResult)
                {
                    Console.WriteLine("Wrong! Should be greater!...");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    return;
                }
                numberOfTries--;
            } while (numberOfTries > 0);
            Console.WriteLine("Sorry... You have no tries anymore...");
        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            bool successFlag = false;

            int numberOfTries = 3;
            do
            {
                decimal[] array = new decimal[5];
                decimal result = 0, userResult;

                for (int i = 0; i < array.Count(); i++)
                {
                    array[i] = GetValue((i + 1).ToString());
                }
                string oper = GetOperator();
                userResult = GetValue("User result");

                if (String.Compare(oper, "+") == 0)
                {
                    foreach (decimal item in array)
                    {
                        result += item;
                    }
                }
                else if (String.Compare(oper, "-") == 0)
                {
                    foreach (decimal item in array)
                    {
                        result -= item;
                    }
                }
                else
                {
                    Console.WriteLine("Something wrong!...");
                    return;
                }

                if (result < userResult)
                {
                    Console.WriteLine("Wrong! Should be less!...");

                }
                else if (result > userResult)
                {
                    Console.WriteLine("Wrong! Should be greater!...");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    successFlag = true;
                    Console.WriteLine("Task was completed successfully!");
                    return;
                }
                numberOfTries--;
            } while (numberOfTries > 0);
            Console.WriteLine("Sorry... You have no tries anymore...");
            if (!successFlag)
            {
                Console.WriteLine("Task failed...");
            }
            
        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            Console.WriteLine("Please enter circle radius:\n");
            double radius = 0;
            if(Double.TryParse(Console.ReadLine(), out radius) & (radius > 0))
            {
                Console.WriteLine("Circle Area : {0}", (Math.PI * Math.Pow(radius, 2)));
            }
            else Console.WriteLine("Please enter correct value.");
        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            //Console.WriteLine("ВВедите сумму кредита:");
            int triesAmount = 0;
            decimal creditAmount = 0;
            do
            {
                Console.WriteLine("Введите сумму кредита:");
                if (Decimal.TryParse(Console.ReadLine(), out creditAmount) & creditAmount >= 0)
                {
                    break;
                }
                else
                {
                    if (triesAmount > 2)
                    {
                        Console.WriteLine("Error...");
                        return;
                    }
                    triesAmount++;
                    Console.WriteLine("Please try again...");
                }
            } while (true);
            int triesPercent = 0;
            decimal percent = 0;
            do
            {
                Console.WriteLine("Введите процент кредита:");
                
                if (Decimal.TryParse(Console.ReadLine(), out percent) & percent >= 0 & percent <= 100)
                {
                    break;
                }
                else
                {
                    if (triesPercent > 2)
                    {
                        Console.WriteLine("Error...");
                        return;
                    }
                    triesPercent++;
                    Console.WriteLine("Please try again...");
                }
            } while (true);
            Console.WriteLine("\nВыплаты по месяцам: \n");
            Console.WriteLine(@"Расчеты произведены по формулам с http://calculator-credit.ru/articles/credit-calc.html");

            CreditAnnuityPaymentCalc(creditAmount, percent);
            CreditDifferPaymentCalc(creditAmount, percent);
            


        }

        public static void PrintFuncList()
        {
            List<string> fList = new List<string>
            {
                "B3_P1_9_NumbersAddition",
                "B3_P2_9_CheckResultAddition",
                "B3_P3_9_CheckResultAdditionWithTips",
                "B3_P4_9_CheckResultWithOperator",
                "B3_P5_9_CheckResultWithAttemps",
                "B3_P6_9_FiveNumbersAddition",
                "B3_P7_9_NumbersResultWithInfoIfCorrect",
                "B3_P8_9_CircleArea",
                "B3_P9_9_CreaditCalculator"
            };
            Console.WriteLine("Available Functions List:\n");
            int i = 1;
            foreach (var item in fList)
            {
                Console.WriteLine(i.ToString() + " : " + item);
                i++;
            }

        }
        private static void CreditAnnuityPaymentCalc(decimal amount, decimal percent)
        {
            decimal eachMonthPay = 0m;
            decimal currentAmount = amount;
            decimal monthBet = Math.Round(((percent / 100) / 12), 8);
            decimal thisMonthPercent = 0;

            decimal totalDebt = 0;
            decimal totalPercent = 0;

            Console.WriteLine("\nАннуитетный платеж: ");
            for (int i = 1; i < 13; i++)
            {
                //double var1 = Math.Pow((1 + monthBet), 12) - 1;
                //double var2 = monthBet / var1;
                //double var3 = var2 + monthBet;
                //double var4 = currentAmount * var3;
                eachMonthPay = (Math.Round((currentAmount * (monthBet + monthBet / ((decimal)Math.Pow(((double)(1 + monthBet)), (13 - i)) - 1))), 6));

                thisMonthPercent = currentAmount * monthBet;
                Console.WriteLine("{0} месяц : \tвсего {1:0.00}, \tпроценты {2:00.00}, \t основной {3:0.00}, \tплатеж {4:0.00}", i, currentAmount,
                    thisMonthPercent, ((eachMonthPay) - thisMonthPercent), eachMonthPay);
                currentAmount -= (eachMonthPay) - thisMonthPercent;
                totalDebt += (eachMonthPay) - thisMonthPercent;
                totalPercent += thisMonthPercent;


            }
            Console.WriteLine("Итого сумма выплат: {0:0.00}, основной долг: {1:0.00}, проценты {2:0.00}\n", totalPercent + totalDebt, amount, totalPercent);

        }
        private static void CreditDifferPaymentCalc(decimal amount, decimal percent)
        {
            decimal monthDebt = amount / 12;
            decimal restMonthEnd = amount;
            decimal percentPerMonth = (percent / 100) / 12;

            decimal percantForAllTime = 0;
            decimal mainDebt = amount;
            decimal totalPayment = 0;

            Console.WriteLine("\nДифференцированный платеж: ");
            for (int i = 1; i < 13; i++)
            {
                decimal calculatedPercentDebt = restMonthEnd * percentPerMonth;
                decimal monthPayment = calculatedPercentDebt + monthDebt;

                Console.WriteLine("{0} месяц, \tостаток {1:000.00}, \tпроценты: {2:00.00}, \tосновной долг {3:00.00}, \tСумма платежа {4:0.00}", i, restMonthEnd, calculatedPercentDebt,
                    monthDebt, monthPayment);

                percantForAllTime += calculatedPercentDebt;

                restMonthEnd -= monthDebt;
            }

            Console.WriteLine("\nИтого: начислено процентов {0:0.00}, Основной долг {1:0.00}, Сумма платежа {2:0.00}.", percantForAllTime, mainDebt, (mainDebt + percantForAllTime));



        }
        private static decimal GetValue(string str)
        {
            decimal val = 0;
            int tries = 0;
            do
            {
                Console.WriteLine("Введите {0} Значение: ", str);

                if (Decimal.TryParse((Console.ReadLine()).Replace(',', '.'), out val))
                {
                    return val;
                }
                else
                {
                    if (tries > 2)
                    {
                        Console.WriteLine("Error...");
                        return 0;
                    }
                    tries++;
                    Console.WriteLine("Please try again...");
                }
            } while (true);
        }
        private static string GetOperator()
        {
            string val = String.Empty;
            int tries = 0;
            do
            {
                Console.WriteLine("Введите Оператор + или - : ");
                string input = Console.ReadLine();
                if (String.Compare(input, "+") == 0 || String.Compare(input, "-") == 0)
                {
                    val = input;
                    break;
                }
                else
                {
                    if (tries > 2)
                    {
                        Console.WriteLine("Error...");
                        break;
                    }
                    tries++;
                    Console.WriteLine("Please try again...");
                }
            } while (true);
            return val;
        }

    }
}
