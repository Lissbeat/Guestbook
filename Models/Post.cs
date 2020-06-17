using System.ComponentModel.DataAnnotations;
using Microsoft.IdentityModel.Xml;

namespace assignment_3.Models
{
    public class Post
    {
      
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { set; get;  }
        [Required(ErrorMessage = "Title is required")]
        public string Title { set; get;  }
        [Required(ErrorMessage = "Message" +
                                 " is required")]
        public string Message { set; get;  }
        
       
        
    }
    
    
}
