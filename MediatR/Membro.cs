using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR
{
    public class Membro : Participante
    {

        public Membro(string nome) :base(nome)
        {

        }

        public override void ReceberMensagem(string de, string msg)
        {
            Console.Write("para Membro : ");
            base.ReceberMensagem(de, msg);
        }
    }
}
