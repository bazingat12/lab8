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
    [KnownType(typeof(Exemplar))]
    [DataContract]

    public class Exemplar
    {
        [DataMember]
        public int ID_Exemplar
        { get; set; }
        [DataMember]
        public Book Book1
        { get; set; }
        [DataMember]
        public DateTime Data
        { get; set; }
        [DataMember]
        public string Publisher
        { get; set; }
        public Exemplar()
        { }
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
