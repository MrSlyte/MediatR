using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR
{
    public abstract class Participante
    {
        private string _nome;
        private ChatSala _chatSala;

        public Participante(string Nome)
        {
            _nome = Nome;
        }

        public string Nome { get { return _nome; } }
        public ChatSala ChatSala { get { return _chatSala; } set { _chatSala = value; } }

        public virtual void Enviar(string para, string msg)
        {
            _chatSala.Enviar(_nome, para, msg);
        }

        public virtual void ReceberMensagem(string de, string msg)
        {
            Console.WriteLine("{0} para {1}: '{2}'", de, Nome, msg);
        }
    }
}
