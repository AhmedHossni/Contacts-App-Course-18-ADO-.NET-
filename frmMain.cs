using ContactsBusinessLayer;
using System.Drawing;
using System.Windows.Forms;

namespace Contacts_App__Course_18_ADO.NET_
{
    public partial class frmMain : Form
    {
        private Point _point = new Point();
        public frmMain()
        {
            InitializeComponent();
            LoadDataInGridDataView();
            dgvContacts.Columns["CountryID"].Visible = false;

        }

        private void LoadDataInGridDataView()
        {
            dgvContacts.DataSource = clsContact.GetAllContacts();
        }

        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int CurrentRowId = GetAndSelectCurrentGridRowId();

            if (CurrentRowId != -1)
            {
                if (clsContact.DeleteContact(CurrentRowId))
                {
                    MessageBox.Show($"Contact with id ({CurrentRowId}) is deleted successfully",
                        "Important!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadDataInGridDataView();

                }
                else
                {
                    MessageBox.Show($"Faild in deleting contact with id ({CurrentRowId}) process",
                        "Faild!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddNewContact_Click(object sender, System.EventArgs e)
        {
            OpenAddEditForm(-1);
        }

        private void OpenAddEditForm(int id)
        {
            frmAddEdit frmAddEdit = new frmAddEdit(id);
            frmAddEdit.ShowDialog();
            LoadDataInGridDataView();
        }

        private int GetAndSelectCurrentGridRowId()
        {
            DataGridView.HitTestInfo hitInfo = dgvContacts.HitTest(_point.X, _point.Y);

            if (hitInfo.RowIndex != -1)
            {
                dgvContacts.ClearSelection();
                dgvContacts.Rows[hitInfo.RowIndex].Selected = true;
                dgvContacts.CurrentCell = dgvContacts.Rows[hitInfo.RowIndex].Cells[0];
                return (int)dgvContacts.CurrentCell.Value;
            }
            else
            {
                return -1;
            }

        }

        private void EditToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int CurrentRowId = GetAndSelectCurrentGridRowId();

            if (CurrentRowId != -1)
            {
                OpenAddEditForm(CurrentRowId);
            }
        }

        private void dgvContacts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _point = dgvContacts.PointToClient(Cursor.Position);
        }
    }
}
