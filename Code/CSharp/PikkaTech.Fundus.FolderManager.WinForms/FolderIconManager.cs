/**********************************************************************************************
* File:         FolderIconManager.cs                                                          *
* Contents:     Class FolderIconManager                                                       *
* Author:       Alex Konnen (info@pikkatech.eu)                                               *
* Date:         2014-06-17 12:36                                                              *
* Version:      1.0                                                                           *
* Copyright:    PikkaTech Development and Consulting (www.pikkatech.eu)                       *
**********************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace PikkaTech.Fundus.PikkaBase.FileSystem
{
	/// <summary>
	/// 
	/// </summary>
	public static class FolderIconManager
	{
		/// <summary>
		/// Creates a multisize icon file from a bitmap file.
		/// </summary>
		/// <param name="bitmapFileName">Name of the bitmap file.</param>
		/// <param name="sizes">List of sizes to create in the icon file.</param>
		/// <param name="iconFileName">Icon file name to create.</param>
		public static void CreateIcon(string bitmapFileName, int[] sizes, string iconFileName)
		{
			Bitmap bitmap						= (Bitmap)Image.FromFile(bitmapFileName);

			// Thread.Sleep(1500);

			List<string> lstThumbnailFileNames	= new List<string>();

			for (int i = 0; i < sizes.Length; i++)
			{
				Image thumbnail					= bitmap.GetThumbnailImage(sizes[i], sizes[i], GetThumbnailImageAbortDummy, IntPtr.Zero);
				string thumbnailFileName		= String.Format("thumbnail_{0}.png", sizes[i]);
				lstThumbnailFileNames.Add(thumbnailFileName);
				thumbnail.Save(thumbnailFileName);
			}
			
			// Thread.Sleep(1500);

			ProcessStartInfo	psi	= new ProcessStartInfo();
			psi.FileName			= "png2ico.exe";
			psi.Arguments			= String.Format("{0} ", iconFileName);

			foreach (string arg in lstThumbnailFileNames)
			{
				psi.Arguments		+= String.Format("{0} ", arg);
			}

			Process p				= new Process();
			p.StartInfo				= psi;

			p.Start();
			p.WaitForExit();

			// delete thumbnail files
			foreach (string thumbnailFilename in lstThumbnailFileNames)
			{
			    File.Delete(thumbnailFilename);
			}
		}

		/// <summary>
		/// Assigns an icon file to a folder.
		/// </summary>
		/// <param name="folder">Folder full name</param>
		/// <param name="iconFile">Icon full name.</param>
		public static bool AssignIcon(string folder, string iconFile, string infoTip)
		{
			EvanStone.FolderIcons.FolderIcon folderIcon	= new EvanStone.FolderIcons.FolderIcon(folder);
			folderIcon.CreateFolderIcon(iconFile, infoTip);

			return true;
		}

		public static bool AssignIcon(string folder, string iconFile)
		{
			return AssignIcon(folder, iconFile, "");
		}

		#region Private auxiliary
		private static bool GetThumbnailImageAbortDummy()
		{
			return true;
		}
		#endregion
	}
}
