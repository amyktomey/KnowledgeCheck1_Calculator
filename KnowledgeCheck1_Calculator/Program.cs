using KnowledgeCheck1_Calculator;
using System;
using static KnowledgeCheck1_Calculator.Numbers;

namespace KnowledgeCheck1_Calculato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    GetNumbers();

                    if (int.TryParse(Numbers.INumber1, out int addNum1) && int.TryParse(INumber2, out int addNum2))
                    {
                        Console.Write($"{INumber1} + {INumber2} = ");
                        Console.Write(Calculator.Add(addNum1, addNum2));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an integer");
                    }
                    break;

                case "2":
                    // call method
                    GetNumbers();

                    if (int.TryParse(INumber1, out int subNumOne) && int.TryParse(INumber2, out int subNumTwo))
                    {
                        Console.Write($"{INumber1} - {INumber2} = ");
                        Console.Write(Calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an integer");
                    }
                    break;

                case "3":
                    // call method
                    GetNumbers();

                    if (int.TryParse(INumber1, out int mutiplyNumOne) && int.TryParse(INumber2, out int multipyNumTwo))
                    {
                        Console.Write($"{INumber1} + {INumber2} = ");
                        Console.Write(Calculator.Multiply(mutiplyNumOne, multipyNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an integer");
                    }
                    break;

                case "4":
                    // call method
                    GetNumbers();

                    if (double.TryParse(INumber1, out double divNumOne) && double.TryParse(INumber2, out double divNumTwo))
                    {
                        Console.Write($"{INumber1} / {INumber2} = ");
                        Console.Write(Calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an integer");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}
