using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WiredExamApp.Models
{
    public class Title
    {
        public int Id { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleLink { get; set; }
        public DateTime? CreateDateTime { get; set; }
    }
}