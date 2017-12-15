using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeedingAdminUsers.Models
{
    public class Comment
    {
        
            [Key]
            public int CommentID { get; set; }
            public int ArticleID { get; set; }
            [DataType(DataType.MultilineText)]
            public string CommentBody { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime CommentDate { get; set; }
            public string UserName { get; set; }
        
    }
}