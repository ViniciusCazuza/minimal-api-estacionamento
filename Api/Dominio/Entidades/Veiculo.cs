using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Dominio.Entidades;

public class Veiculo
{
    [Key] //==> Torna uma chave primaria tipo ID
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //==> Auto Incrementavel ( ID Identity )
    public int Id { get; set; } = default!;

    [Required] //==> Torna obrigatorio !
    [StringLength(150)] //==> Limita a quantidade de caracter
    public string Nome { get; set; } = default!;


    [Required] //==> Torna obrigatorio !
    [StringLength(100)]
    public string Marca { get; set; } = default!;

    [Required] //==> Torna obrigatorio !
    public int Ano { get; set; } = default!;

}