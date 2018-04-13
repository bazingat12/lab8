﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassLibrary
{
    [Serializable]
    // Указывает, что класс может быть сериализован.  (Необходим для сериализации в Бинарный формат файла)
    public abstract class Home
    {

        public string city { get; set; }
        public string street { get; set; }
        public string home { get; set; }
        public Home()
        { }


        public Home(string City, string Street, string home1)
        {
            city = City;
            street = Street;
            home = home1;
        }

        public void Display()
        {
            Console.WriteLine(city + " " + street + " " + home);
        }

    }
}
