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

            }
        }
    }
}
