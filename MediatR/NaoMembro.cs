using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR
{
    public class NaoMembro : Participante
    {

        public NaoMembro(string nome) :base(nome)
        {

        }

        public override void ReceberMensagem(string de, string msg)
        {
            base.ReceberMensagem(de, $"{msg} (Anônimo)");
        }
    }
}
