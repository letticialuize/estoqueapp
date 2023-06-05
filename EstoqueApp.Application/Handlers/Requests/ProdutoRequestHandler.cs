using EstoqueApp.Application.Handlers.Notifications;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using EstoqueApp.Application.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Handlers.Requests
{
    public class ProdutoRequestHandler :
        IRequestHandler<ProdutoCreateCommand, ProdutoQuery>,
        IRequestHandler<ProdutoDeleteCommand, ProdutoQuery>,
        IRequestHandler<ProdutoUpdateCommand, ProdutoQuery>

    {
        private readonly IMediator _mediator;
        public async Task<ProdutoQuery> Handle(ProdutoCreateCommand request, CancellationToken cancellationToken)
        {
            var produtoQuery = new ProdutoQuery();

            await _mediator.Publish(
                new ProdutoNotification
                {
                    Action = ActionNotification.Create,
                    Produto = produtoQuery
                }
            );

            return produtoQuery;
        }

        public async Task<ProdutoQuery> Handle(ProdutoUpdateCommand request, CancellationToken cancellationToken)
        {
            var produtoQuery = new ProdutoQuery();

            await _mediator.Publish(
                new ProdutoNotification
                {
                    Action = ActionNotification.Update,
                    Produto = produtoQuery
                }
            );

            return produtoQuery;
        }

        public async Task<ProdutoQuery> Handle(ProdutoDeleteCommand request, CancellationToken cancellationToken)
        {
            var produtoQuery = new ProdutoQuery();

            await _mediator.Publish(
                new ProdutoNotification
                {
                    Action = ActionNotification.Delete,
                    Produto = produtoQuery
                }
            );

            return produtoQuery;
        }

        
    }
}
