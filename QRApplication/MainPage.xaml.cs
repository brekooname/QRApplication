namespace QRApplication;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void OnQRGeniratPage(object sender, object args)
    {
        await Navigation.PushAsync(new QRGeniratPage());
    }
}

