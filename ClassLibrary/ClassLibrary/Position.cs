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
    public class Position
    {
        [DataMember]
        public int ID_Position
        { get; set; }
        [DataMember]
        public string PositionName
        { get; set; }

       /* public Position()
        { }*/
        public Position(int ID_Position, string PositionName)
        {
            this.ID_Position = ID_Position;
            this.PositionName = PositionName;
        }

        public virtual void Info()
        {
           // Console.WriteLine("Информация о должности: ");
            Console.WriteLine("    Должность: {0}\n ",
                PositionName);
        }
    }
}
