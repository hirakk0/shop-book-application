namespace BookManagementSystem
{
    partial class userForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shopBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShopBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookReviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookOrderInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInformationBookAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 344);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopBooksToolStripMenuItem,
            this.bookOrdersToolStripMenuItem,
            this.bookAuthorsToolStripMenuItem,
            this.systemExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 26);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shopBooksToolStripMenuItem
            // 
            this.shopBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewShopBooksToolStripMenuItem,
            this.viewBookReviewsToolStripMenuItem});
            this.shopBooksToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shopBooksToolStripMenuItem.Image")));
            this.shopBooksToolStripMenuItem.Name = "shopBooksToolStripMenuItem";
            this.shopBooksToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.shopBooksToolStripMenuItem.Text = "Shop Books";
            // 
            // viewShopBooksToolStripMenuItem
            // 
            this.viewShopBooksToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Underline);
            this.viewShopBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewShopBooksToolStripMenuItem.Image")));
            this.viewShopBooksToolStripMenuItem.Name = "viewShopBooksToolStripMenuItem";
            this.viewShopBooksToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.viewShopBooksToolStripMenuItem.Text = "View Store Books Catalog";
            this.viewShopBooksToolStripMenuItem.Click += new System.EventHandler(this.viewShopBooksToolStripMenuItem_Click);
            // 
            // viewBookReviewsToolStripMenuItem
            // 
            this.viewBookReviewsToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookReviewsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookReviewsToolStripMenuItem.Image")));
            this.viewBookReviewsToolStripMenuItem.Name = "viewBookReviewsToolStripMenuItem";
            this.viewBookReviewsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.viewBookReviewsToolStripMenuItem.Text = "View Reviews Store Books";
            this.viewBookReviewsToolStripMenuItem.Click += new System.EventHandler(this.viewBookReviewsToolStripMenuItem_Click);
            // 
            // bookOrdersToolStripMenuItem
            // 
            this.bookOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBookOrderInformationToolStripMenuItem});
            this.bookOrdersToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookOrdersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookOrdersToolStripMenuItem.Image")));
            this.bookOrdersToolStripMenuItem.Name = "bookOrdersToolStripMenuItem";
            this.bookOrdersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.bookOrdersToolStripMenuItem.Text = "Book Shopping System";
            // 
            // viewBookOrderInformationToolStripMenuItem
            // 
            this.viewBookOrderInformationToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Underline);
            this.viewBookOrderInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookOrderInformationToolStripMenuItem.Image")));
            this.viewBookOrderInformationToolStripMenuItem.Name = "viewBookOrderInformationToolStripMenuItem";
            this.viewBookOrderInformationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewBookOrderInformationToolStripMenuItem.Text = "Make Book Order";
            this.viewBookOrderInformationToolStripMenuItem.Click += new System.EventHandler(this.viewBookOrderInformationToolStripMenuItem_Click);
            // 
            // bookAuthorsToolStripMenuItem
            // 
            this.bookAuthorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInformationBookAuthorsToolStripMenuItem});
            this.bookAuthorsToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookAuthorsToolStripMenuItem.Image")));
            this.bookAuthorsToolStripMenuItem.Name = "bookAuthorsToolStripMenuItem";
            this.bookAuthorsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bookAuthorsToolStripMenuItem.Text = "Book Authors [Information]";
            // 
            // viewInformationBookAuthorsToolStripMenuItem
            // 
            this.viewInformationBookAuthorsToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Underline);
            this.viewInformationBookAuthorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewInformationBookAuthorsToolStripMenuItem.Image")));
            this.viewInformationBookAuthorsToolStripMenuItem.Name = "viewInformationBookAuthorsToolStripMenuItem";
            this.viewInformationBookAuthorsToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.viewInformationBookAuthorsToolStripMenuItem.Text = "View Information About Book Writers";
            this.viewInformationBookAuthorsToolStripMenuItem.Click += new System.EventHandler(this.viewInformationBookAuthorsToolStripMenuItem_Click);
            // 
            // systemExitToolStripMenuItem
            // 
            this.systemExitToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("systemExitToolStripMenuItem.Image")));
            this.systemExitToolStripMenuItem.Name = "systemExitToolStripMenuItem";
            this.systemExitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.systemExitToolStripMenuItem.Text = "SIGN OUT";
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 369);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "userForm";
            this.Text = "Welcome to System - User Mode [BookManagmentSystemApplication] - Book Order Histo" +
    "ry";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shopBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewShopBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookReviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookOrderInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInformationBookAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemExitToolStripMenuItem;
    }
}