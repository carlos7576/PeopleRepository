using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace People.models
{
    [Table("T_People")]
   public class Person
    {
        //miembro: propierties
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(50)]
        public string name { get; set; }
    }
}
