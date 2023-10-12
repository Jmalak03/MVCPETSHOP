using System.ComponentModel.DataAnnotations;

namespace MVCPETSHOP.Models
{
    public class PedidoModel
    {
        [Display(Name = "Fecha de pedido ")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Nombre ")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(15, ErrorMessage = "Longitud entre 6 y 15 caracteres.",
                      MinimumLength = 6)]
        [DataType(DataType.Text)]
        public string? Nombre { get; set; }

        [Display(Name = "Productos Descripcion ")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(15, ErrorMessage = "Longitud entre 6 y 15 caracteres.",
                  MinimumLength = 6)]
        [DataType(DataType.Text)]
        public string? Productos { get; set; }


        [Display(Name = "Recordarme")]
        public bool RememberMe { get; set; }

    }
}
