using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O Nome do Jogo deve ter entre 3 e 100 Caracteres.")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O Nome da Produtora deve ter entre 3 e 100 Caracteres.")]
        public string Produtora { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "O Preço de ser no mínimo de R$: 1,00 e no Máximo de R$: 1.000,00 Reais.")]
        public double Preco { get; set; }

    }
}
