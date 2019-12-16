using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class jogador3 : IJogador
    {
        public string chuta()
        {
            return "Teste chuta \n";
        }

        public string corre()
        {
            return "Teste corre \n";
        }

        public string passa()
        {
            return "Teste passa \n";
        }
    }

}