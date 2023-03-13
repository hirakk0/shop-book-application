namespace BookManagementSystem
{
    partial class makeReviewsBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(makeReviewsBookForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shopBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShopBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1.Location = new System.Drawing.Point(254, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 323);
            this.dataGridView1.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Enter Your Commentary :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Enter Book Rating [ 0 to 100 ] :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Enter Book ID :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 123);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 137);
            this.textBox3.TabIndex = 67;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 20);
            this.textBox2.TabIndex = 66;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 86);
            this.button1.TabIndex = 71;
            this.button1.Text = "POST COMMENTARY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopBooksToolStripMenuItem,
            this.bookAuthorsToolStripMenuItem,
            this.systemExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 26);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shopBooksToolStripMenuItem
            // 
            this.shopBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewShopBooksToolStripMenuItem});
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
            this.viewShopBooksToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.viewShopBooksToolStripMenuItem.Text = "View Store Books Catalog";
            this.viewShopBooksToolStripMenuItem.Click += new System.EventHandler(this.viewShopBooksToolStripMenuItem_Click);
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
            this.systemExitToolStripMenuItem.Click += new System.EventHandler(this.systemExitToolStripMenuItem_Click);
            // 
            // makeReviewsBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 358);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "makeReviewsBookForm";
            this.Text = "Welcome to System - User Mode [BookManagmentSystemApplication] - Make Review Book" +
    "";
            this.Load += new System.EventHandler(this.makeReviewsBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shopBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewShopBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInformationBookAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemExitToolStripMenuItem;
    }
}