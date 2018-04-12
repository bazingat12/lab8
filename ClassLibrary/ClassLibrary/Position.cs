using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Position
    {
       public int ID_Position
        { get; set; }
        public string PositionName
        { get; set; }
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
