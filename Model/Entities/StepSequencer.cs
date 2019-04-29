using System;
using System.ComponentModel.DataAnnotations;

namespace FlameAPI.Model.Entities
{
    public class StepSequencer
    {
        public string name { get; set; }
        public decimal volume { get; set; }
        public int length { get; set; }
        [Key]
        public int id { get; set; }
        public int projID { get; set; }
        public int? user { get; set; }



    }
}
