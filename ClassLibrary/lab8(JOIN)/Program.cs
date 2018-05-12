using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace lab8_JOIN_
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


            List<IReader> ListReader = new List<IReader>();
            ListReader.Add(reader);
            ListReader.Add(reader2);


                  List<Type> TypeList = new List<Type>();
                  foreach (IReader t in ListReader)
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

                  DataContractJsonSerializer js = new DataContractJsonSerializer(ListReader.GetType(), TypeList.ToArray());
                  using (FileStream fs = new FileStream("reader.json", FileMode.OpenOrCreate))
                  {
                      js.WriteObject(fs, ListReader);
                      Console.WriteLine("Сериализация JSON прошла успешно");
                  }
                  using (FileStream fs = new FileStream("reader.json", FileMode.OpenOrCreate))
                  {
                      List<IReader> ListDeserTovar = js.ReadObject(fs) as List<IReader>;
                      foreach (IReader tv in ListDeserTovar)
                      {
                          tv.Info();
                      }
            }
            Console.ReadLine();
        }
    }
}
