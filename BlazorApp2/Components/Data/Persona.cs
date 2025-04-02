using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Components.Data
{
    public class Persona
    {
        [Required(ErrorMessage ="El nombre es obligatorio")] /*Aqui se pone el [Required] para que sea obligatorio*/
        [MaxLength(20, ErrorMessage ="El nombre debe teer menos de 20 caracterres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage ="El correo es obligatorio")] /*Aqui se pone el [Required] para que sea obligatorio*/
        [EmailAddress(ErrorMessage ="No carnalito debe ser un correo valido")]
        public string? Correo { get; set; }
        [Range(10,120, ErrorMessage ="El reango de edad es de 10-120")]
        public int Edad {  get; set; }
        [Required(ErrorMessage ="Debes ingresar un genero")]
        public string? Genero { get; set; }


    }
}
