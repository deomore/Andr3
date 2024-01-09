using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace App5
{
    [Table("Bros")]
    public class Bros

    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Nick { get; set; }
        public string Tier { get; set; }
      
    }
}
