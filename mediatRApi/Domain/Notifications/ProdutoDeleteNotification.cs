using MediatR;

namespace MediatRApi.Domain.Notifications
{
    public class ProdutoDeleteNotification : INotification
    {
        public int Id { get; set; }
        public bool IsConcluido { get; set; }
    }
}
