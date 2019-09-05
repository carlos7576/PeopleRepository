using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using People.models;

namespace People
{
    class PersonReposityCRUD
    {
        SQLiteConnection conn;
        public string statusMessegue { get; set; }
        public PersonReposityCRUD(string dbPach)
        {
            conn = new SQLiteConnection(dbPach);
            conn.CreateTable<Person>();
        }
    }
}
