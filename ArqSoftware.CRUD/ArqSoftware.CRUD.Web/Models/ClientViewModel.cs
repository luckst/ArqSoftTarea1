using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArqSoftware.CRUD.Web.Models
{
    public class ClientViewModel
    {
        public int? Id { get; set; }
        [MaxLength(20)]
        [DisplayName("Documento")]
        [Required]
        public string DocumentNumber { get; set; }
        [MaxLength(150)]
        [DisplayName("Apellidos")]
        [Required]
        public string LastName { get; set; }
        [MaxLength(150)]
        [DisplayName("Nombres")]
        [Required]
        public string FirstMidName { get; set; }
        [MaxLength(150)]
        [DisplayName("Correo")]
        [Required]
        public string Email { get; set; }
    }
}
