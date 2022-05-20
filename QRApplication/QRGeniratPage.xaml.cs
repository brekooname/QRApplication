namespace QRApplication;

public partial class QRGeniratPage : ContentPage
{
    private string link = null;
    public QRGeniratPage()
    {
        InitializeComponent();
    }

    void OnEntryChange(object sender, TextChangedEventArgs args)
    {
        link = args.NewTextValue;
    }

    async void ConvertToQR(object sender, object args)
    {
        try
        {
            if (link != null)
                await Navigation.PushAsync(new QRPage(link));
            else
                await DisplayAlert("Opps", "Insert the link!!!", "Ok");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"{ex.Message}", "Ok");
        }
    }
}