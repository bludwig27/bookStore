using System;

namespace bookStore
{
    class myStore
    {
        class book
        {
            int _id;
            string _title;
            string _author;

            public book()
            {
                _id = 0;
                _title = "";
                _author = "";
            }
            public book(int id, string title, string author)
            {
                _id = id;
                _title = title;
                _author = author;
            }
            public int getId()
            {
                return _id;
            }
            public string getTitle()
            {
                return _title;
            }
            public string getAuthor()
            {
                return _author;
            }
            public void setAuthor(string author)
            {
                _author = author;
            }
            public void setTitle(string title)
            {
                _title = title;
            }
            public void setId(int id)
            {
                _id = id;
            }
        }
        static void Main(string[] args)
        {
            book bk1= new book();
                bk1.setId(1);
                bk1.setTitle("The Iliad");
                bk1.setAuthor("Homer");

            book bk2 = new book();
                Console.WriteLine("Please enter the new book's ID number: ");
                bk2.setId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Please enter the new book's title: ");
                bk2.setTitle(Console.ReadLine());
                Console.WriteLine("Please enter the new book's author: ");
                bk2.setAuthor(Console.ReadLine());

            book bk3 = new book(3, "The Odyssey", "Homer");

            Console.WriteLine("Please enter another new book's ID#: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author: ");
            string tempAuthor = Console.ReadLine();
            book bk4 = new book(tempID, tempTitle, tempAuthor);

            displayBooks(bk1);
            displayBooks(bk2);
            displayBooks(bk3);
            displayBooks(bk4);
        }


        static void displayBooks(book bk)
        {
            Console.WriteLine("Here is your book information:");
            Console.WriteLine($"ID#: {bk.getId()}");
            Console.WriteLine($"Title: {bk.getTitle()}");
            Console.WriteLine($"Author: {bk.getAuthor()}");
        }

    }
}