using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    class Library
    {
        private int numberOfBooks;
        private int numberOfStudents;

        private List<String> studentsList = new List<String>() { };

        private List<Book> bookList = new List<Book>() { };

        public int NumberOfBooks
        {
            get { return numberOfBooks; }   
            set { numberOfBooks = value; }
        }

        public int NumberOfStudents
        {
            get { return numberOfStudents; }
            set { numberOfStudents = value; }
        }

        public List<Book> BookList
        {
            get { return bookList; }
            set { bookList = value; }
        }

        public List<String> StudentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }

        public override string ToString()
        {
            string books = "";
            string students = "";

            foreach(var i in BookList)
            {
                books = books + i.ToString();
            }

            foreach (var y in StudentsList)
            {
                students = students + y.ToString();
            }

            return string.Format($"\n{this.NumberOfBooks}\n{this.numberOfStudents}\n{books}\n{students}\n");
        }
    }
}
