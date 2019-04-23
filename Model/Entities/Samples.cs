using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlameAPI.Model.Entities
{
    public class Samples
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
        public string volume { get; set; }
        public int lenght { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int projID { get; set; }


    }
}
