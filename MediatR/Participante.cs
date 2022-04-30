using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR
{
    public abstract class Participante
    {
        private readonly string _nome;

        protected Participante(string Nome)
        {
            _nome = Nome;
        }

        public string Nome { get { return _nome; } }
        public ChatSala ChatSala { get; set; }

        public virtual void Enviar(string para, string msg)
        {
            ChatSala.Enviar(_nome, para, msg);
        }

        public virtual void ReceberMensagem(string de, string msg)
        {
            Console.WriteLine("{0} para {1}: '{2}'", de, Nome, msg);
        }
    }
}
