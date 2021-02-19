using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Svg;
using System.Drawing.Drawing2D;

namespace PikkaTech.Fundus.FolderManager.WinForms
{
	public static class SvgConverter
	{
		public static Image Convert(SvgDocument svg, int width, int height)
		{
			Bitmap bmp	= svg.Draw();
			int size	= Math.Max(width, height);
			// return bmp.GetThumbnailImage(size, size, delegate() {return false;}, IntPtr.Zero);
			Bitmap dst	= ResizeBitmap(bmp, size, size);

			return dst;
		}

		public static Bitmap Convert(SvgDocument svg)
		{
			return svg.Draw();
		}

		private static Bitmap ResizeBitmap(Bitmap bmpSource, int width, int height)
		{
			Bitmap result = new Bitmap(width, height);

			using (Graphics g = Graphics.FromImage(result))
			{
				g.DrawImage(bmpSource, 0, 0, width, height);
			}

			return result;
		}
	}
}
