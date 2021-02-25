using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        IContacts contacts;
        public Form1()
        {
            InitializeComponent();
            contacts = new Contacts();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgContacts.AutoGenerateColumns = false;
            dgContacts.DataSource = contacts.SelectAll();
            dgContacts.Columns[0].Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEdit frm = new FrmEdit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                string Name = dgContacts.CurrentRow.Cells[1].Value.ToString();
                string Family = dgContacts.CurrentRow.Cells[2].Value.ToString();
                string FullName = Name + Family;
                string question = "آیا مطمین به حذف " + FullName + " هستید؟";

                if (MessageBox.Show(question, "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                    bool is_success = contacts.Delete(contactId);
                    if (is_success)
                    {
                        MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("عملیات با شکست مواجه شد", "شکست", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    BindGrid();

                }

            }
            else
            {
                MessageBox.Show("لطفا سطری را انتخاب کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                FrmEdit frmEdit = new FrmEdit();
                frmEdit.contactId = contactId;
                frmEdit.ShowDialog();
                if (frmEdit.DialogResult == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا سطری را انتخاب کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string parameters = txtSearch.Text;
            dgContacts.DataSource = contacts.Search(parameters); 
        }


    }
}
