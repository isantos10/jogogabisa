namespace Jogogabisa;

public partial class MainPage : ContentPage
{
	Aime aime;
	Theo theo;
    Liz  liz;
	Gatinhos atual;

	public MainPage()
	{
		InitializeComponent();
		aime = new Aime();
		theo = new Theo();
        liz  = new Liz();
		atual = aime;
		fotosdogato.Source= atual.GetNomeDaFoto();
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
	}

	void AtualizaBarras()
	{
		progressoFome.Progress=atual.GetFome();
		progressoBanho.Progress=atual.GetBanho();
		progressoFeliz.Progress=atual.GetAlegria();
	}
	void botaobanho(object sender, EventArgs args)
	{
		atual.SetBanho (atual.GetBanho() + 0,1);
		
}

