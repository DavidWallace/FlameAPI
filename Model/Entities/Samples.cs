using System;
using System.ComponentModel.DataAnnotations;

namespace FlameAPI.Model.Entities
{
    public class Samples
    {
        public string name { get; set; }
        public string volume { get; set; }
        public string lenght { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        [Key]
        public int id { get; set; }
    }
}
