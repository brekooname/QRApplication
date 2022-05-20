using Net.ConnectCode.BarcodeFontsStandard2D;

namespace QRApplication;

public partial class QRPage : ContentPage
{
    public QRPage(string qr)
    {
        InitializeComponent();

        QR qrcode = new QR(qr, "M", 0);
        QRCodeBarcode.Text = qrcode.Encode();
    }
}