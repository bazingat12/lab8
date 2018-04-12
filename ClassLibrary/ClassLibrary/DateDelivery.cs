using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DateDelivery : Delivery
    {
        public DateTime StartOfDelivery
        { get; set; }
        public DateTime EndOfDelivery
        { get; set; }
        public DateDelivery(int ID_Delivery, DateTime Data, Employee EmployeeDelivery, Reader Reader1, Exemplar Exemplar1, DateTime StartofDelivery, DateTime EndofDelivery) :
            base(ID_Delivery, Data, EmployeeDelivery, Reader1, Exemplar1)
        {
            this.StartOfDelivery = StartOfDelivery;
            this.EndOfDelivery = EndOfDelivery;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Дата выдачи: {0}", StartOfDelivery);
            Console.WriteLine("Дата возврата: {0}", EndOfDelivery);
        }
    }
}
