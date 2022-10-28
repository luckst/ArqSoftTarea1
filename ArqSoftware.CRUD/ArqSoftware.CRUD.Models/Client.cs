using System.ComponentModel.DataAnnotations;

namespace ArqSoftware.CRUD.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
