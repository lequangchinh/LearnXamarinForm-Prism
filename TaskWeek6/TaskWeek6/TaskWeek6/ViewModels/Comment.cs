using System;
using System.Collections.Generic;
using System.Text;

namespace TaskWeek6.ViewModels
{
   public class Comment
    {
        public int PostId { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }
}

