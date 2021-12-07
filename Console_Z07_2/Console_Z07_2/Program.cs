using System;
using System.Text;

namespace Console_Z07_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Подсчет прописных слов в строке.");
            bool repit = true;
            while (repit == true)
            {
                try
                {
                    Console.WriteLine("| Введите строку которую нужно прочитать.");
                    Console.Write("| : ");
                    StringBuilder str = new(Convert.ToString(Console.ReadLine()));
                    Console.WriteLine("|-------------------------------------------------");
                    if (str.Length == 0)
                        throw new Exception("Строка должна содержать хотябы 1 символ!");

                    int number = numberUpp(str.ToString());
                    Console.WriteLine("| Строка состоит из {0} слов которые состоят\n| только изпрописных букв.", number);
                    rep(out repit);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"| {e.Message}");
                    rep(out repit);
                }
            }
        }
        static int numberUpp(string str)
        {
            int lowercase = 0;
            int uppercase = 0;
            int i = 0;
            int n = 0;
            while (i < str.Length)
            {
                uppercase = 0;
                lowercase = 0;
                while (i < str.Length && char.IsLetter(str[i]))
                {
                    if (char.IsUpper(str[i])) uppercase++;
                    if (char.IsLower(str[i])) lowercase++;
                    i++;
                }
                if (uppercase > 0 && lowercase == 0) 
                    n++;
                while (i < str.Length && !char.IsLetter(str[i]))
                    i++;
            }
            return n;
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
