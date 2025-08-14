using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3_adv
{
    public delegate string BookDelegate(Book b);
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookDelegate fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }

        //public static void ProcessBooks(List<Book> bList, Func<Book, string> fptr)

        //{
        //    foreach (Book B in bList)
        //    {
        //        Console.WriteLine(fptr(B));
        //    }
        //}
    }
}
