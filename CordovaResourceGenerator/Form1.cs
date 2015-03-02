using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CordovaResourceGenerator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void generateBtn_Click(object sender, EventArgs e)
		{
			Directory.CreateDirectory(destinationPath.Text + @"\res\icons\android\");
			Directory.CreateDirectory(destinationPath.Text + @"\res\icons\ios\");
			Directory.CreateDirectory(destinationPath.Text + @"\res\icons\windows\");
			Directory.CreateDirectory(destinationPath.Text + @"\res\icons\wp8\");
			Directory.CreateDirectory(destinationPath.Text + @"\res\screens\android\");
			Directory.CreateDirectory(destinationPath.Text + @"\res\screens\ios\");
			Directory.CreateDirectory(destinationPath.Text + @"\res\screens\windows\");
			Directory.CreateDirectory(destinationPath.Text + @"\res\screens\wp8\");

			List<CordovaRes> resources = new List<CordovaRes>();
			//ANDROID ICONS
			resources.Add(new CordovaRes { Width = 36, Height = 36, Path = @"\res\icons\android\icon-36-ldpi.png" });
			resources.Add(new CordovaRes { Width = 48, Height = 48, Path = @"\res\icons\android\icon-48-mdpi.png" });
			resources.Add(new CordovaRes { Width = 72, Height = 72, Path = @"\res\icons\android\icon-72-hdpi.png" });
			resources.Add(new CordovaRes { Width = 96, Height = 96, Path = @"\res\icons\android\icon-96-xhdpi.png" });

			//ANDROID SCREENS
			resources.Add(new CordovaRes { Width = 960, Height = 720, Path = @"\res\screens\android\screen-xhdpi-landscape.png" });
			resources.Add(new CordovaRes { Width = 720, Height = 960, Path = @"\res\screens\android\screen-xhdpi-portrait.png" });
			resources.Add(new CordovaRes { Width = 640, Height = 480, Path = @"\res\screens\android\screen-hdpi-landscape.png" });
			resources.Add(new CordovaRes { Width = 480, Height = 640, Path = @"\res\screens\android\screen-hdpi-portrait.png" });
			resources.Add(new CordovaRes { Width = 470, Height = 320, Path = @"\res\screens\android\screen-mdpi-landscape.png" });
			resources.Add(new CordovaRes { Width = 320, Height = 470, Path = @"\res\screens\android\screen-mdpi-portrait.png" });
			resources.Add(new CordovaRes { Width = 426, Height = 320, Path = @"\res\screens\android\screen-ldpi-landscape.png" });
			resources.Add(new CordovaRes { Width = 320, Height = 426, Path = @"\res\screens\android\screen-ldpi-portrait.png" });

			//IOS ICONS
			resources.Add(new CordovaRes { Width = 114, Height = 114, Path = @"\res\icons\ios\icon-57-2x.png" });
			resources.Add(new CordovaRes { Width = 57, Height = 57, Path = @"\res\icons\ios\icon-57.png" });
			resources.Add(new CordovaRes { Width = 144, Height = 144, Path = @"\res\icons\ios\icon-72-2x.png" });
			resources.Add(new CordovaRes { Width = 72, Height = 72, Path = @"\res\icons\ios\icon-72.png" });
			resources.Add(new CordovaRes { Width = 40, Height = 40, Path = @"\res\icons\ios\icon-40.png" });
			resources.Add(new CordovaRes { Width = 80, Height = 80, Path = @"\res\icons\ios\icon-40-2x.png" });
			resources.Add(new CordovaRes { Width = 50, Height = 50, Path = @"\res\icons\ios\icon-50.png" });
			resources.Add(new CordovaRes { Width = 100, Height = 100, Path = @"\res\icons\ios\icon-50-2x.png" });
			resources.Add(new CordovaRes { Width = 60, Height = 60, Path = @"\res\icons\ios\icon-60.png" });
			resources.Add(new CordovaRes { Width = 120, Height = 120, Path = @"\res\icons\ios\icon-60-2x.png" });
			resources.Add(new CordovaRes { Width = 180, Height = 180, Path = @"\res\icons\ios\icon-60-3x.png" });
			resources.Add(new CordovaRes { Width = 76, Height = 76, Path = @"\res\icons\ios\icon-76.png" });
			resources.Add(new CordovaRes { Width = 152, Height = 152, Path = @"\res\icons\ios\icon-76-2x.png" });
			resources.Add(new CordovaRes { Width = 29, Height = 29, Path = @"\res\icons\ios\icon-small.png" });
			resources.Add(new CordovaRes { Width = 58, Height = 58, Path = @"\res\icons\ios\icon-small-2x.png" });

			//IOS SCREENS
			resources.Add(new CordovaRes { Width = 1024, Height = 768, Path = @"\res\screens\ios\screen-ipad-landscape.png" });
			resources.Add(new CordovaRes { Width = 2048, Height = 1536, Path = @"\res\screens\ios\screen-ipad-landscape-2x.png" });
			resources.Add(new CordovaRes { Width = 768, Height = 1024, Path = @"\res\screens\ios\screen-ipad-portrait.png" });
			resources.Add(new CordovaRes { Width = 1536, Height = 2048, Path = @"\res\screens\ios\screen-ipad-portrait-2x.png" });
			resources.Add(new CordovaRes { Width = 640, Height = 1136, Path = @"\res\screens\ios\screen-iphone-568h-2x.png" });
			resources.Add(new CordovaRes { Width = 2208, Height = 1242, Path = @"\res\screens\ios\screen-iphone-landscape-736h.png" });
			resources.Add(new CordovaRes { Width = 320, Height = 480, Path = @"\res\screens\ios\screen-iphone-portrait.png" });
			resources.Add(new CordovaRes { Width = 640, Height = 960, Path = @"\res\screens\ios\screen-iphone-portrait-2x.png" });
			resources.Add(new CordovaRes { Width = 750, Height = 1134, Path = @"\res\screens\ios\screen-iphone-portrait-667h.png" });
			resources.Add(new CordovaRes { Width = 1242, Height = 2208, Path = @"\res\screens\ios\screen-iphone-portrait-736h.png" });

			//WINDOWS 8 ICONS
			resources.Add(new CordovaRes { Width = 62, Height = 62, Path = @"\res\icons\wp8\ApplicationIcon.png" });
			resources.Add(new CordovaRes { Width = 173, Height = 173, Path = @"\res\icons\wp8\Background.png" });

			//WINDOWS 8 SCREENS
			resources.Add(new CordovaRes { Width = 480, Height = 800, Path = @"\res\screens\wp8\SplashScreenImage.png" });

			//WINDOWS 8.1 ICONS
			resources.Add(new CordovaRes { Width = 30, Height = 30, Path = @"\res\icons\windows\Square30x30Logo.scale-100.png" });
			resources.Add(new CordovaRes { Width = 106, Height = 106, Path = @"\res\icons\windows\Square44x44Logo.scale-240.png" });
			resources.Add(new CordovaRes { Width = 70, Height = 70, Path = @"\res\icons\windows\Square70x70Logo.scale-100.png" });
			resources.Add(new CordovaRes { Width = 170, Height = 170, Path = @"\res\icons\windows\Square71x71Logo.scale-240.png" });
			resources.Add(new CordovaRes { Width = 150, Height = 150, Path = @"\res\icons\windows\Square150x150Logo.scale-100.png" });
			resources.Add(new CordovaRes { Width = 360, Height = 360, Path = @"\res\icons\windows\Square150x150Logo.scale-240.png" });
			resources.Add(new CordovaRes { Width = 310, Height = 310, Path = @"\res\icons\windows\Square310x310Logo.scale-100.png" });
			resources.Add(new CordovaRes { Width = 50, Height = 50, Path = @"\res\icons\windows\StoreLogo.scale-100.png" });
			resources.Add(new CordovaRes { Width = 120, Height = 120, Path = @"\res\icons\windows\StoreLogo.scale-240.png" });
			resources.Add(new CordovaRes { Width = 310, Height = 150, Path = @"\res\icons\windows\Wide310x150Logo.scale-100.png" });
			resources.Add(new CordovaRes { Width = 744, Height = 360, Path = @"\res\icons\windows\Wide310x150Logo.scale-240.png" });

			//WINDOWS 8.1 SCREENS
			resources.Add(new CordovaRes { Width = 620, Height = 300, Path = @"\res\screens\windows\SplashScreen.scale-100.png" });
			resources.Add(new CordovaRes { Width = 1152, Height = 1920, Path = @"\res\screens\windows\SplashScreen.scale-240.png" });
			resources.Add(new CordovaRes { Width = 1152, Height = 1920, Path = @"\res\screens\windows\SplashScreenPhone.scale-240.png" });

			Image logo = Image.FromFile(logoPath.Text, true);

			foreach (CordovaRes res in resources)
			{
				int Width = res.Width;
				int Height = res.Height;

				int logoWidth = logo.Width;
				int logoHeight = logo.Height;
				int logoX = 0;
				int logoY = 0;
				int destX = 0;
				int destY = 0;

				float nPercent = 0;
				float nPercentW = 0;
				float nPercentH = 0;

				nPercentW = ((float)Width / (float)logoWidth);
				nPercentH = ((float)Height / (float)logoHeight);

				if (nPercentH < nPercentW)
				{
					nPercent = nPercentH;
					destX = System.Convert.ToInt16((Width - (logoWidth * nPercent)) / 2);
				}
				else
				{
					nPercent = nPercentW;
					destY = System.Convert.ToInt16((Height - (logoHeight * nPercent)) / 2);
				}

				int destWidth = (int)(logoWidth * nPercent);
				int destHeight = (int)(logoHeight * nPercent);

				Bitmap bmPhoto = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
				bmPhoto.SetResolution(logo.HorizontalResolution, logo.VerticalResolution);

				Graphics grPhoto = Graphics.FromImage(bmPhoto);
				grPhoto.Clear(color.BackColor);
				grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

				grPhoto.DrawImage(logo, new Rectangle(destX, destY, destWidth, destHeight), new Rectangle(logoX, logoY, logoWidth, logoHeight), GraphicsUnit.Pixel);

				grPhoto.Dispose();

				bmPhoto.Save(destinationPath.Text + res.Path, ImageFormat.Png);

				bmPhoto.Dispose();
			}

			MessageBox.Show("Cordova Resource Generation Complete");
		}

		private void colorBtn_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			// Allows the user from selecting a custom color.
			colorDialog.AllowFullOpen = true;
			// Allows the user to get help. (The default is false.)
			colorDialog.ShowHelp = true;
			// Sets the initial color select to the current text color.
			colorDialog.Color = Color.Black;

			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				color.BackColor = colorDialog.Color;
			}
		}

		private void destinationBtn_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();

			if (openFolderDialog.ShowDialog() == DialogResult.OK)
			{
				destinationPath.Text = openFolderDialog.SelectedPath;
			}
		}

		private void logoBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "PNG Files (*.png)|*.png";
			openFileDialog.Multiselect = false;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				logoPath.Text = openFileDialog.FileName;
			}
		}
	}
}
