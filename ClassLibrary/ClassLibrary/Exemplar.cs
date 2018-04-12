using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Exemplar
    {
        public int ID_Exemplar
        { get; set; }
        public Book Book1
        { get; set; }
        public DateTime Data
        { get; set; }
        public string Publisher
        { get; set; }
        public Exemplar(int ID_Exemplar, Book Book1, DateTime Data, string Publisher)
        {
            this.ID_Exemplar = ID_Exemplar;
            this.Book1 = Book1;
            this.Data = Data;
            this.Publisher = Publisher;
        }
        public virtual void Info()
        {
            Book1.Info();
            Console.WriteLine("Информация о экземпляре: ");
            Console.WriteLine("    Код экземпляра: {0}\n    Дата печати:    {1}\n    Издательство: {2}",
                ID_Exemplar, Data, Publisher);
        }
    }
}
