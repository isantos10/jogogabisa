namespace Jogogabisa;
public  class Gatinhos
    {
     protected Double Fome;
     protected Double Alegria;
     protected Double Banho;
      
     protected string nomedafoto;
     public  Gatinhos()
     {

     }
     public string GetNomeDaFoto()
     {
        return nomedafoto;
     }

     public void SetFome(double f)
     {
      Fome=f;
     }
      
     public double GetFome()
     {
       return Fome;
     }
       public void SetBanho(double b)
     {
      Banho=b;
     }
      
     public double GetBanho()
     {
       return Banho;
     }
     public void SetAlegria(double a)
     {
      Alegria=a;
     }
      
     public double GetAlegria()
     {
       return Alegria;
     }
    }