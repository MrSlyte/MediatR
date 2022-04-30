using MediatR;

namespace MediatRApi.Domain.Command
{
    public class ProdutoDeleteCommand : IRequest<string>
    {
        public int Id { get; set; }
    }
}
