﻿using EstoqueApp.Application.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Models.Commands
{
    public class EstoqueCreateCommand : IRequest<EstoqueQuery>
    {
        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string? Nome { get; set; }


        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(250, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string? Descricao { get; set; }
    }
}
