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
        private int releaseDate;



            public string Title
            {
                get { return title; }
                set { title = value; }
                
            }
            public int Pages
            {
                get { return pages; }
                set
                {
                    if (value < 0)
                    { 
                        pages = 1;
                    }
                    else
                    {
                        pages = value;
                    }
                }
            }
            public string Category
            {
                get { return category; }
                set { category = value; }
            }
            public string Author
            {
                get { return author; }
                set { author = value; }
            }
            public int ReleaseDate
            {
                get { return releaseDate; }
                set 
                {
                    if (value < 1450)
                    {
                        releaseDate = -1;
                    }
                    else if (value > 2021)
                    {
                        releaseDate = -1;
                    }
                    else
                    { 
                        releaseDate = value;
                    }

                }
            }
        public override string ToString()
        {
            return String.Format($"{title}\n{pages}\n{category}\n{author}\n{releaseDate}");
        }
    }
}
