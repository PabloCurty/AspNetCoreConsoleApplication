using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        public JogoFODA(IJogador _jogadorA, IJogador jogadorB)
        {
            __jogadorA = _jogadorA;
            _jogadorB = jogadorB;
        }

        public readonly IJogador __jogadorA;

        public readonly IJogador _jogadorB;

        public void iniciarJogo()
        {
            System.Console.Write(__jogadorA.chuta());
            System.Console.Write(__jogadorA.passa());
            System.Console.Write(__jogadorA.corre());
            System.Console.Write("Novo Jogador \n");
            System.Console.Write( _jogadorB.corre());
            System.Console.Write( _jogadorB.chuta());
            System.Console.Write( _jogadorB.passa());
        }
    }
}