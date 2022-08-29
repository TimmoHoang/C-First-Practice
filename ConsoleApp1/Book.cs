using System;
using System.Collections.Generic;
using System.Text;

namespace FirstPractice
{
    class Book
    {
        public string title;
        public string author;
        public string name;
        
        // Constructor (Obv being called everytime object is created
        public Book()
            //Default Constructor
        {
            title = "";
            author = "";
            name = "";
        }
        public Book(string aTitle, string anAuthor, string aName)
        {
            title = aTitle;
            author = anAuthor;
            name = aName;
        }

        public void PrintBook()
        {
            Console.WriteLine(title + author + name);
        }
     
    }

    
}
