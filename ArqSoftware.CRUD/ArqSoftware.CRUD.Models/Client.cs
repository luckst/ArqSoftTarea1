using System.ComponentModel.DataAnnotations;

namespace ArqSoftware.CRUD.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Required]
        public string DocumentNumber { get; set; }
        [StringLength(150)]
        [Required]
        public string LastName { get; set; }
        [StringLength(150)]
        [Required]
        public string FirstMidName { get; set; }
        [StringLength(150)]
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
    }
}
