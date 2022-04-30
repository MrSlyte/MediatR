using System.Collections.Generic;

namespace MediatR
{
    public class ChatSala : AbstractChatSala
    {
        private readonly Dictionary<string, Participante> _participantes;

        public ChatSala()
        {
            _participantes = new Dictionary<string, Participante>();
        }
        public override void Registro(Participante participante)
        {
            if (!_participantes.ContainsValue(participante))
            {
                _participantes.Add(participante.Nome, participante);
            }
            participante.ChatSala = this;
        }

        public override void Enviar(string de, string para, string msg)
        {
            var participante = _participantes[para];
            if(participante != null)
            {
                participante.ReceberMensagem(de, msg);
            }
        }
    }
}
