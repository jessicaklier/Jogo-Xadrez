using System;


namespace tabuleiro
{
    class TabuleiroException : Exception
    {
        // fazendo uma exceção personalizada
        public TabuleiroException(string msg) : base(msg)
        {

        }
    }
}
