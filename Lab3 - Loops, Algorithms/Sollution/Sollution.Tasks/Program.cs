using System.ComponentModel;

namespace Sollution.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        // 1) 100-ə qədər olan bütün ikirəqəmli tək ədədləri ekrana yazdırın. 
        //for (int i = 11; i < 100; i = i + 2)
        //{
        //    Console.WriteLine(i);
        //}

        // 2) Daxil edilən ədədin faktorialı 5-ə tam bölünürsə ekrana : "{daxil edilən ədədin faktorialı}/5={cavab}" yazısını yazdırın,bölünmürsə false yazılsın.
        //int number = Convert.ToInt32(Console.ReadLine());
        //int fact = 1;

        //for (int i = 1; i <= number; i++) 
        //{
        //    fact*= i;
        //}
        //if (fact%5==0)
        //    Console.WriteLine(fact+ " " + fact + "/5=" + fact / 5);
        //else
        //    Console.WriteLine("false");

        //3) Switch case vasitəsilə kalkuliyator yazın.
        //char _operator = Convert.ToChar(Console.ReadLine());   
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //int number2 = Convert.ToInt32(Console.ReadLine());
        //switch (_operator)
        //{
        //    case '+':
        //        Console.WriteLine(number1+ " + "+number2+ " = "+ (number1+number2));
        //        break;
        //    case '-':
        //        Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
        //        break;
        //    case '*':
        //        Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
        //        break;
        //    case '/':
        //        Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
        //        break;

        //    default:
        //        Console.WriteLine("İt is not possible value or operator");
        //        break;
        //}

        // 4) Daxil edilən ədədin hər hansı ədədin kvadratıdırsa true  və ədəd ekrana yazılsın.(16 daxil edilibsə: true, 4 yazılsın).
        //int value = Convert.ToInt32(Console.ReadLine());

        //for (int i = 1; i < value; i++) 
        //{
        //    if (value / i == i)
        //    {
        //        Console.WriteLine("true, " + i);
        //        break;
        //    }
        //}

        //5) User credentials yoxlayan proqram yazın.(Login məntiqi username və password əvvəlcədən təyin olunur).
        //string exampleUsername = "example@exampleDomain.com";
        //string examplePassword = "pb4012024";
        //string inputUsername;
        //string inputPassword;
        //do
        //{
        //    Console.WriteLine("Enter username:");
        //    inputUsername = Console.ReadLine();
        //    Console.WriteLine("Enter password:");
        //    inputPassword = Console.ReadLine();
        //    if (examplePassword!=inputPassword || exampleUsername!=inputUsername)
        //        Console.WriteLine("Login or password incorrect!");

        //    else Console.WriteLine("Login successful!");
        //} while (exampleUsername!=inputPassword && examplePassword!=inputPassword);

        // 6) İlk 11 fibonachi ədədlərini ekrana yazdırın.(0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...)
        //int prev1 = 1; int prev2 = 0;
        //Console.WriteLine(prev2 + "\n" + prev1);
        //for (int i = 0; i < 11; i++) 
        //{
        //    int num = prev1 + prev2;
        //    prev2 = prev1;
        //    prev1 = num;
        //    Console.WriteLine(num + " ");
        //}



    }
}
