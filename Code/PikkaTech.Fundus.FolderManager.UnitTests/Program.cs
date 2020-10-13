using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PikkaTech.Fundus.FolderManager.UnitTests
{
	class Program
	{

		private static Bitmap ResizeBitmap(Bitmap bmpSource, int width, int height)
		{
			Bitmap result = new Bitmap(width, height);

			using (Graphics g = Graphics.FromImage(result))
			{
				g.DrawImage(bmpSource, 0, 0, width, height);
			}

			return result;
		}

		static void Main(string[] args)
		{
			//Bitmap bmpSource	= (Bitmap)Image.FromFile("Solution_00.png");
			//Bitmap bmp			= ResizeBitmap(bmpSource, 64, 64);
			//bmp.Save("Solution_64.png");

			//SvgDocument sampleDoc = SvgDocument.Open(@"Solution.svg");
			//sampleDoc.Width = 1000;
			//sampleDoc.Height = 1000;
			//Bitmap bmp	= sampleDoc.Draw();
			//bmp.Save(@".\sample.png");
		}
	}
}
