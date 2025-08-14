namespace Session3_adv
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = { 5, 2, 9, 4, 7, 0, 1, 10 };
            BubbleSort.PrintArrays(numbers);
            Console.WriteLine();

            //SortDelegate X=ExpressionSort.GreaterThan;
            //BubbleSort.sortnumbers(numbers,X);
            BubbleSort.PrintArrays(numbers);
            Console.WriteLine();
            SortDelegate<int> X= ExpressionSort.LessThan;

            BubbleSort.sortnumbers(numbers,X);
            BubbleSort.PrintArrays(numbers);


        }
    }
}
