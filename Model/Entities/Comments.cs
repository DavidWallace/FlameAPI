using System;
using System.ComponentModel.DataAnnotations;

namespace FlameAPI.Model.Entities
{
    public class Comments
    { 
        public int UserID { get; set; }
        public string PostID { get; set; }
        public string Comment { get; set; }
        public string Archived { get; set; }
        public DateTime TimeStamp { get; set; }
        [Key]
        public int id { get; set; }

    }
}
