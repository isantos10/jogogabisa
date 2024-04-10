using System.Reflection;
using Microsoft.Maui.Controls;

namespace Jogogabisa;

public partial class MainPage : ContentPage
{
	Aime aime;
	Theo theo;
    Liz  liz;
	Gatinhos atual;
	IDispatcherTimer timer;

	public MainPage()
	{
		InitializeComponent();
		aime = new Aime();
		theo = new Theo();
        liz  = new Liz();
		atual = aime;
		fotosdogato.Source= atual.GetNomeDaFoto();
		AtualizaBarras();
		 timer=Application.Current.Dispatcher.CreateTimer();
		timer.Interval=TimeSpan.FromSeconds(10);
		timer.Tick+=(s,e)=>
		PassouTempo();
		timer.Start();
	}

	void trocarclicado(object sender, EventArgs args)
	{
		if (atual == aime)
			atual = theo;
		else if (atual == theo)
			atual = liz;
		else if (atual == liz)
		     atual = aime;
		fotosdogato.Source = atual.GetNomeDaFoto();

		if (atual.GetMorto())
		{
			botao.IsVisible=false;
		}
		else 
		{
			botao.IsVisible=true;
		}
	}
	void trocarclicadodois(object sender, EventArgs args)
	{
		if (atual == liz)
			atual = theo;
		else if (atual == theo)
			atual = aime;
		else if (atual == aime)
		     atual = liz;
		fotosdogato.Source = atual.GetNomeDaFoto();

		if (atual.GetMorto())
		{
			botao.IsVisible=false;
		}
		else 
		{
			botao.IsVisible=true;
		}
		AtualizaBarras();
	}

	void AtualizaBarras()
	{
		progressoFome.Progress=atual.GetFome();
		progressoBanho.Progress=atual.GetBanho();
		progressoFeliz.Progress=atual.GetAlegria();
	}
	void botaobanho(object sender, EventArgs args)
	{
		atual.SetBanho (atual.GetBanho() + 0.1);
		AtualizaBarras();
    }
    void botaobrinquedo(object sender, EventArgs args)
	{
		atual.SetAlegria (atual.GetAlegria() + 0.1);
		AtualizaBarras();
    }
	void botaofome(object sender, EventArgs args)
	{
		atual.SetFome (atual.GetFome() + 0.1);
      
    }
    void PassouTempo()
	{
		var estavaMorto= atual.GetMorto();
	    atual.SetAlegria (atual.GetAlegria() - 0.1);
		atual.SetBanho (atual.GetBanho() - 0.1);
	    atual.SetFome (atual.GetFome() - 0.1);
		AtualizaBarras();
		if (estavaMorto !=atual.GetMorto())
		{
			fotosdogato.Source=atual.GetNomeDaFoto();
			botao.IsVisible=false;
			barras.IsVisible=false;
			timer.Stop();
		}
		
	}

}
