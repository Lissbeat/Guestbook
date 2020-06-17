using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace assignment_3.Models
{
    public class PostViewModel
    {
        [Required]
        public Post Post{ get; set; }
        [Required]
        public List<Post> Posts{ get; set;  }
    }
}