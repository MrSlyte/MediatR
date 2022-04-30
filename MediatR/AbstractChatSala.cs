using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR
{
    public abstract class AbstractChatSala
    {
        public abstract void Registro(Participante participante);
        public abstract void Enviar(string de, string para, string msg);
    }
}
