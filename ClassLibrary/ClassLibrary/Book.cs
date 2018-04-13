using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ClassLibrary
{
    [Serializable]
    public class Book
    {
        public int ID_Book
        { get; set; }
        public string Author
        { get; set; }
        public string NameBook
        { get; set; }
        public string Genre
        { get; set; }
        public Book()
        { }

        public Book(int ID_Book, string Author, string NameBook, String Genre)
        {
            this.ID_Book = ID_Book;
            this.Author = Author;
            this.NameBook = NameBook;
            this.Genre = Genre;
        }

        public virtual void Info()
        {
            Console.WriteLine("Информация о книге: ");
            Console.WriteLine("    Код книги: {0}\n    Автор: {1}\n    Название книги: {2} \n    Жанр: {3}\n",
                ID_Book, Author, NameBook, Genre);
        }
    }
}
