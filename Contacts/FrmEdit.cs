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
    public partial class FrmEdit : Form
    {
        IContacts contact;
        public int contactId = 0;
        public FrmEdit()
        {
            InitializeComponent();
            contact = new Contacts();
        }

        private void btnAddSubmit_Click(object sender, EventArgs e)
        {
            if (ValidationAdd())
            {
                if (contactId == 0)
                {
                    bool isSuccsess = contact.Insert(txtName.Text, txtFamily.Text, txtNumber.Text, (int)txtAge.Value, txtAddress.Text);


                    if (isSuccsess)
                    {
                        MessageBox.Show("عملیات با موفقیت انجام شد");
                        DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show("عملیات با شکست مواجه شد");
                    }
                }
                else
                {
                    bool isSuccsess = contact.Update((int)contactId, txtName.Text, txtFamily.Text, txtNumber.Text, (int)txtAge.Value, txtAddress.Text);
                    if (isSuccsess)
                    {
                        MessageBox.Show("عملیات با موفقیت انجام شد");
                        DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show("عملیات با شکست مواجه شد");
                    }
                }
            }

        }
        bool ValidationAdd()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("نام را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (txtFamily.Text == "")
            {
                MessageBox.Show("نام خانوادگی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (txtAge.Value == 0)
            {
                MessageBox.Show("سن را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }


            if (txtNumber.Text == "")
            {
                MessageBox.Show("شماره تماس را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            if (contactId == 0)
            {
                this.Text = "افزودن شخص جدید";

            }
            else
            {
                this.Text = "ویرایش";
                DataTable dt = contact.SelectRow(contactId);
                txtName.Text = dt.Rows[0][1].ToString();
                txtFamily.Text = dt.Rows[0][2].ToString();
                txtNumber.Text = dt.Rows[0][3].ToString();
                txtAge.Text = dt.Rows[0][4].ToString();
                txtAddress.Text = dt.Rows[0][5].ToString();
                btnAddSubmit.Text = "ویرایش";


            }


        }
    }
}
