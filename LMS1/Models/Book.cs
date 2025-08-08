using LMS1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS1.Models
{
    class Book 
    {


        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public bool IsAvailable { get; set; }
        /*        public Book() { }*/
        // هون مش عارفة اذا لازم امرر ال دي تبع البوك لانه هناك اتوقع اي دي بيرسوم فمش منطق 
        public Book(int id, string title, string authorName) 
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
            IsAvailable = true;
        }

        public  void DisplayInfo()
        {
            Console.WriteLine($"books info are '\n' Id : {Id}  " +
                $"Title:{Title}" +
                $"AuthorName: {AuthorName} " +
                $"IsAvailable : {IsAvailable}");



        }
    }
}
