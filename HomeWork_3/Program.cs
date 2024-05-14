using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HomeWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------ Задача 1 - Квадрат из символа -------------------------
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Задача 1 - Квадрат из символа");
            Console.ForegroundColor= ConsoleColor.White;
            Console.Write("\nВведите символ -> ");
            char sym = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите размер квадрата -> ");
            string size_text = Console.ReadLine();
            int size = Exception(size_text);           
            Draw(sym, size);

            // ------------------------------ Задача 2 - Палиндром -------------------------            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nЗадача 2 - Палиндром");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nВведите число -> ");
            string num_text = Console.ReadLine();
            int num = Exception(num_text);
            if (Check(num))
                Console.WriteLine("\nВведённое число является палиндромом");
            else
                Console.WriteLine("\nВведённое число не является палиндромом");

            // ---------------------------- Задача 3 - Фильтрация массива ----------------------
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nЗадача 3 - Фильтрация массива");
            Console.ForegroundColor = ConsoleColor.White;            
            int[] arr = new int[10]; // Исходный массив
            int[] arr_filtr = new int[5]; // Данные для фильтрации
            Random r = new Random();
            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < arr.Length; ++i) // Цикл заполнения и вывода в консоль массива arr            
            {
                arr[i] = r.Next(-7, 7);
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine("\n\nДанные для фильтрации:");
            for (int i = 0; i < arr_filtr.Length; ++i) // Цикл заполнения и вывода в консоль массива arr_filtr
            { 
                arr_filtr[i] = r.Next(-7, 7);
                Console.Write(arr_filtr[i] + "  ");
            }
            arr = Filtr(arr, arr_filtr);
            Console.WriteLine("\n\nМассив после фильтрации:");
            foreach (int i in arr) // Цикл вывода в консоль отфильтрованного массива arr
                Console.Write(i  + "  ");
            Console.WriteLine();

            // ---------------------------- Задача 4 - Веб-сайт ----------------------
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nЗадача 4 - Веб-сайт");
            Console.ForegroundColor = ConsoleColor.White;
            VebSite site = new VebSite(); // Создаём объект класса veb-site
            // Ввод данных в объект класса 
            Console.Write("\nВведите название сайта -> ");
            site.name_ = Console.ReadLine();
            Console.Write("Введите путь к сайту -> ");
            site.path_ = Console.ReadLine();
            Console.Write("Введите описание сайта -> ");
            site.description_ = Console.ReadLine();
            Console.Write("Введите ip-адрес сайта -> ");
            site.ip_ = Console.ReadLine();
            // Вывод данных из объекта класса
            Console.Write("\nВаш сайт:\n\nНазвание: ");
            Console.WriteLine(site.name_);
            Console.Write("Путь к сайту: ");
            Console.WriteLine(site.path_);
            Console.Write("Описание: ");
            Console.WriteLine(site.description_);
            Console.Write("Ip-адресс: ");
            Console.WriteLine(site.ip_);
            // Доступ к полям через методы класса
            Console.Write("\nУкажите номер пункта, доступ к которому Вы хотите получить, либо нажмите любую другую клавишу, " +
                "если всё Вас устраивает:\n1. Название сайта\n2. Путь к сайту\n3. Описание\n4. Ip-адресс\nВаш выбор -> ");
            char my_choice = Convert.ToChar(Console.ReadLine()); // Переменная для хранения выбора пользователя
            string tmp_str; // Переменная для считывания полей класса
            switch (my_choice)
            {
                case '1':
                    tmp_str = site.name_;
                    Console.WriteLine("\nПоле \"Имя\" записано в переменную tmp_str = " + site.name_);
                    break;
                case '2':
                    tmp_str = site.path_;
                    Console.WriteLine("\nПоле \"Путь к сайту\" записано в переменную tmp_str = " + site.path_);
                    break;
                case '3':
                    tmp_str = site.description_;
                    Console.WriteLine("\nПоле \"Описание\" записано в переменную tmp_str = " + site.description_);
                    break;
                case '4':
                    tmp_str = site.ip_;
                    Console.WriteLine("\nПоле \"Ip-адрес\" записано в переменную tmp_str = " + site.ip_);
                    break;                
            }

            // ---------------------------- Задача 5 - Журнал ----------------------
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nЗадача 5 - Журнал");
            Console.ForegroundColor = ConsoleColor.White;
            Magazine magazine = new Magazine(); // Создаём объект класса Magazine
            // Ввод данных в объект класса 
            Console.Write("\nВведите название журнала -> ");
            magazine.name_ = Console.ReadLine();
            Console.Write("Введите год основания -> ");
            string m_text = Console.ReadLine();
            magazine.year_ = Exception(m_text);
            Console.Write("Введите описание журнала -> ");
            magazine.description_ = Console.ReadLine();
            Console.Write("Введите контактный телефон -> ");
            m_text = Console.ReadLine();
            magazine.phone_ = Exception(m_text);
            Console.Write("Введите e-mail -> ");
            magazine.mail_ = Console.ReadLine();
            // Вывод данных из объекта класса
            Console.Write("\nВаш журнал:\n\nНазвание: ");
            Console.WriteLine(magazine.name_);
            Console.Write("Год основания: ");
            Console.WriteLine(magazine.year_);
            Console.Write("Описание: ");
            Console.WriteLine(magazine.description_);
            Console.Write("Телефон: ");
            Console.WriteLine(magazine.phone_);
            Console.Write("e-mail: ");
            Console.WriteLine(magazine.mail_);
            // Доступ к полям через методы класса
            Console.Write("\nУкажите номер пункта, доступ к которому Вы хотите получить, либо нажмите любую другую клавишу, " +
                 "если всё Вас устраивает:\n1. Название журнала\n2. Год основания\n3. Описание\n4. Контактный телефон\n" +
                 "5. e-mail\nВаш выбор -> ");
            char choice = Convert.ToChar(Console.ReadLine()); // Переменная для хранения выбора пользователя
            // Переменные для считывания полей класса
            string tmp_text;
            int tmp_int;            
            switch (choice)
            {
                 case '1':
                     tmp_text = magazine.name_;
                     Console.WriteLine("\nПоле \"Название\" записано в переменную tmp_text = " + magazine.name_);
                     break;
                 case '2':
                     tmp_int = magazine.year_;
                     Console.WriteLine("\nПоле \"Год основания\" записано в переменную tmp_int = " + magazine.year_);
                     break;
                 case '3':
                     tmp_text = magazine.description_;
                     Console.WriteLine("\nПоле \"Описание\" записано в переменную tmp_text = " + magazine.description_);
                     break;
                 case '4':
                     tmp_int = magazine.phone_;
                     Console.WriteLine("\nПоле \"Контактный телефон\" записано в переменную tmp_int = " + magazine.phone_);
                     break;
                 case '5':
                     tmp_text = magazine.mail_;
                     Console.WriteLine("\nПоле \"e-mail\" записано в переменную tmp_text = " + magazine.mail_);
                     break;
            }

            // ---------------------------- Задача 6 - Магазин ----------------------
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nЗадача 6 - Магазин");
            Console.ForegroundColor = ConsoleColor.White;
            Shop shop = new Shop(); // Создаём объект класса Shop
            // Ввод данных в объект класса 
            Console.Write("\nВведите название магазина -> ");
            shop.name_ = Console.ReadLine();
            Console.Write("Введите адрес магазина -> ");
            shop.adress_ = Console.ReadLine();
            Console.Write("Введите описание профиля магазина -> ");
            shop.description_ = Console.ReadLine();
            Console.Write("Введите контактный телефон -> ");
            string s_text = Console.ReadLine();
            shop.phone_ = Exception(s_text);
            Console.Write("Введите e-mail -> ");
            shop.mail_ = Console.ReadLine();
            // Вывод данных из объекта класса
            Console.Write("\nВаш магазин:\n\nНазвание: ");
            Console.WriteLine(shop.name_);
            Console.Write("Адресс: ");
            Console.WriteLine(shop.adress_);
            Console.Write("Описание профиля магазина: ");
            Console.WriteLine(shop.description_);
            Console.Write("Телефон: ");
            Console.WriteLine(shop.phone_);
            Console.Write("e-mail: ");
            Console.WriteLine(shop.mail_);
            // Доступ к полям через методы класса
            Console.Write("\nУкажите номер пункта, доступ к которому Вы хотите получить, либо нажмите любую другую клавишу, " +
                "если всё Вас устраивает:\n1. Название магазина\n2. Адрес\n3. Описание профиля магазина\n" +
                "4. Контактный телефон\n5. e-mail\nВаш выбор -> ");
            char ch = Convert.ToChar(Console.ReadLine()); // Переменная для хранения выбора пользователя
            // Переменные для считывания полей класса
            string tmp_t;            
            int tmp_i;
            switch (ch)
            {
                case '1':
                    tmp_t = shop.name_;
                    Console.WriteLine("\nПоле \"Название\" записано в переменную tmp_t = " + shop.name_);
                    break;
                case '2':
                    tmp_t = shop.adress_;
                    Console.WriteLine("\nПоле \"Адрес\" записано в переменную tmp_t = " + shop.adress_);
                    break;
                case '3':
                    tmp_t = shop.description_;
                    Console.WriteLine("\nПоле \"Описание\" записано в переменную tmp_t = " + shop.description_);
                    break;
                case '4':
                    tmp_i = shop.phone_;
                    Console.WriteLine("\nПоле \"Контактный телефон\" записано в переменную tmp_i = " + shop.phone_);
                    break;
                case '5':
                    tmp_t = shop.mail_;
                    Console.WriteLine("\nПоле \"e-mail\" записано в переменную tmp_t = " + shop.mail_);
                    break;
            }
        }
        static void Draw(char sym, int size) // Метод вывода квадрата в консоль (для задачи 1)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(sym + " ");
                Console.WriteLine();
            }
        }

        static int Exception(string message) // Метод обработки введённого пользователем значения (для задачь 1, 2, 5 и 6)
        {
            int number = 0;
            // Если введённое значение можно преобразовать в int, то записываем его в number
            if (int.TryParse(message, out number)) { }
            if (number < 1) // если введено не положительное целочисленное число, то 
            {
                while (!int.TryParse(message, out int value) || number < 1)
                {
                    Console.Write("Введённое некорректное значение! Введите целое число, больше нуля ещё один раз -> ");
                    message = Console.ReadLine();
                    if (int.TryParse(message, out number)) { }
                }
            }
            return number;
        }
        static bool Check(int num) // Метод проверки введённого числа на палиндром (для задачи 2)
        {
            bool result = true;
            string str = Convert.ToString(num);
            for (int i = 0; i < str.Length / 2; ++i)
                if (str[i] == str[str.Length - 1 - i])
                    continue;
                else
                {
                    result = false;
                    break;
                }
            return result;
        }
        static int[] Filtr(int[] arr, int[] filtr) // Метод фильтрации исходного массива (для задачи 3)
        {
            for (int i = 0; i < filtr.Length; ++i) // Цикл фильтрации элементов массива arr по значениям массива arr_filtr
            {
                int index = Array.IndexOf(arr, filtr[i]); // Индекс первого вхождения элемента arr = элементу filtr
                while (index != -1) // Пока в массиве arr есть элемент из массива arr_filtr
                {
                    int[] tmp = new int[arr.Length - 1]; // Временный массив для хранения эл. массива arr без эл. с индексом index
                    for (int j = 0; j < arr.Length; ++j) // Цикл формирования временного массива tmp
                    {
                        if (j < index)
                            tmp[j] = arr[j];
                        if (j == index)
                            continue;
                        if (j > index)
                            tmp[j - 1] = arr[j];
                    }
                    arr = tmp; // Перезаписываем исходный массив
                    index = Array.IndexOf(arr, filtr[i]); // Определяем индекс следующего вхождения эл. filtr[i] в arr
                }
            }
            return arr;
        }
    }
}