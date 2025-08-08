using LMS1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS1.Models
{
    internal class Library{


        List<Book> books = new List<Book>();
        List<AbstractPerson> Members = new List<AbstractPerson>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void AddMember(AbstractPerson member)
        {
            Members.Add(member);
        }

        public Book FindBookById(int id)
        {
            Book test = null;
            foreach (Book b in books)
            {
                if (b.Id == id)
                    test = b;
            }
            return test;

        }

        public AbstractPerson FindMemberById(int id)

        {
            AbstractPerson test = null;
            foreach (var member in Members)
                if (member.Id == id)
                {
                    test = member;
                    break;
                }
 
            return test;
        }


        public void DisplayAllBooks()
        {
            foreach (Book b in books)
            {
                Console.WriteLine($"name is {b.Title}, ID is {b.Id}, AuthorName is {b.AuthorName} ");
            }
        }

        public void DisplayAllMembers()
        {
            foreach (AbstractPerson m in Members)
            {
                Console.WriteLine($"name is {m.Name}, ID is {m.Id}");
            }
        }







    }
}
