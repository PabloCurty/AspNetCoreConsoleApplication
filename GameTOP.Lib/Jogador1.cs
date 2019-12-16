using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        public Jogador1(){
            _Nome = "Rodinei";
        }
        public readonly string _Nome; 

        //chuta
        public string chuta()
        {
            return $"{_Nome} está Chutando \n";
        }
        //corre
        public string corre()
        {
            return $"{_Nome} está Correndo \n";
        }
        //passe
        public string passa()
        {
            return $"{_Nome} está Passando \n";
        }
    }
}