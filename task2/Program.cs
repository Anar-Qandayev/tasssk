using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month name: ");

            String month = Console.ReadLine();

           
            string text = "";
            switch (month){
                case "yanvar":
                    text = "31 gün";
                        break;
                case "fevral":
                    text = "28 or 29 gün";
                    break;
                case "mart":
                    text = "31 gün";
                    break;
                case "aprel":
                    text = "30 gün";
                    break;
                case "may":
                    text = "31 gün";
                    break;
                case "iyun":
                    text = "30 gün";
                    break;
                case "iyul":
                    text = "31 gün";
                    break;
                case "avqust":
                    text = "31 gün";
                    break;
                case "sentyabr":
                    text = "30 gün";
                    break;
                case "oktyabr":
                    text = "31 gün";
                    break;
                case "noyabr":
                    text = "30 gün";
                    break;
                case "dekabr":
                    text = "31 gün";
                    break;

                default:
                    text = "ay 1-12 aralığında olmalıdır!!!";
                    break;
            }
            Console.WriteLine(text);
         
        }

    }
}
