namespace Prog2
{
    partial class InsertAddressForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.address1Label = new System.Windows.Forms.Label();
            this.address1box = new System.Windows.Forms.TextBox();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.address2Label = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(19, 53);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(144, 50);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(191, 26);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            this.nameBox.Validated += new System.EventHandler(this.Name_Validated);
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(19, 106);
            this.address1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(72, 20);
            this.address1Label.TabIndex = 2;
            this.address1Label.Text = "Address:";
            // 
            // address1box
            // 
            this.address1box.Location = new System.Drawing.Point(144, 104);
            this.address1box.Margin = new System.Windows.Forms.Padding(2);
            this.address1box.Name = "address1box";
            this.address1box.Size = new System.Drawing.Size(191, 26);
            this.address1box.TabIndex = 3;
            this.address1box.Validating += new System.ComponentModel.CancelEventHandler(this.Address1_Validating);
            this.address1box.Validated += new System.EventHandler(this.Address1_Validated);
            // 
            // address2Box
            // 
            this.address2Box.Location = new System.Drawing.Point(143, 154);
            this.address2Box.Margin = new System.Windows.Forms.Padding(2);
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(192, 26);
            this.address2Box.TabIndex = 4;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(17, 209);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 20);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(142, 204);
            this.cityBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(193, 26);
            this.cityBox.TabIndex = 6;
            this.cityBox.Validating += new System.ComponentModel.CancelEventHandler(this.City_Validating);
            this.cityBox.Validated += new System.EventHandler(this.City_Validated);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(19, 262);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(52, 20);
            this.stateLabel.TabIndex = 7;
            this.stateLabel.Text = "State:";
            // 
            // stateBox
            // 
            this.stateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California"});
            this.stateBox.Location = new System.Drawing.Point(142, 260);
            this.stateBox.Margin = new System.Windows.Forms.Padding(2);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(136, 28);
            this.stateBox.TabIndex = 8;
            this.stateBox.SelectedIndexChanged += new System.EventHandler(this.StateCB_SelectedIndexChanged);
            this.stateBox.Validating += new System.ComponentModel.CancelEventHandler(this.Sate_Validating);
            this.stateBox.Validated += new System.EventHandler(this.Sate_Validated);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(19, 316);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(77, 20);
            this.zipLabel.TabIndex = 9;
            this.zipLabel.Text = "Zip Code:";
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(142, 314);
            this.zipBox.Margin = new System.Windows.Forms.Padding(2);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(193, 26);
            this.zipBox.TabIndex = 10;
            this.zipBox.TextChanged += new System.EventHandler(this.zipBox_TextChanged);
            this.zipBox.Validating += new System.ComponentModel.CancelEventHandler(this.ZipCode_Validating);
            this.zipBox.Validated += new System.EventHandler(this.ZipCode_Validated);
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(17, 156);
            this.address2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(119, 20);
            this.address2Label.TabIndex = 11;
            this.address2Label.Text = "Address Line 2:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(28, 399);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 34);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cancel_MouseDown);
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addButton.Location = new System.Drawing.Point(202, 399);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 34);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add Address";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddAddressBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InsertAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.addButton;
            this.ClientSize = new System.Drawing.Size(414, 602);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2Box);
            this.Controls.Add(this.address1box);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsertAddressForm";
            this.Text = "InsertAddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.TextBox address1box;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}