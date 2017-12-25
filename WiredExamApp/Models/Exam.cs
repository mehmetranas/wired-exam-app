using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WiredExamApp.Models
{
    public class Exam
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ArticleText { get; set; }
        public ICollection<Question> Questions { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreateDateTime { get; set; }
        [NotMapped]
        [Display(Name = "Created Date")]
        public string ShortDate => $"{CreateDateTime:dd-MM-yy}";
    }
}