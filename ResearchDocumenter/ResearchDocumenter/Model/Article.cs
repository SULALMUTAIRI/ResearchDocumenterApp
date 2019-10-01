using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResearchDocumenter.Model
{
    public class Article
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Title { get; set; }
        public string Year { get; set; }
        public string MainAuthor { get; set; }
    }
}
