using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Book = new Book(1, "Пушкин", "Руслан и Людмила", "Поэма");
            Exemplar exemplar = new Exemplar(1, Book, DateTime.Now, "Exmo");
            Position position = new Position(1, "Библиотекарь");
            IReader reader = new ReaderPro("вип", 1, "Семенов", "Игорь", "Евгеньевич", "муж.", 79835);
            Employee employee = new Employee(1, position, "Петрова", "Людмила", "Сергеевна", 345678892, 4, "Киров", "Попова", "6");
            Delivery delivery = new Delivery(1, new DateTime(2018, 05, 04), employee, reader, exemplar);


            IReader reader2 = new ReaderSimple("обычный", 1, "Крючкова", "Антонина", "Александровна", "жен.", 79835);
            Book Book1 = new Book(1, "Лермонтов", "Мцыри", "Поэма");
            Exemplar exemplar1 = new Exemplar(1, Book, DateTime.Now, "Exmo");
            Position position1 = new Position(1, "Библиотекарь");
            Delivery delivery1 = new Delivery(2, new DateTime(2018, 05, 10), employee, reader2, exemplar1);

            DateTime start = new DateTime(2018, 05, 6);
            DateTime end = new DateTime(2019, 12, 31);

            List<Delivery> ListDelivery = new List<Delivery>();
            ListDelivery.Add(delivery);
            ListDelivery.Add(delivery1);

            // массив для сериализации:
            Delivery[] DeliveryBook = new Delivery[] { delivery, delivery1 };

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("delivery.dat", FileMode.OpenOrCreate))
            {
                // сериализуем весь массив tovar
                formatter.Serialize(fs, DeliveryBook);

                Console.WriteLine("Сериализация в поток байтов прошла успешно");
            }

            // десериализация
            using (FileStream fs = new FileStream("delivery.dat", FileMode.OpenOrCreate))
            {
                Delivery[] deserilizeTovar = (Delivery[])formatter.Deserialize(fs);

                foreach (Delivery tv in deserilizeTovar)
                {
                    tv.Info();
                }

                Console.ReadLine();
            }
        }
    }
}

