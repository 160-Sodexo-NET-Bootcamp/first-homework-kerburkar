using KerimeBurcuKaratas_Odev1_BirinciOdev.Entities;
using System.Collections.Generic;
using System.Linq;

namespace KerimeBurcuKaratas_Odev1_BirinciOdev.Data
{
    public static class DemoData
    {
        public static List<Book> GetAll()
        {
            return GetData();

        }
        public static Book GetById(int id)
        {
            return GetData().FirstOrDefault(x=> x.Id == id);

        }
        private static List<Book> GetData()
        {
            var books = new List<Book>();
            books.Add(new Book()
            {
                Id = 1,
                BookName = "Harry Potter",
                BookSeriallNumber = "9781408855652",
                BookGenre = "Fantasy",
                BookAuthor = "J.K. Rowling"
            });
            books.Add(new Book()
            {
                Id = 2,
                BookName = "Lord of The Rings",
                BookSeriallNumber = "9781408855650",
                BookGenre = "Fantasy",
                BookAuthor = "J.R.R. Tolkien"
            });
            books.Add(new Book()
            {
                Id = 3,
                BookName = "Dune",
                BookSeriallNumber = "9781408855689",
                BookGenre = "Science Fiction",
                BookAuthor = "Frank Herbert"
            });
            books.Add(new Book()
            {
                Id = 4,
                BookName = "I Robot",
                BookSeriallNumber = "9781408855678",
                BookGenre = "Science Fiction",
                BookAuthor = "Isaac Asimov"
            });
            books.Add(new Book()
            {
                Id = 5,
                BookName = "The Raven",
                BookSeriallNumber = "9781408855569",
                BookGenre = "Drama",
                BookAuthor = "Edgar Allan Poe"
            });
            books.Add(new Book()
            {
                Id = 6,
                BookName = "Yeni Hayat",
                BookSeriallNumber = "9781408855612",
                BookGenre = "Drama",
                BookAuthor = "Orhan Pamuk"
            });

            return books;
        }

    }

}

