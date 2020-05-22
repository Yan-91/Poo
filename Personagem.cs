namespace PRIMEIROPOO
{
    public class Personagem
    {
        public string nome;

        public int idade=20;
    
        public string armadura;
        
        public float Atacar(float forca , float potencia)
    {
        return forca + potencia;
    }

    public string Defender()
    {
        return "O personagem atacou";
    }
    }
}