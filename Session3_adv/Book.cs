using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3_adv
{
    public class Book
    {
        public string ISBN { get; set; }
        public String Title { get; set; }

        public string[] Authors { get; set; }
        public DateTime PublicationData { get; set; }
        public decimal Price { get; set; }

        public Book(string iSBN, String title, string[] authors, DateTime publicationData, decimal price)
        {
            this.ISBN = iSBN;
            this.Title = title;
            this.Authors = authors;
            this.PublicationData = publicationData;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"the ISBN :{ISBN} , the Title is :{Title},authors : xxxx  ,the DateTime is :{PublicationData.ToShortDateString()}, the price is : {Price}";
        }
    }
}
