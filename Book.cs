using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1
{
   struct Book {
        public string title, author, introduction;

        public short pages;

        public void setValues (string title, string author) {
            this.title = title;
            this.author = author;
        }

        public void printValues() {
            Console.WriteLine(this.author + " write book" + this.title + "");
        }
    }
}
