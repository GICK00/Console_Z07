using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Console_Z07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Удаление подстраки.");
            bool repit = true;
            while (repit == true)
            {
                try
                {
                    Console.WriteLine("| Введите строку которую нужно изменить.");
                    Console.Write("| : ");
                    StringBuilder str = new(Convert.ToString(Console.ReadLine()));
                    Console.WriteLine("|-------------------------------------------------");
                    if (str.Length == 0)
                        throw new Exception("Строка должна содержать хотябы 1 символ!");

                    Console.WriteLine("| Исходная строка");
                    Console.WriteLine("| " + str);
                    Console.WriteLine($"| Длина строки: {str.Length}");
                    Console.WriteLine($"| Емкость строки: {str.Capacity}");
                    Console.WriteLine("|-------------------------------------------------");

                    Console.WriteLine("| Введите подстроку.");
                    Console.Write("| : ");
                    string substr = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("|-------------------------------------------------");

                    removStr(str, substr);
                    rep(out repit);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"| {e.Message}");
                    rep(out repit);
                }
            }
        }
        static void removStr(StringBuilder str, string substr)
        {
            try
            {
                Regex reg = new(substr);
                do
                {
                    int n = str.ToString().IndexOf(substr);
                    str = str.Remove(n, substr.Length);
                } while (reg.IsMatch(str.ToString()) == true);

                Console.WriteLine("| Изменёная строка.");
                Console.WriteLine("| " + str);
                Console.WriteLine($"| Длина строки: {str.Length}");
                Console.WriteLine($"| Емкость строки: {str.Capacity}");
                Console.WriteLine("|-------------------------------------------------");
            }
            catch (Exception)
            {
                Console.WriteLine("| Нет подстраки для удаления!");
            }
        }
        static void rep(out bool repit)
        {
            Console.WriteLine("| Попробовать снова? Да / Нет");
            Console.Write("| : ");
            string repitTxT = Convert.ToString(Console.ReadLine());

            if (repitTxT == "Да")
            {
                repit = true;
                Console.WriteLine("|-------------------------------------------------");
            }
            else if (repitTxT == "Нет")
                repit = false;
            else
            {
                Console.WriteLine("|-------------------------------------------------");
                Console.WriteLine("| Некорректный ввод данных!");
                repit = false;
            }
        }
    }
}