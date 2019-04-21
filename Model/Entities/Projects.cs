using System;
using System.ComponentModel.DataAnnotations;

namespace FlameAPI.Model.Entities
{
    public class Projects
    {
        [Key]
        public int id { get; set; }
        public double bpm { get; set; }
        public int projectID { get; set; }
        public int author { get; set; }
        public int sampleRate { get; set; }
        public int stepSequencer { get; set; }
        public int padPerformer { get; set; }


        public Projects()
        {
          
    }
    }
}
