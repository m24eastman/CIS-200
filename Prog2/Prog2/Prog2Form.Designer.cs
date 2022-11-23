namespace UPVApp
{
    partial class Prog2Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfParclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportT = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.InsertMenuItem,
            this.ReportMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(450, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(54, 29);
            this.FileMenuItem.Text = "File";
            this.FileMenuItem.Click += new System.EventHandler(this.FileMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // InsertMenuItem
            // 
            this.InsertMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.letterToolStripMenuItem});
            this.InsertMenuItem.Name = "InsertMenuItem";
            this.InsertMenuItem.Size = new System.Drawing.Size(72, 29);
            this.InsertMenuItem.Text = "Insert";
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.addressToolStripMenuItem.Text = "Address";
            this.addressToolStripMenuItem.Click += new System.EventHandler(this.addressToolStripMenuItem_Click);
            // 
            // letterToolStripMenuItem
            // 
            this.letterToolStripMenuItem.Name = "letterToolStripMenuItem";
            this.letterToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.letterToolStripMenuItem.Text = "Letter";
            this.letterToolStripMenuItem.Click += new System.EventHandler(this.letterToolStripMenuItem_Click);
            // 
            // ReportMenuItem
            // 
            this.ReportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfAddressesToolStripMenuItem,
            this.listOfParclesToolStripMenuItem});
            this.ReportMenuItem.Name = "ReportMenuItem";
            this.ReportMenuItem.Size = new System.Drawing.Size(81, 29);
            this.ReportMenuItem.Text = "Report";
            // 
            // listOfAddressesToolStripMenuItem
            // 
            this.listOfAddressesToolStripMenuItem.Name = "listOfAddressesToolStripMenuItem";
            this.listOfAddressesToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.listOfAddressesToolStripMenuItem.Text = "List of addresses";
            this.listOfAddressesToolStripMenuItem.Click += new System.EventHandler(this.listOfAddressesToolStripMenuItem_Click);
            // 
            // listOfParclesToolStripMenuItem
            // 
            this.listOfParclesToolStripMenuItem.Name = "listOfParclesToolStripMenuItem";
            this.listOfParclesToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.listOfParclesToolStripMenuItem.Text = "List of parcles";
            this.listOfParclesToolStripMenuItem.Click += new System.EventHandler(this.listOfParclesToolStripMenuItem_Click);
            // 
            // reportT
            // 
            this.reportT.Location = new System.Drawing.Point(22, 68);
            this.reportT.Margin = new System.Windows.Forms.Padding(2);
            this.reportT.Multiline = true;
            this.reportT.Name = "reportT";
            this.reportT.ReadOnly = true;
            this.reportT.Size = new System.Drawing.Size(816, 698);
            this.reportT.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 265);
            this.Controls.Add(this.reportT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prog2Form";
            this.Text = "Program 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfParclesToolStripMenuItem;
        private System.Windows.Forms.TextBox reportT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

