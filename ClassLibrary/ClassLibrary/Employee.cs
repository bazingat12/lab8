using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace ClassLibrary
{
    [Serializable]
    [KnownType(typeof(Employee))]
    [DataContract]

    public class Employee
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
        public Employee()
        { }

        public Employee(int ID_Employee, Position EmployeePosition, string Surname, string Name, string Patronymic, int INN, byte Experience, string City, string Street, string home1)
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
                + "{3}\n    ИНН: {4}\n    Стаж работы: {5}",
                ID_Employee, Surname, Name, Patronymic, INN, Experience);
            EmployeePosition.Info();
        }
    }

}
