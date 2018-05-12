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
   public interface IReader
    {
        int ID_Reader
        { get; }
        string Surname
        { get; }
        string Name
        { get; }
        string Patronymic
        { get; }
        string Gender
        { get; }
        int Phone
        { get; }
        double st
        { get; }

        void Info();
    }
}
