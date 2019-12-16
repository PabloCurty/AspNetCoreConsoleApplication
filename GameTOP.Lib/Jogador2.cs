using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string chuta()
        {
            return "Maradona está Chutando \n";
        }

        public string corre()
        {
            return "Maradona está Correndo \n";
        }

        public string passa()
        {
            return "Maradona está Passando \n";
        }
    }        
}