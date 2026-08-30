using ContactBusinessLayer;
using ContactsBusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contacts_App__Course_18_ADO.NET_
{
    public partial class frmAddEdit : Form
    {
        private clsContact FormContact;

        public frmAddEdit(int contactID)
        {
            InitializeComponent();

            labelMainLabel.Dock = DockStyle.None;
            labelMainLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            FormContact = clsContact.Find(contactID);

            if(FormContact == null)
                FormContact = new clsContact();

            LoadFormData();

            HandleEmptyImg();
        }

        private void HandleEmptyImg()
        {
            if (string.IsNullOrEmpty(FormContact.ImagePath))
            {
                btnDeleteImg.Enabled = false;
                pboxImg.Image = imgListMain.Images[0];
            }
        }

        private void LoadFormData()
        {
            cbCountry.DataSource = clsCountry.GetAll();
            cbCountry.DisplayMember = "CountryName";

            if (FormContact.ID == -1)
            {
                tboxContactID.Text = "???";
            }
            else
            {
                labelMainLabel.Text = "Edit Contact";
                labelMainLabel.Left = 266;
                tboxContactID.Text = FormContact.ID.ToString();
                FormContact = clsContact.Find(FormContact.ID);

                if (FormContact != null)
                    LoadContactData(ref FormContact);
            }
        }

        public void LoadContactData(ref clsContact contact)
        {
            tboxContactID.Text = contact.ID.ToString();

            tboxFName.Text = contact.FirstName;

            tboxLName.Text = contact.LastName;

            tboxEmail.Text = contact.Email;

            tboxPhone.Text = contact.Phone;

            cbCountry.SelectedIndex = cbCountry.FindStringExact(clsCountry.FindBy(contact.CountryID).Name);

            rtboxAddress.Text = contact.Address;

            if(contact.ImagePath != "")
                pboxImg.Image = Image.FromFile(contact.ImagePath);
        }

        private void btnFormCancel_Click(object sender, EventArgs e) => this.Close();


        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            btnDeleteImg.Enabled = false;
            FormContact.ImagePath = "";
            pboxImg.Image = null;
        }

        private int ReturnCountryId()
        {
            clsCountry country = clsCountry.FindBy(cbCountry.Text);

            if (!(country is null))
                return country.Id;
            else 
                return -1;
        }

        private bool SaveFormContactInDB()
        {
            int OldValue = FormContact.CountryID;

            FormContact.CountryID = ReturnCountryId();
            FormContact.FirstName = tboxFName.Text;
            FormContact.LastName = tboxLName.Text;
            FormContact.Email = tboxEmail.Text;
            FormContact.Phone = tboxPhone.Text;
            FormContact.Address = rtboxAddress.Text;
            FormContact.DateOfBirth = dtpDateOfBirth.Value;

            if (FormContact.Save())
            {
                LoadFormData();

                return true;
            }
            else
            {

                FormContact.CountryID = OldValue;
                LoadFormData();
                return false;
            }
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            if (SaveFormContactInDB())
            {
                MessageBox.Show("Contact data saved successfully", "Important!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                labelMainLabel.Text = "Edit Contact";
                labelMainLabel.Left = 266;
            }
            else
            {
                MessageBox.Show("Faild in saving contact data process",
                    "Faild!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            LoadFormData();

        }

        private void btnSetImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Image";

                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                string oldImagePath = FormContact.ImagePath;

                if (!string.IsNullOrEmpty(oldImagePath) && System.IO.File.Exists(oldImagePath))
                {
                    string oldDirectory = System.IO.Path.GetDirectoryName(oldImagePath);

                    openFileDialog.InitialDirectory = oldDirectory;

                    openFileDialog.CheckFileExists = true;
                    openFileDialog.CheckPathExists = true;
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FormContact.ImagePath = openFileDialog.FileName;
                    
                    MessageBox.Show("Image is selected successfully\nImage Path : " + FormContact.ImagePath,
                        "Selected Image",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    pboxImg.Image = Image.FromFile(FormContact.ImagePath);
                }
            }
        }

        private void frmAddEdit_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
