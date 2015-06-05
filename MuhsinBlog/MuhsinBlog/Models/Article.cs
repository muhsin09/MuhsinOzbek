using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuhsinBlog.Models
{
    public class Article
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DisplayName("Type Title:")]
        public string Title { set; get; }

        [Required]
        [DisplayName("Date:")]
        public DateTime Date { set; get; }

        [Required]
        [DisplayName("Type Your Article:")]
        public string Body { set; get; }

        [DisplayName("Browse Article Image")]
        public string PhotoUrl { set; get; }
    }
}