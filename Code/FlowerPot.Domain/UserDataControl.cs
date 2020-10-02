using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerPot.Domain
{
	public partial class UserDataControl : UserControl
	{
		public UserDataControl()
		{
			InitializeComponent();
		}

		public UserData UserData
		{
			get
			{
				try
				{
					UserData userData		= new UserData();

					userData.AuthorName		= this._txAuthorName.Text;
					userData.AuthorEmail	= this._txAuthorEmail.Text;
					userData.CompanyName	= this._txCompanyName.Text;
					userData.CompanyWebsite	= this._txCompanyWebsite.Text;

					try
					{
						userData.HeaderWidth	= Int32.Parse(this._txHeaderWidth.Text);
					}
					catch {}

					return userData;
				}
				catch
				{
					return null;
				}
			}

			set
			{
				this._txAuthorName.Text			= value.AuthorName;
				this._txAuthorEmail.Text		= value.AuthorEmail;
				this._txCompanyName.Text		= value.CompanyName;
				this._txCompanyWebsite.Text		= value.CompanyWebsite;

				this._txHeaderWidth.Text		= value.HeaderWidth.ToString();
			}
		}
	}
}
