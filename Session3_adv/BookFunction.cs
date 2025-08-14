using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3_adv
{
    internal class BookFunction
    {

        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return "    ";
        }

        public static string GetISBN(Book B)
        {
            return B.ISBN;
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString("C");
        }

        public static string GetPublicationDate(Book B)
        {
            return B.PublicationData.ToShortDateString();
        }
    }
}
