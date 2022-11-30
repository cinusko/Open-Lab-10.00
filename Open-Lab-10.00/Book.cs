using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private string releaseDate;



            public string Title(string titleSet)
            {
                this.title = titleSet;
                return title;
            }
            public int Pages(int pagesSet)
            {
                this.pages = pagesSet;
                return pages;
            }
            public string Category(string categorySet)
            {
                this.category = categorySet;
                return category; 
            }
            public string Author(string authorSet)
            {
                this.author = authorSet;
                return author;
            }
            public string ReleaseDate(string releaseDateSet)
            {
                this.releaseDate = releaseDateSet;
                return releaseDate; 
            }
        public void PrintValues()
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }
    }
}
