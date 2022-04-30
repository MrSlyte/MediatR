using System;

namespace MediatR
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatSala = new ChatSala();

            var joao = new Membro("João");
            var alice = new Membro("Alice");
            var carol = new NaoMembro("Carol");
            var marcos = new Membro("Marcos");

            var guilherme = new Membro("Guilherme");
            var astolfo = new Membro("Astolfo");
            var jorjim = new NaoMembro("Jorjim bala tensa");
            var pinas = new NaoMembro("é o pinas");

            chatSala.Registro(joao);
            chatSala.Registro(alice);
            chatSala.Registro(carol);
            chatSala.Registro(marcos);
            chatSala.Registro(guilherme);
            chatSala.Registro(astolfo);
            chatSala.Registro(jorjim);
            chatSala.Registro(pinas);

            alice.Enviar(guilherme.Nome, "Trouxa");
            guilherme.Enviar(alice.Nome, "trouxa é vc");
            jorjim.Enviar(marcos.Nome, "toma na cabeça");
            marcos.Enviar(jorjim.Nome, "sai fora loco");
            
        }
    }
}
