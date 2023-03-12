using System;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void systemExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewShopBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBookForm form5 = new addBookForm();
            form5.ShowDialog();
        }

        private void viewBookReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reviewBookForm form6 = new reviewBookForm();
            form6.ShowDialog();
        }

        private void viewUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserForm form13 = new addUserForm();
            form13.ShowDialog();
        }

        private void addNewAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAdminForm form8 = new addAdminForm();
            form8.ShowDialog();
        }

        private void addNewBookAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAuthorForm form12 = new addAuthorForm();
            form12.ShowDialog();
        }

        private void viewBookOrderInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
