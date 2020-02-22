namespace webappUno.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage ="El nombre es requerido")]
        [Display(Name ="Nombre Completo")]
        [StringLength(100,ErrorMessage ="Máximo 100 caracteres")]
        public string Name { get; set; }

        [Display(Name ="Carnet de Identidad")]
        public string Document { get; set; }
    }
}