using System.Security.Cryptography.X509Certificates;

namespace Session3_adv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region v1-5

            //int[] numbers = { 5, 2, 9, 4, 7, 0, 1, 10 };
            //BubbleSort.PrintArrays(numbers);
            //Console.WriteLine();

            ////SortDelegate X=ExpressionSort.GreaterThan;
            ////BubbleSort.sortnumbers(numbers,X);
            //BubbleSort.PrintArrays(numbers);
            //Console.WriteLine();
            //SortDelegate<int> X = ExpressionSort.LessThan;

            //BubbleSort.sortnumbers(numbers, X);
            //BubbleSort.PrintArrays(numbers);

            #endregion
            #region v5
            //PublicKey static list<int> findoddnumbers(List<int>list)
            //    if(List>.count>0)
            //    {for(int i=0;i<list.count;i++)
            //      {
            //        if(list[i]%2!=0)
            //          result.add(list[i]);

            //
            //
            //      return result
            //      }
            //    }




            //PublicKey static list<int> findevemnumbers(List<int>list)
            //    if(List>.count>0)
            //    {for(int i=0;i<list.count;i++)
            //      {
            //        if(list[i]%2==0)
            //          result.add(list[i]);

            //
            //
            //      return result
            //      }
            //    }



            // list<int>numbers=Enumerable.Range(1,100).ToList():
            // list<int> oddnumbers=findoddnumbers(numbers);
            // list<int> evennumbers=findevennumbers(numbers);
            //print(oddnumbers)
            #endregion
            #region V6
            //PublicKey static list<T> findoddnumbers(List<T>list)
            //    if(List>.count>0)
            //    {for(int i=0;i<list.count;i++)
            //      {
            //        if(list[i]%2!=0)
            //          result.add(list[i]);

            //
            //
            //      return result
            //      }
            //    }

            //PublicKey static list<int> finevennumbers(List<T>list)
            //    if(List>.count>0)
            //    {for(int i=0;i<list.count;i++)
            //      {
            //        if(list[i]%2!=0)
            //          result.add(list[i]);

            //
            //
            //      return result
            //      }
            //    }


            #endregion
            #region V7
            //predicate -func-action
            // Predicate<int> predicate = ConditonFunction.Checkeven;
            //bool r=predicate.Invoke(1)
            // Console.WriteLine(r);


            //func
            // func<int> func=fun01;
            //Func<int,string>fun02;


            // Action
            // Action<string>action=print;
            //
            //action.Invoke();


            #endregion


            #region V8
            // anonymous method

            // list<int> Numbers=new list<int>(){1,2,3,4,5,6,7,8,9};
            // anonymous method
            //func<int,bool>func=delegate(int x){return x%2==0;};
            //FindElements(Numbers,func);





            //lambda Expression
            //func<int,bool>func=delegate(int x){return x%2==0;};

            // func<int,bool>func=x=>x%2=0;

            #endregion


            #region assignment
            List<Book> books = new List<Book>
        {
            new Book("1", "math", new string[] { "yousef", "esam" }, new DateTime(2020, 5, 10), 15000),
            new Book("2", "art C#", new string[] { "omar, malak" }, new DateTime(2021, 7, 15), 20000)
        };


            //Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
            LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunction.GetTitle));

            //Use the Proper build in delegate. 
            LibraryEngine.ProcessBooks(books, BookFunction.GetAuthors);

            //Anonymous Method (GetISBN).
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });


            //Lambda Expression (GetPublicationDate).
            LibraryEngine.ProcessBooks(books, b => b.PublicationData.ToShortDateString());






            #endregion
        }
    }
}
