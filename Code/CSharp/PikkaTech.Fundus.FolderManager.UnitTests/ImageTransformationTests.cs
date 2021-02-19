using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PikkaTech.Fundus.FolderManager.WinForms;
using System.IO;
using System.Security.AccessControl;

namespace PikkaTech.Fundus.FolderManager.UnitTests
{
	[TestFixture]
	public class ImageTransformationTests
	{

		[Test]
		public void SvgToPng_LocalFolder_ValidSize_Succeeds()
		{
			File.Delete("Solution.png");
		}

		[Test]
		public void SvgToPng_RoamingFolder_ValidSize_Succeeds()
		{
			Assert.Fail("Not yet implemented");
		}

		[Test]
		public void SvgToPng_LocalFolder_InvalidSize_ThrowsExceptions()
		{
			Assert.Fail("Not yet implemented");
		}

		[Test]
		public void SvgToPng_RoamingFolder_InvalidSize_ThrowsExceptions()
		{
			Assert.Fail("Not yet implemented");
		}

		[Test]
		public void PngToIco_LocalFolder_ValidSizes_Succeeds()
		{
			Assert.Fail("Not yet implemented");
		}

		[Test]
		public void PngToIco_RoamingFolder_ValidSizes_Succeeds()
		{
			Assert.Fail("Not yet implemented");
		}

		[Test]
		public void PngToIco_LocalFolder_InvalidSizes_ThrowsException()
		{
			Assert.Fail("Not yet implemented");
		}

		[Test]
		public void PngToIco_RoamingFolder_InvalidSizes_ThrowsException()
		{
			Assert.Fail("Not yet implemented");
		}
	}
}
