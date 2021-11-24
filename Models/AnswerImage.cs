using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab05.Models
{
    public enum Question
    {
        Earth, Computer
    }
    public class AnswerImage
    {
        public int AnswerImageId
        {
            get;
            set;
        }

        [Required]
        [DisplayName("File Name")]

        public string FileName
        {
            get;
            set;
        }

        [Required]
        [Url]
        [DisplayName("Image")]
        public string Url
        {
            get;
            set;
        }
        public Question Question
        {
            get;
            set;
        }
    }
    
}
