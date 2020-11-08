namespace frmStatus
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.palbutton = new System.Windows.Forms.Panel();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.palbutton.SuspendLayout();
			this.SuspendLayout();
			// 
			// palbutton
			// 
			this.palbutton.Controls.Add(this.btnDel);
			this.palbutton.Controls.Add(this.btnAdd);
			this.palbutton.Controls.Add(this.btnCopy);
			this.palbutton.Controls.Add(this.btnSave);
			this.palbutton.Controls.Add(this.btnCancel);
			this.palbutton.Controls.Add(this.btnEdit);
			this.palbutton.Location = new System.Drawing.Point(175, 12);
			this.palbutton.Name = "palbutton";
			this.palbutton.Size = new System.Drawing.Size(564, 78);
			this.palbutton.TabIndex = 0;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(98, 19);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 40);
			this.btnEdit.TabIndex = 0;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(474, 19);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 40);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(381, 19);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 40);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(190, 19);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 40);
			this.btnCopy.TabIndex = 3;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(7, 19);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 40);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(285, 19);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(75, 40);
			this.btnDel.TabIndex = 5;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.palbutton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.palbutton.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel palbutton;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnEdit;
	}
}

