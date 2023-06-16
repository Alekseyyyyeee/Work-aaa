using System;


namespace Control
{
    class program
    {
        static void Main()
        {
            string[] Massive;
            string[] Massive2;
            int count;
            string message;
            int n;
            Console.WriteLine("Укажите сторки с каким количеством символов необходимо вывести на экран.");
            int.TryParse(Console.ReadLine(), out n );
            Console.WriteLine("Введите строки; оставьте строку пустой для завершения ввода. ");
            count = 0;
            Massive = new string[count];
            
            do
            {
                message = Console.ReadLine();
                if (message != "")
                {
                    count++;
                    Massive2 = new string[count];
                    for (int i = 0; i < Massive2.Length - 1; i++)
                        Massive2[i] = Massive[i];
                    Massive2[count - 1] = message;
                    Massive = Massive2;
                }
            }
            while (message != "");

            
            
            
            for (int i = 0; i < Massive.Length; i++)
            {
                if (Massive.Length <= n)
                    Console.WriteLine(Massive[i]);
            }
            
        }
    }

}



