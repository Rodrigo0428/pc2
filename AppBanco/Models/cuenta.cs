using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppBanco.Models
{
    [Table("t_cuenta")]
    public class Cuenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NombreTitular {   get; set;}
        public string? TipoCuenta{ get; set; }
        public decimal Saldo { get; set; }
        public string? correo { get; set; }
       
        
       
    }
}