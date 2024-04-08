namespace Jogogabisa;
public  class Gatinhos
    {
     protected Double Fome;
     protected Double Alegria;
     protected Double Banho;
      
     protected string nomedafoto;
     protected string nomedafotomorto;
     protected bool morto;

     public  Gatinhos()
     {

     }
     public string GetNomeDaFoto()
     {
        if(morto)
        return nomedafotomorto
        else
        return nomedafoto;
     }

     public void SetFome(double f)
     {
      if (f>1)
      Fome=1;
      else if (f<=0)
      {
        morto=true;
        Fome=0;
      }
      else
      Fome=f;
     }
      
     public double GetFome()
     {
       return Fome;
     }
       public void SetBanho(double b)
     {
       if (b>1)
      Fome=1;
      else if (b<=0)
      {
        morto=true;
        Banho=0;
      }
      else
      Banho=b;
     }
      
     public double GetBanho()
     {
       return Banho;
     }
     public void SetAlegria(double a)
     {
       if (a>1)
      Alegria=1;
      else if (a<=0)
      {
        morto=true;
        Alegria=0;
      }
      else
      Alegria=a;
     }
      
     public double GetAlegria()
     {
       return Alegria;
     }
    }