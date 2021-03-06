﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlameAPI.Model.Entities
{
    public class Projects
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public string bpm { get; set; }
        public int projectID { get; set; }
        public int author { get; set; }
        public int sampleRate { get; set; }
        public DateTime timestamp { get; set; }

    }

}
