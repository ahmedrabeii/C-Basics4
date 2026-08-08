namespace c_Basics_Assignment_Session04
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region Call Question 3
            //PrintWelcomeMessage();
            #endregion

            #region Call Question 4
            //PrintBookTitle("Clean Code");
            #endregion

            #region Call Question 5
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);

            //print 400
            //because the method gets a copy of pages, not the original variable.

            #endregion

            #region Call Question 6
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);

            //print 20.5
            //because the method modifies the original array, not a copy.
            #endregion
        }



        #region Question 1

        //double[] values = { 25.5, 40.0, 33.75 };
        //Console.WriteLine(values[1]);

        #endregion


        #region Question 2
        //0       //1
        //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
        //Console.WriteLine(shelfCopies[1, 0]);

        #endregion


        #region Question 3

        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}

        #endregion


        #region Question 4

        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title); 
        //}

        #endregion


        #region Question 5

        //static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //}

        #endregion


        #region Question 6

        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}

        #endregion
    }
}

