using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniInstagramWithAuth.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public int Likes { get; set; }

        public Post()
        {
            Id = Guid.NewGuid();
            Text = "";
            Url = "";
            Likes = 0;
        }
    }
}