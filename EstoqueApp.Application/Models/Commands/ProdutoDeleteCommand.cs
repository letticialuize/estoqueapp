﻿/////using System;
using EstoqueApp.Application.Models.Queries;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Models.Commands
{
    public class ProdutoDeleteCommand : IRequest<ProdutoQuery>
    {
        public Guid? Id { get; set; }
    }
}
