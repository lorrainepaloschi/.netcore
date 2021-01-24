namespace Classes.Herança
{
    public class Ponto3D : Ponto //  : significa herdar - no c# voce pode herdar de multiplas INTERFACES, mas de apenas uma classe
    //todos os membros serão herdados
    {
        public int z;
        
        public Ponto3D(int x, int y, int z) : base(x, y) 
        {
            this.z = z;
            CalcularDistancia();
        }
        //herdou x e y, e criou o z
        public static void Calcular()
        //não pertence a instancia, pertence a classe
        
        {
            //Faz alguma coisa...
        }
        public override void CalcularDistancia3() //fara com que o metodo CalcularDistancia3() em herança seja sobreencristo por usar o "virtual"
        {
            //Faz outra coisa ...
            base.CalcularDistancia3();
        }
    }
}