using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.IO;

namespace PikkaTech.Fundus.FolderManager.WinForms
{
	/// <summary>
	/// Source: http://stackoverflow.com/questions/58910/converting-svg-to-png-using-c-sharp
	/// (stevenvh)
	/// </summary>
	public static class SvgToPngConverter
	{
		#region Interop
		[DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetDllDirectory(string pathname);

        [DllImport("libgobject-2.0-0.dll", SetLastError = true)]
        static extern void g_type_init(); 

        [DllImport("librsvg-2-2.dll", SetLastError = true)]
        static extern IntPtr rsvg_pixbuf_from_file_at_size(string file_name, int width, int height, out IntPtr error);

        //[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool gdk_pixbuf_save(IntPtr pixbuf, string filename, string type, out IntPtr error, __arglist);

		[DllImport("libgobject-2.0-0.dll", SetLastError = true)]
		static extern void g_object_unref(IntPtr obj);
		#endregion

		public static void RasterizeSvg(string inputFileName, string outputFileName, int width, int height)
        {
            bool callSuccessful = SetDllDirectory("C:\\Program Files\\GIMP-2.0\\bin");

            if (!callSuccessful)
            {
                throw new Exception("Could not set DLL directory");
            }

            g_type_init();

            IntPtr error;
            IntPtr result = rsvg_pixbuf_from_file_at_size(inputFileName, width, height, out error);

            if (error != IntPtr.Zero)
            {
                throw new Exception(Marshal.ReadInt32(error).ToString());
            }

            callSuccessful = gdk_pixbuf_save(result, outputFileName, "png", out error, __arglist(null));

			g_object_unref(result);

            if (!callSuccessful)
            {
                throw new Exception(error.ToInt32().ToString());
            }
        }

		public static Image SvgToImage(string inputFileName, int width, int height)
		{
			string tempFile	= FolderManagerForm.s_strThisAppDataFolder + "\\" + Guid.NewGuid().ToString().Replace("-", "") + ".png";
			RasterizeSvg(inputFileName, tempFile, width, height);

			Image image		= Image.FromFile(tempFile);

			File.Delete(tempFile);

			return image;
		}
	}
}
