using System; //recursividade, eca

public class Calculadora{

    public int fatorial(int n){

        if(n == 1){
            return n;
        } 
        return n*(fatorial(n-1)); //fiz sem ver o vídeo, bora ver se o pai lembra
        //to craque porra
    }

   public int soma(int n1, int n2){

      return n1 + n2;       

   }


}

public class Aula48{
    public static void Main(){
        Calculadora calc = new Calculadora();
        Console.WriteLine(calc.fatorial(5));
    }
}