using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeTarefas.Models
{
    public class Tarefa
    {
        private bool? concluida = false;

        public long Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        [StringLength(50, ErrorMessage = "O titulo deve conter entre 3 e 50 caracteres", MinimumLength = 3)]
        public string Titulo { get; set; }

        [MaxLength(100, ErrorMessage = "A descrição deve conter até 100 caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Data de Expiração")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DataExpiracao { get; set; }

        public bool? Concluida { get => concluida; set => concluida = value; }
    }
}