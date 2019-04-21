using System;
using System.ComponentModel.DataAnnotations;

namespace FlameAPI.Model.Entities
{
    public class Posts
    {
        public int userID { get; set; }
        [Key]
        public string postID { get; set; }
        public string postType { get; set; }
        public string postTitle { get; set; }
        public string postText { get; set; }
        public string postURL { get; set; }
        public DateTime timestamp { get; set; }

    }
}
