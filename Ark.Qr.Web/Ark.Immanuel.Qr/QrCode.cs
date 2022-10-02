using QRCoder;
using System.Drawing;

namespace Ark.Immanuel
{
    public class QrCode
    {
        public static void Generate()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
            ArtQRCode qrCode = new ArtQRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);
            qrCodeImage.MakeTransparent();
            qrCodeImage.Save("test1.png");
        }
    }
}