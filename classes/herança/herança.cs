namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distancia; //para a declaração de variaveis privadas é possivel usar o underline antes do nome ex: _distancia
        
        public Ponto(int x, int y)
        {
            this.x = x; //fazem referencia a classe Ponto
            this.y = y; 
        }

        protected void CalcularDistancia() //somente quem herdar dessa classe terá acesso
        {
            //Faz alguma coisa...
            CalcularDistancia2();
        }

        private void CalcularDistancia2() //só pode ser usado dentro dessa classe -> Ponto
        {
            //Faz alguma coisa...
        }

        public virtual void CalcularDistancia3() //permite que uma classe filha sobrescreva as ações dele
        {
            //Faz alguma coisa...
        }
    }
}