﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS221_PA6_New
{
    class Book
    {
   
        //getters and setters in a much easier format than we had to do for PA5
        public String cwid { get; set; }
        public String isbn { get; set; }
        public String title { get; set; }
        public String author { get; set; }
        public String cover { get; set; }
        public String genre { get; set; }
        public int length { get; set; }
        public int copies { get; set; }
        public String _id { get; set; }

        public Book(string cwid, string isbn, string title, string author, string cover, string genre, int length, int copies, string id)
        {
            //constructor

            this.cwid = cwid;
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.cover = cover;
            this.genre = genre;
            this.length = length;
            this.copies = copies;
            _id = id;
        }

        public Book()
        {

        }
        public override string ToString()
        {
            return this.title;
        }
    }
}
