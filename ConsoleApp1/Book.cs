using System;
using System.Collections.Generic;
using System.Text;

namespace FirstPractice
{
    class Book
    {
        // Normal attribute
        public string title;
        public string author;
        public string name;

        // Static (shared) attribute.
        public static int bookCount = 0;

        // Constructor (Obv being called everytime object is created
        public Book()
        //Default Constructor
        {
            title = "";
            author = "";
            name = "";
            bookCount++;
        }
        public Book(string aTitle, string anAuthor, string aName)
        {
            title = aTitle;  // normal
            Author = anAuthor;  // call setter by Calling the setter.(Author is called not author).
            name = aName; // normal 
            bookCount++;
        }

        public void PrintBook()
        {
            Console.WriteLine(title + author + name);
        }


        // Getter/setter
        public string Author
        {
            get { return this.author; }
            set
            {
                author = "Setting the author";
            }
        }
    }

    
}
