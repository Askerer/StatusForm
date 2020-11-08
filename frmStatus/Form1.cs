using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmStatus
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			InitStatus();

			Button btnInit = new Button();
			btnInit.Text = "INIT";
			btn_Status(btnInit, null);
		}

		public static string _status = "INIT";

		public void ActionMode()
		{
			this.btnAdd.Enabled = true;
			this.btnEdit.Enabled = true;
			this.btnCancel.Enabled = false;
			this.btnSave.Enabled = false;
			this.btnDel.Enabled = true;
			this.btnCopy.Enabled = true;

		}
		public void DesideMode()
		{
			this.btnAdd.Enabled = false;
			this.btnEdit.Enabled = false;
			this.btnCancel.Enabled = true;
			this.btnSave.Enabled = true;
			this.btnDel.Enabled = false;
			this.btnCopy.Enabled = false;
		}

		public void btn_Status(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			switch (btn.Text)
			{
				case "Add":
					DesideMode();
					break;
				case "Edit":
					DesideMode();
					break;
				case "Copy":
					DesideMode();
					break;
				case "Delete":
					DesideMode();
					break;
				case "Save":
					ActionMode();
					break;
				case "Cancel":
					ActionMode();
					break;
				default:
					ActionMode();
					break;

			}

		}


		public void InitStatus()
		{
			this.btnAdd.Click += new System.EventHandler(btn_Status);
			this.btnEdit.Click += new System.EventHandler(btn_Status);
			this.btnSave.Click += new System.EventHandler(btn_Status);
			this.btnCopy.Click += new System.EventHandler(btn_Status);
			this.btnCancel.Click += new System.EventHandler(btn_Status);
			this.btnDel.Click += new System.EventHandler(btn_Status);
		}


		private void btnAdd_Click(object sender, EventArgs e)
		{
			
		}
	}
}
