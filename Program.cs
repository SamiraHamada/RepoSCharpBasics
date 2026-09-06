namespace Assignment01_C_Basics
{
    class Book
    {
        public string Title;
        public int Pages;

        public override string ToString()
        {
            return $"{Title} ,{Pages}";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                #region 1st Question
                //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.

                Book book = new Book();
                book.Title = "The Road To Success";
                book.Pages = 200;
                Object obj = book;
                Console.WriteLine(obj);

                #endregion
                #region 2nd Question

                // Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
                Console.WriteLine(book.ToString());
                Console.WriteLine(book.Equals(book));
                Console.WriteLine(book.GetHashCode());
                Console.WriteLine(book.Title.GetType());
                Console.WriteLine(book.Pages.GetType());
                #endregion
                #region 3rd Question
                //Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
                //int pages="145";  Compile-time error Do not put string in int variable
                int pages = 145; // Corrected to int 
                #endregion
                #region 4th Question
                //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.

                try
                {
                    int y = 0;
                    int X = 10 / y;

                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                finally
                {
                    Console.WriteLine("Done");
                }

                #endregion
                #region 5th Question
                //Declare an int page = 300; then store it in a double variable without using a cast.
                int page = 300;
                double A = page;
                Console.WriteLine(A);
                #endregion
                #region 6th Question
                //Declare a double price = 49.99; then convert it into an int using a cast.
                double price = 49.99;
                int p = (int)price;
                Console.WriteLine(p);
                #endregion
                #region 7th Question
                //Given string pagesText = "464";, convert it into an int using the Convert class.
                string pagesText = "200";
                int pagesInt = Convert.ToInt32(pagesText);
                Console.WriteLine(pagesInt);

                #endregion
                #region 8th Question
                //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

                string yearText = "2023";

                int year = int.Parse(yearText);

                Console.WriteLine(year);

                string badText = "abc";

                if (int.TryParse(badText, out int number))
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
                #endregion
                #region 9th Question
                //Given int bookpages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
                int bookPages = 464;
                string bookPagesText = bookPages.ToString();
                Console.WriteLine(bookPagesText.GetType());

                #endregion


            }
        }
    }
}
