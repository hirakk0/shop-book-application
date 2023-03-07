namespace BookManagementSystem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shopBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookReviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookOrderInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopBooksToolStripMenuItem,
            this.shopUserToolStripMenuItem,
            this.administratorsToolStripMenuItem,
            this.bookOrdersToolStripMenuItem,
            this.bookAuthorsToolStripMenuItem,
            this.systemExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shopBooksToolStripMenuItem
            // 
            this.shopBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.viewBookReviewsToolStripMenuItem});
            this.shopBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shopBooksToolStripMenuItem.Image")));
            this.shopBooksToolStripMenuItem.Name = "shopBooksToolStripMenuItem";
            this.shopBooksToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.shopBooksToolStripMenuItem.Text = "Shop Books";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBookToolStripMenuItem.Image")));
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // viewBookReviewsToolStripMenuItem
            // 
            this.viewBookReviewsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookReviewsToolStripMenuItem.Image")));
            this.viewBookReviewsToolStripMenuItem.Name = "viewBookReviewsToolStripMenuItem";
            this.viewBookReviewsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.viewBookReviewsToolStripMenuItem.Text = "View Book Reviews";
            this.viewBookReviewsToolStripMenuItem.Click += new System.EventHandler(this.viewBookReviewsToolStripMenuItem_Click);
            // 
            // shopUserToolStripMenuItem
            // 
            this.shopUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUserInformationToolStripMenuItem});
            this.shopUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shopUserToolStripMenuItem.Image")));
            this.shopUserToolStripMenuItem.Name = "shopUserToolStripMenuItem";
            this.shopUserToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.shopUserToolStripMenuItem.Text = "Shop Users";
            // 
            // viewUserInformationToolStripMenuItem
            // 
            this.viewUserInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewUserInformationToolStripMenuItem.Image")));
            this.viewUserInformationToolStripMenuItem.Name = "viewUserInformationToolStripMenuItem";
            this.viewUserInformationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewUserInformationToolStripMenuItem.Text = "View User Information";
            this.viewUserInformationToolStripMenuItem.Click += new System.EventHandler(this.viewUserInformationToolStripMenuItem_Click);
            // 
            // administratorsToolStripMenuItem
            // 
            this.administratorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAdministratorToolStripMenuItem});
            this.administratorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administratorsToolStripMenuItem.Image")));
            this.administratorsToolStripMenuItem.Name = "administratorsToolStripMenuItem";
            this.administratorsToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.administratorsToolStripMenuItem.Text = "Shop Administrators ";
            // 
            // addNewAdministratorToolStripMenuItem
            // 
            this.addNewAdministratorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewAdministratorToolStripMenuItem.Image")));
            this.addNewAdministratorToolStripMenuItem.Name = "addNewAdministratorToolStripMenuItem";
            this.addNewAdministratorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addNewAdministratorToolStripMenuItem.Text = "Add New Administrator";
            this.addNewAdministratorToolStripMenuItem.Click += new System.EventHandler(this.addNewAdministratorToolStripMenuItem_Click);
            // 
            // bookOrdersToolStripMenuItem
            // 
            this.bookOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBookOrderInformationToolStripMenuItem});
            this.bookOrdersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookOrdersToolStripMenuItem.Image")));
            this.bookOrdersToolStripMenuItem.Name = "bookOrdersToolStripMenuItem";
            this.bookOrdersToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.bookOrdersToolStripMenuItem.Text = "Shop Book Orders";
            // 
            // viewBookOrderInformationToolStripMenuItem
            // 
            this.viewBookOrderInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookOrderInformationToolStripMenuItem.Image")));
            this.viewBookOrderInformationToolStripMenuItem.Name = "viewBookOrderInformationToolStripMenuItem";
            this.viewBookOrderInformationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.viewBookOrderInformationToolStripMenuItem.Text = "View Book Order Information";
            this.viewBookOrderInformationToolStripMenuItem.Click += new System.EventHandler(this.viewBookOrderInformationToolStripMenuItem_Click);
            // 
            // bookAuthorsToolStripMenuItem
            // 
            this.bookAuthorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookAuthorToolStripMenuItem});
            this.bookAuthorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookAuthorsToolStripMenuItem.Image")));
            this.bookAuthorsToolStripMenuItem.Name = "bookAuthorsToolStripMenuItem";
            this.bookAuthorsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.bookAuthorsToolStripMenuItem.Text = "Book Authors";
            // 
            // addNewBookAuthorToolStripMenuItem
            // 
            this.addNewBookAuthorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBookAuthorToolStripMenuItem.Image")));
            this.addNewBookAuthorToolStripMenuItem.Name = "addNewBookAuthorToolStripMenuItem";
            this.addNewBookAuthorToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addNewBookAuthorToolStripMenuItem.Text = "Add New Book Author";
            this.addNewBookAuthorToolStripMenuItem.Click += new System.EventHandler(this.addNewBookAuthorToolStripMenuItem_Click);
            // 
            // systemExitToolStripMenuItem
            // 
            this.systemExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("systemExitToolStripMenuItem.Image")));
            this.systemExitToolStripMenuItem.Name = "systemExitToolStripMenuItem";
            this.systemExitToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.systemExitToolStripMenuItem.Text = "System Exit";
            this.systemExitToolStripMenuItem.Click += new System.EventHandler(this.systemExitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(828, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shopBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookOrderInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookReviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUserInformationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem systemExitToolStripMenuItem;
    }
}