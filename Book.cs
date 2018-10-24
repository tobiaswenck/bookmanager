using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    class Book
    {
        public String title;
        public String author;
        public Int64 isbn;
        public Int16 seitenzahl;
        public String verlag;
        public Double preis;
        public Int16 erscheinungsjahr;
        public String genre;
        public String einband;
        public Boolean kaufempfehlung;

        public Book(String title, String author, Int64 isbn, Int16 seitenzahl, String verlag, Double preis, Int16 erscheinungsjahr, String genre, String einband, Boolean kaufempfehlung)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.seitenzahl = seitenzahl;
            this.verlag = verlag;
            this.preis = preis;
            this.erscheinungsjahr = erscheinungsjahr;
            this.genre = genre;
            this.einband = einband;
            this.kaufempfehlung = kaufempfehlung;
        }
    }
}
