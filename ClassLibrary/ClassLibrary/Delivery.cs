using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;


namespace ClassLibrary
{
    // [Serializable]
    [DataContract]
    public class Delivery : IbooksReader
    {
        [DataMember]
        public int ID_Delivery
        { get; set; }
        [DataMember]
        public DateTime Data
        { get; set; }
        [DataMember]
        public Employee EmployeeDelivery
        { get; set; }
        [DataMember]
        public Reader Reader1
        { get; set; }
        [DataMember]
        public Exemplar Exemplar1
        { get; set; }

        /*// стандартный конструктор без параметров
        public Delivery()
        { }*/
        public Delivery(int ID_Delivery, DateTime Data, Employee EmployeeDelivery, Reader Reader1, Exemplar Exemplar1)
        {
            this.ID_Delivery = ID_Delivery;
            this.Data = Data;
            this.EmployeeDelivery = EmployeeDelivery;
            this.Reader1 = Reader1;
            this.Exemplar1 = Exemplar1;
        }

        public virtual void Info()
        {
           // Console.WriteLine("Код выдачи: {0} , Дата:\n", ID_Delivery, Data);
            EmployeeDelivery.Info();
            Reader1.Info();
            Exemplar1.Info();
        }

        void IbooksReader.Count(string count)
        {
            Console.WriteLine("Колличество книг на руках читателя: {0}", count);
        }
    }
}
