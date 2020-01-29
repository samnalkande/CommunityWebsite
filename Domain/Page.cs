using System.ComponentModel.DataAnnotations;

namespace de.tbdev.CommunityWebsite.Domain
{
    public class Page
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        
        [Required]
        public string Content { get; set; }
    }
}