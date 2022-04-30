using MediatR;

namespace MediatRApi.Domain.Command
{
    public class ProdutoUpdateCommand : IRequest<string>
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
    }
}
