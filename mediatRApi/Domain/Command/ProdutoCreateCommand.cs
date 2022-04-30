using MediatR;

namespace MediatRApi.Domain.Command
{
    public class ProdutoCreateCommand : IRequest<string>
    {
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
    }
}
