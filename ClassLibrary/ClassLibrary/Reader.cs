using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace ClassLibrary
{
    //[Serializable]
    [DataContract]
    public class Reader : Home
    {
        [DataMember]
        public int ID_Reader
        { get; set; }
        [DataMember]
        public string Surname
        { get; set; }
        [DataMember]
        public string Name
        { get; set; }
        [DataMember]
        public string Patronymic
        { get; set; }
        [DataMember]
        public string Gender
        { get; set; }
        [DataMember]
        public int Phone
        { get; set; }
        /*[DataMember]
        public Reader()
        { }*/
        public Reader(int ID_Reader, string Surname, string Name, string Patronymic, string Gender, int Phone, string City, string Street, string home1): base(City, Street, home1)
        {
            this.ID_Reader = ID_Reader;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Gender = Gender;
            this.Phone = Phone;
        }
        public virtual void Info()
        {
            Console.WriteLine("Информация о читателе: ");
            Console.WriteLine("    Код Читателя: {0}\n    Фамилия: {1}\n    Имя: {2} \n    Отчество: {3}\n    Пол: {4}\n    Телефон: {5}\n    Город: {6}\n    Улица: {7}\n    Дом: {8}\n",
                ID_Reader, Surname, Name, Patronymic, Gender, Phone, city, street, home);
        }
    }
}
