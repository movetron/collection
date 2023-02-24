using collection;


    Social Fun = new();


bool start = true;

begin:
do
{
    Console.WriteLine("Добавьте элемент в список или закончить добавление?(вводите значения пока не введёте 0");

    while (start)
    {
        string start_1 = Console.ReadLine();
        if (start_1 != "0")
        {

            Fun.Add(start_1);

        }
        else
        {
            start = false;
        }
    }

} while (start);


bool start_3 = true;

do
{
begin1: Console.WriteLine("Вывести все элементы - 1; Удалить элементы - 2; Добавить элементы - 3; Заменить элемент - 4; Добавит элемент в определенное поле - 5; Найти элемент с заданной длинной - 6; Вывести элемент по его id - 7");
    int start_33 = Convert.ToInt32(Console.ReadLine());
    switch (start_33)
    {
        case 1:
            Fun.GetAll(); Console.WriteLine("Продолжить операцию? 1 - Да; 0 - Нет");
            string Yes = Console.ReadLine();
            if (Yes == "0")
            {
                start_3 = false;
            }
            else
            {
                goto begin1;
            }
            break;
        case 2:
            Console.WriteLine("Имя какго элемента хотите удалить?");
            string Remove = Console.ReadLine();
            Fun.Remove(Remove); Console.WriteLine("Продолжить операцию? 1 - Да; 0 - Нет");
            string Yes_1 = Console.ReadLine();
            if (Yes_1 == "0")
            {
                start_3 = false;
            }
            else
            {
                goto begin1;
            }
            break;
        case 3:
            bool start_4 = true;
            do
            {
                Console.WriteLine("Добавьте элемент в список или закончить?(После ввода написать 0)");

                while (start_4)
                {
                    string start_1 = Console.ReadLine();
                    if (start_1 != "0")
                    {

                        Fun.Add(start_1);

                    }
                    else
                    {
                        start_4 = false;
                    }
                }

            } while (start_4);
            Console.WriteLine("Продолжить операцию? 1 - Да; 0 - Нет");
            string Yes_2 = Console.ReadLine();
            if (Yes_2 == "0")
            {
                start_3 = false;
            }
            else
            {
                goto begin1;
            }
            break;

        case 4:
            Console.WriteLine("Какой элемент вы хотите заменить? Введите номер элемента и имя нового элемента");
            int x_1 = Convert.ToInt32(Console.ReadLine());
            string y_1 = Console.ReadLine();
            Fun.Update(x_1, y_1); Console.WriteLine("Продолжить операцию? 1 - Да; 0 - Нет");
            string Yes_3 = Console.ReadLine();
            if (Yes_3 == "0")
            {
                start_3 = false;
            }
            else
            {
                goto begin1;
            }

            break;
        case 5:
            Console.WriteLine("Перед каким элементом вы хотите поставить новый элемент? Сначала введите номер элемента, перед которым встанет новый и имя нового элемента");
            int x_2 = Convert.ToInt32(Console.ReadLine());
            string y_2 = Console.ReadLine();
            Fun.Insert(x_2, y_2); Console.WriteLine("Продолжить операцию? 1 - Да; 0 - Нет");
            string Yes_4 = Console.ReadLine();
            if (Yes_4 == "0")
            {
                start_3 = false;
            }
            else
            {
                goto begin1;
            }
            break;
        case 6:
            Console.WriteLine("Элемент какой длинны вы хотите найти?");
            int find_elem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fun.Find1(find_elem, find_elem)); Console.WriteLine("Продолжить операцию? 1 - Да; 0 - Нет");
            string Yes_5 = Console.ReadLine();
            if (Yes_5 == "0")
            {
                start_3 = false;
            }
            else
            {
                goto begin1;
            }
            break;
        case 7:
            Console.WriteLine("Какой id вы хотите вывести?");
            int id_elem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fun.GetById(id_elem)); Console.WriteLine("Продолжить операцию? 1 - Да; 0 - Нет");
            string Yes_6 = Console.ReadLine();
            if (Yes_6 == "0")
            {
                start_3 = false;
            }
            else
            {
                goto begin1;
            }
            break;
    }
} while (start_3);
Console.WriteLine("Работа закончена");