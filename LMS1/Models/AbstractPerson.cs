using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS1.Models
{
    abstract class AbstractPerson
    {

        public int Id { get; set; }
        public string Name { get; set; }
        List<Book> BorrowedBooks = new List<Book>();
        public AbstractPerson(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void DisplayInfo();


        public void BorrowBook(Book book)
        {
           if(book.IsAvailable)
              {  BorrowedBooks.Add(book);
                book.IsAvailable = false;
            }
           else
                Console.WriteLine("book is not available");
            


        }
        public void ReturnBook(Book book)
        {
            bool test = false;
            foreach (Book b in BorrowedBooks)
            {
                if (b == book)
                {
                    test = true;
                    break;
                }

            }

            if (test == true)
                { BorrowedBooks.Remove(book); 
            book.IsAvailable=true;
            }
            else
                Console.WriteLine("book is not borowed");

        }

        public void DisplayBorrowedBooks()
        {

            foreach (Book b in BorrowedBooks)
            {
                Console.WriteLine($"borrowed book id :{b.Id}, name : {b.Title}, autherName: {b.AuthorName}");
            }
        }





    }
}
