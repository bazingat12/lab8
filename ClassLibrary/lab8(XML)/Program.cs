using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.IO;
using System.Xml.Serialization;

namespace lab8_XML_
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Book = new Book(1, "Пушкин", "Руслан и Людмила", "Поэма");
            Exemplar exemplar = new Exemplar(1, Book, DateTime.Now, "Exmo");
            Position position = new Position(1, "Библиотекарь");
            Reader reader = new ReaderPro("вип", 1, "Семенов", "Игорь", "Евгеньевич", "муж.", 79835);
            Employee employee = new Employee(1, position, "Петрова", "Людмила", "Сергеевна", 345678892, 4, "Киров", "Попова", "6");
            Delivery delivery = new Delivery(1, new DateTime(2018, 05, 04), employee, reader, exemplar);


            Reader reader2 = new ReaderSimple("обычный", 1, "Крючкова", "Антонина", "Александровна", "жен.", 79835);
            Book Book1 = new Book(1, "Лермонтов", "Мцыри", "Поэма");
            Exemplar exemplar1 = new Exemplar(1, Book, DateTime.Now, "Exmo");
            Position position1 = new Position(1, "Библиотекарь");
            Delivery delivery1 = new Delivery(2, new DateTime(2018, 05, 10), employee, reader2, exemplar1);

            DateTime start = new DateTime(2018, 05, 6);
            DateTime end = new DateTime(2019, 12, 31);

            List<Delivery> ListDelivery = new List<Delivery>();
            ListDelivery.Add(delivery);
            ListDelivery.Add(delivery1);

            List<Reader> ListReader = new List<Reader>();
            ListReader.Add(reader);
            ListReader.Add(reader2);

            List<Type> TypeList = new List<Type>();
            foreach (Reader t in ListReader)
            {
                try
                {
                    TypeList.Add(t.GetType());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка {0}", ex.Message);
                }
            }

            XmlSerializer formatter = new XmlSerializer(ListReader.GetType(), TypeList.ToArray());
            using (FileStream fs = new FileStream("reader.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ListReader);
                Console.WriteLine("Сериализация XML прошла успешно");
            }
            using (FileStream fs = new FileStream("reader.xml", FileMode.OpenOrCreate))
            {
                List<Reader> ListDeserTovar = formatter.Deserialize(fs) as List<Reader>;
                foreach (Reader tv in ListDeserTovar)
                {
                    tv.Info();
                   // Console.WriteLine("Товар: {0} ; Цена: {1}", tv.ID, tv.Price);

                }
            }
            Console.ReadLine();
        }
    }
}
