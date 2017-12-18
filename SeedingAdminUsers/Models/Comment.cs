using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeedingAdminUsers.Models
{
    /// <summary>
    /// Comment Model
    /// This model creates the structure of a comment.
    /// Holds values: Comment ID, Article ID where it belongs, contents of the comment, the date the comment was made and the username.
    /// </summary>
    public class Comment
    {
        
            [Required]
            public int CommentID { get; set; }
            public int ArticleID { get; set; }
            [DataType(DataType.MultilineText)]
            public string CommentBody { get; set; }
            public DateTime CommentDate { get; set; }
            public string UserName { get; set; }
        
    }
}