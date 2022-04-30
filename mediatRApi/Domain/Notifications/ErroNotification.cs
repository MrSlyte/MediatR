using MediatR;

namespace MediatRApi.Domain.Notifications
{
    public class ErroNotification : INotification
    {
        public string Erro { get; set; }
        public string PilhaErro { get; set; }
    }
}
