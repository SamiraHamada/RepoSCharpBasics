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

            }
        }
    }
}
