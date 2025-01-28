using System.ComponentModel.DataAnnotations;

namespace WebFormularioContacto.Models
{
    public class ContactMessages
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress (ErrorMessage = "Ingrese un correo valido!")]
        [StringLength(75, ErrorMessage = "El email no puede exceder los 75 caracteres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El mensaje es obligatorio")]
        [StringLength(150,ErrorMessage ="El mensaje no puede exceder los 150 caracteres")]
        public string Mensaje { get; set; }


    }
}
