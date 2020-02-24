using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР0_Проект
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Жерносек Иван Андреевич ПР01");
            monit();
        }


        static void monit()
        {
            int i;
            Monitor mon = null;
            do
            {
                Console.Write("Меню:\n1) Создать новый объект \n2) Установить атрибуты текущего обьекта \n3) Вывести информацию о мониторах  \n\nВаше решение: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("\n1) Cоздать с помощью пользовательского конструктора \n2) Создать по умолчанию \n\nВаше решение: ");
                            int F = Convert.ToInt32(Console.ReadLine());
                            string firm = new string(' ', 20), type = new string(' ', 20);
                            float diagonal;
                            if (F == 1)
                            {
                                Console.Write("Введите фирму монитора ");
                                firm = Console.ReadLine();
                                Console.Write("Введите тип монитора ");
                                type = Console.ReadLine();
                                Console.Write("Введите диагональ монитора ");
                                diagonal = Convert.ToSingle(Console.ReadLine());
                                mon = new Monitor(firm, type, diagonal);
                                Console.WriteLine("Обьект создан");
                            }
                            else if (F == 2)
                            {
                                mon = new Monitor();
                                Console.WriteLine("Обьект создан");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (mon != null)
                            {
                                string firm = new string(' ', 20), type = new string(' ', 20);
                                float diagonal;
                                Console.Write("Введите фирму монитора ");
                                firm = Console.ReadLine();
                                Console.Write("Введите тип монитора ");
                                type = Console.ReadLine();
                                Console.Write("Введите диагональ монитора ");
                                diagonal = Convert.ToSingle(Console.ReadLine());
                                mon.Firm = firm;
                                mon.Type = type;
                                mon.Diagonal = diagonal;
                                Console.WriteLine("Обьект успешно изменен");
                            }
                            else
                            {
                                Console.WriteLine("Вы забыли создать объект");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (mon != null)
                            {
                                mon.GetInfo();
                            }
                            else
                            {
                                Console.WriteLine("Вы забыли создать объект");
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Вы что-то другое нажали...");
                        break;
                }
                Console.Write("\n\nНажмите любую клавишу...");
                Console.ReadLine();
                Console.Clear();
            }
            while (i != 3);
        }
    }
}
