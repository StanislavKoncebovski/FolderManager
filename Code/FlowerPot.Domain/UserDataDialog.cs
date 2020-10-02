using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlowerPot.Domain
{
	public partial class UserDataDialog : Form
	{
		public UserDataDialog()
		{
			InitializeComponent();
		}

		public UserData UserData
		{
			get
			{
				return this._ctrlUserData.UserData;
			}

			set
			{
				this._ctrlUserData.UserData = value;
			}
		}
	}
}
