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
   // [Serializable]
    [DataContract]
    public class Employee : Home 
    {
        [DataMember]
        public int ID_Employee
        { get; set; }
        [DataMember]
        public Position EmployeePosition
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
        public int INN
        { get; set; }
        [DataMember]
        public byte Experience
        { get; set; }

       /* [DataMember]
        public Employee()
        { }*/


        public Employee (int ID_Employee, Position EmployeePosition, string Surname, string Name, string Patronymic, int INN, byte Experience, string City, string Street, string home1): base (City, Street, home1)
        {
            this.ID_Employee = ID_Employee;
            this.EmployeePosition = EmployeePosition;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.INN = INN;
            this.Experience = Experience;
        }
        public virtual void Info()
        {
            Console.WriteLine("Сотрудник: ");
            Console.WriteLine("    Код сотрудника: {0}\n    Фамилия: {1}\n    Имя: {2}\n    Отчество: "
                + "{3}\n    ИНН: {4}\n    Стаж работы: {5}\n    Город: {6}\n    Улица: {7}\n    Дом: {8}",
                ID_Employee, Surname, Name, Patronymic, INN, Experience, city, street, home);
               EmployeePosition.Info();
        }
    }
    
}
