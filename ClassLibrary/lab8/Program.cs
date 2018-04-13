using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLibrary;
using System.IO;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            Book Book = new Book(1, "Пушкин", "Руслан и Людмила", "Поэма");
            Exemplar exemplar = new Exemplar(1, Book, DateTime.Now, "Exmo");
            Position position = new Position(1, "Библиотекарь");
            Reader reader = new Reader(1, "Семенов", "Игорь", "Евгеньевич", "муж.", 79835, "Киров", "Лепсе", "43");
            Employee employee = new Employee(1, position, "Петрова", "Людмила", "Сергеевна", 345678892, 4, "Киров", "Попова", "6");
            Delivery delivery = new Delivery(1, DateTime.Now, employee, reader, exemplar);
            DateTime start = new DateTime(2018, 05, 6);
            DateTime end = new DateTime(2019, 12, 31);

            Console.WriteLine("Объект создан");

            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("delivery.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, delivery);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream("delivery.dat", FileMode.OpenOrCreate))
            {
                Delivery newDelivery = (Delivery)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("\n Код выдачи: {0}\n Дата выдачи: {1}\n", newDelivery.ID_Delivery, newDelivery.Data);
                newDelivery.Info();
            }

            Console.ReadLine();

          /*  List<DateDelivery> ListDelivery = new List<DateDelivery>();
            ListDelivery.Add(new DateDelivery(1, DateTime.Now, employee, reader, exemplar, start, end));
            foreach (DateDelivery date in ListDelivery)
            {
                date.Info();
                if (date is IbooksReader)
                {
                    (date as IbooksReader).Count("3");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

        }
    }
}
