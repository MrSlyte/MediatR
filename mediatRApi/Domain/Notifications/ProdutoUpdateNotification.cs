using MediatR;

namespace MediatRApi.Domain.Notifications
{
    public class ProdutoUpdateNotification : INotification
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool IsConcluido { get; set; }
    }
}
