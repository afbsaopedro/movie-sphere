﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSphere.Models
{
    public class Comment
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Comment")]
        public string Content { get; set; }

        //ForeignKeys
        [DisplayName("Movie ID")]
        public int MovieId { get; set; }

        [DisplayName("User ID")]
        public string ApplicationUserId { get; set; }

        //NavigationProperties
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
