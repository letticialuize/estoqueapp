using EstoqueApp.Application.Interfaces.Persistences;
using EstoqueApp.Application.Interfaces.Service;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IMediator? _mediator;
        private readonly IProdutoPersistence _produtoPersistence;


        public ProdutoAppService(IMediator? mediator, IProdutoPersistence produtoPersistence)
        {
            _mediator = mediator;
            _produtoPersistence = produtoPersistence;
        }

        public async Task<ProdutoQuery> Create(ProdutoCreateCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<ProdutoQuery> Delete(ProdutoDeleteCommand command)
        {
            return await _mediator.Send(command);
        }
        public async Task<ProdutoQuery> Update(ProdutoUpdateCommand command)
        {
            return await _mediator.Send(command);
        }

        public List<ProdutoQuery> GetAll()
        {
            return _produtoPersistence.GetAll();
        }

        public ProdutoQuery GetById(Guid? id)
        {
            return _produtoPersistence.GetById(id.Value);
        }


    }
}
