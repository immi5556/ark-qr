// See https://aka.ms/new-console-template for more information
using Ark.Immanuel;
using System.Drawing.Drawing2D;
using System.Drawing;

Console.WriteLine("Hello, World!");

//QrCode.Generate();

static void Draw()
{
    Bitmap bmp = new Bitmap(700, 900);

    RectangleF rectf = new RectangleF(70, 90, 90, 50);

    Graphics g = Graphics.FromImage(bmp);

    g.SmoothingMode = SmoothingMode.AntiAlias;
    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
    g.DrawString("yourText", new Font("Tahoma", 8), Brushes.Black, rectf);

    g.Flush();
    bmp.Save("testp.png");
}

//Draw();