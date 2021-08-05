using System;

namespace ExemploApiCatalogoJogos.Exceptions
{
    public class JogoNCadastradoException: Exception
    {
        public JogoNCadastradoException()
            :base("Este jogo não está cadastrado")
        {}
    }
}
