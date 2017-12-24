using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
    }
}