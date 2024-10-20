namespace MinimalApi.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Administrador
{
    [Key] //==> Torna uma chave primaria tipo ID
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //==> Auto Incrementavel ( ID Identity )
    public int Id { get; set; } = default!;

    [Required] //==> Torna obrigatorio !
    [StringLength(255)] //==> Limita a quantidade de caracter
    public string Email { get; set; } = default!;

    [Required] //==> Torna obrigatorio !
    [StringLength(50)]
    public string Senha { get; set; } = default!;
    
    [Required] //==> Torna obrigatorio !
    [StringLength(10)]
    public string Perfil { get; set; } = default!;
}