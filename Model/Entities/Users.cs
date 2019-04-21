using System;
using System.ComponentModel.DataAnnotations;

namespace FlameAPI.Model.Entities
{
    public class Users
    {
            [Key]
            public int id { get; set; }
            public string username { get; set; }
            public string firstName  { get; set; }
            public string lastName  { get; set; }
            public string password { get; set; }
            public string location { get; set; }
            public string dob { get; set; }
            public string usertype { get; set; }
            public string description { get; set; }
            public string artistsLike { get; set; }
            public string interests { get; set; }
            public string picture { get; set; }
            public string email { get; set; }
            public string randid { get; set; }

    }
}
