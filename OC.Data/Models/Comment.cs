using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Data.Models
{
    public class Comment
    {
        public string CommentId { get; set; }
        public string ManualId { get; set; }
        public string AuthorId { get; set; }
        public string Content { get; set; }
    }
}
