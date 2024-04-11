
namespace Jogogabisa;

public partial class gameoverPage: ContentPage
{
public gameoverPage()
	{
		InitializeComponent();
    }
    void recomeçarclicado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage();
        }
}