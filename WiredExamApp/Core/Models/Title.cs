using System;
using System.ComponentModel.DataAnnotations;

namespace WiredExamApp.Core.Models
{
    public class Title
    {
        public int Id { get; set; }
        [Display(Name="Article Title")]
        public string ArticleTitle { get; set; }
        public string ArticleLink { get; set; }
        [Display(Name="Created Date")]
        public DateTime? CreateDateTime { get; set; }

        public string ShortDate => $"{CreateDateTime:dd-MM-yy}";
    }
}