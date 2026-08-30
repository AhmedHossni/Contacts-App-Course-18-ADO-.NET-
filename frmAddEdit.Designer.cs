namespace Contacts_App__Course_18_ADO.NET_
{
    partial class frmAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEdit));
            this.labelMainLabel = new System.Windows.Forms.Label();
            this.labelContactID = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.tboxContactID = new System.Windows.Forms.TextBox();
            this.tboxFName = new System.Windows.Forms.TextBox();
            this.tboxLName = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            this.rtboxAddress = new System.Windows.Forms.RichTextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.pboxImg = new System.Windows.Forms.PictureBox();
            this.btnSetImg = new System.Windows.Forms.Button();
            this.btnDeleteImg = new System.Windows.Forms.Button();
            this.btnFormCancel = new System.Windows.Forms.Button();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.imgListMain = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMainLabel
            // 
            this.labelMainLabel.AutoSize = true;
            this.labelMainLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.labelMainLabel.Location = new System.Drawing.Point(274, 26);
            this.labelMainLabel.Name = "labelMainLabel";
            this.labelMainLabel.Size = new System.Drawing.Size(212, 28);
            this.labelMainLabel.TabIndex = 0;
            this.labelMainLabel.Text = "Add New Contact";
            // 
            // labelContactID
            // 
            this.labelContactID.AutoSize = true;
            this.labelContactID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactID.ForeColor = System.Drawing.Color.White;
            this.labelContactID.Location = new System.Drawing.Point(12, 93);
            this.labelContactID.Name = "labelContactID";
            this.labelContactID.Size = new System.Drawing.Size(100, 21);
            this.labelContactID.TabIndex = 1;
            this.labelContactID.Text = "Contact Id";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.ForeColor = System.Drawing.Color.White;
            this.labelFName.Location = new System.Drawing.Point(12, 145);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(102, 21);
            this.labelFName.TabIndex = 2;
            this.labelFName.Text = "First Name";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.ForeColor = System.Drawing.Color.White;
            this.labelLName.Location = new System.Drawing.Point(12, 197);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(100, 21);
            this.labelLName.TabIndex = 3;
            this.labelLName.Text = "Last Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(12, 249);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 21);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.White;
            this.labelPhone.Location = new System.Drawing.Point(12, 301);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(64, 21);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.ForeColor = System.Drawing.Color.White;
            this.labelCountry.Location = new System.Drawing.Point(12, 349);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(78, 21);
            this.labelCountry.TabIndex = 7;
            this.labelCountry.Text = "Country";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(12, 462);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(79, 21);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Address";
            // 
            // tboxContactID
            // 
            this.tboxContactID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tboxContactID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxContactID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxContactID.ForeColor = System.Drawing.Color.White;
            this.tboxContactID.Location = new System.Drawing.Point(143, 90);
            this.tboxContactID.Name = "tboxContactID";
            this.tboxContactID.ReadOnly = true;
            this.tboxContactID.Size = new System.Drawing.Size(340, 28);
            this.tboxContactID.TabIndex = 9;
            this.tboxContactID.Text = "??";
            // 
            // tboxFName
            // 
            this.tboxFName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxFName.ForeColor = System.Drawing.Color.Black;
            this.tboxFName.Location = new System.Drawing.Point(143, 136);
            this.tboxFName.Name = "tboxFName";
            this.tboxFName.Size = new System.Drawing.Size(269, 35);
            this.tboxFName.TabIndex = 10;
            // 
            // tboxLName
            // 
            this.tboxLName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxLName.ForeColor = System.Drawing.Color.Black;
            this.tboxLName.Location = new System.Drawing.Point(143, 188);
            this.tboxLName.Name = "tboxLName";
            this.tboxLName.Size = new System.Drawing.Size(269, 35);
            this.tboxLName.TabIndex = 11;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmail.ForeColor = System.Drawing.Color.Black;
            this.tboxEmail.Location = new System.Drawing.Point(143, 240);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(269, 35);
            this.tboxEmail.TabIndex = 12;
            // 
            // tboxPhone
            // 
            this.tboxPhone.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPhone.ForeColor = System.Drawing.Color.Black;
            this.tboxPhone.Location = new System.Drawing.Point(143, 292);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(269, 35);
            this.tboxPhone.TabIndex = 13;
            // 
            // rtboxAddress
            // 
            this.rtboxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtboxAddress.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.rtboxAddress.ForeColor = System.Drawing.Color.Black;
            this.rtboxAddress.Location = new System.Drawing.Point(143, 462);
            this.rtboxAddress.Name = "rtboxAddress";
            this.rtboxAddress.Size = new System.Drawing.Size(269, 136);
            this.rtboxAddress.TabIndex = 16;
            this.rtboxAddress.Text = "";
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.ForeColor = System.Drawing.Color.Black;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(143, 350);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(269, 24);
            this.cbCountry.TabIndex = 17;
            // 
            // pboxImg
            // 
            this.pboxImg.BackColor = System.Drawing.Color.White;
            this.pboxImg.Location = new System.Drawing.Point(541, 136);
            this.pboxImg.Name = "pboxImg";
            this.pboxImg.Size = new System.Drawing.Size(182, 238);
            this.pboxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImg.TabIndex = 19;
            this.pboxImg.TabStop = false;
            // 
            // btnSetImg
            // 
            this.btnSetImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSetImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetImg.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetImg.ForeColor = System.Drawing.Color.White;
            this.btnSetImg.Location = new System.Drawing.Point(541, 406);
            this.btnSetImg.Name = "btnSetImg";
            this.btnSetImg.Size = new System.Drawing.Size(95, 27);
            this.btnSetImg.TabIndex = 20;
            this.btnSetImg.Text = "Set Image";
            this.btnSetImg.UseVisualStyleBackColor = false;
            this.btnSetImg.Click += new System.EventHandler(this.btnSetImg_Click);
            // 
            // btnDeleteImg
            // 
            this.btnDeleteImg.BackColor = System.Drawing.Color.Red;
            this.btnDeleteImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteImg.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImg.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImg.Location = new System.Drawing.Point(645, 406);
            this.btnDeleteImg.Name = "btnDeleteImg";
            this.btnDeleteImg.Size = new System.Drawing.Size(78, 27);
            this.btnDeleteImg.TabIndex = 21;
            this.btnDeleteImg.Text = "Delete";
            this.btnDeleteImg.UseVisualStyleBackColor = false;
            this.btnDeleteImg.Click += new System.EventHandler(this.btnDeleteImg_Click);
            // 
            // btnFormCancel
            // 
            this.btnFormCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnFormCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFormCancel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormCancel.ForeColor = System.Drawing.Color.White;
            this.btnFormCancel.Location = new System.Drawing.Point(405, 620);
            this.btnFormCancel.Name = "btnFormCancel";
            this.btnFormCancel.Size = new System.Drawing.Size(78, 27);
            this.btnFormCancel.TabIndex = 23;
            this.btnFormCancel.Text = "Cancel";
            this.btnFormCancel.UseVisualStyleBackColor = false;
            this.btnFormCancel.Click += new System.EventHandler(this.btnFormCancel_Click);
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSaveContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveContact.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveContact.ForeColor = System.Drawing.Color.White;
            this.btnSaveContact.Location = new System.Drawing.Point(279, 620);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(78, 27);
            this.btnSaveContact.TabIndex = 22;
            this.btnSaveContact.Text = "Save";
            this.btnSaveContact.UseVisualStyleBackColor = false;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // imgListMain
            // 
            this.imgListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListMain.ImageStream")));
            this.imgListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListMain.Images.SetKeyName(0, "User Icon.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Address";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(143, 409);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(269, 24);
            this.dtpDateOfBirth.TabIndex = 25;
            // 
            // frmAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(760, 659);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFormCancel);
            this.Controls.Add(this.btnSaveContact);
            this.Controls.Add(this.btnDeleteImg);
            this.Controls.Add(this.btnSetImg);
            this.Controls.Add(this.pboxImg);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.rtboxAddress);
            this.Controls.Add(this.tboxPhone);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.tboxLName);
            this.Controls.Add(this.tboxFName);
            this.Controls.Add(this.tboxContactID);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelContactID);
            this.Controls.Add(this.labelMainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Contact";
            this.Shown += new System.EventHandler(this.frmAddEdit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainLabel;
        private System.Windows.Forms.Label labelContactID;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox tboxContactID;
        private System.Windows.Forms.TextBox tboxFName;
        private System.Windows.Forms.TextBox tboxLName;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxPhone;
        private System.Windows.Forms.RichTextBox rtboxAddress;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.PictureBox pboxImg;
        private System.Windows.Forms.Button btnSetImg;
        private System.Windows.Forms.Button btnDeleteImg;
        private System.Windows.Forms.Button btnFormCancel;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.ImageList imgListMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
    }
}