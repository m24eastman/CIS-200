namespace Prog2
{
    partial class InsertLetterForm
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
            this.originLabel = new System.Windows.Forms.Label();
            this.originBox = new System.Windows.Forms.ComboBox();
            this.destLabel = new System.Windows.Forms.Label();
            this.destBox = new System.Windows.Forms.ComboBox();
            this.fixedLabel = new System.Windows.Forms.Label();
            this.fixedBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(34, 87);
            this.originLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(117, 20);
            this.originLabel.TabIndex = 0;
            this.originLabel.Text = "Origin Address:";
            // 
            // originBox
            // 
            this.originBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originBox.FormattingEnabled = true;
            this.originBox.Location = new System.Drawing.Point(210, 96);
            this.originBox.Margin = new System.Windows.Forms.Padding(2);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(152, 28);
            this.originBox.TabIndex = 1;
            this.originBox.Validating += new System.ComponentModel.CancelEventHandler(this.OAddress_Validating);
            this.originBox.Validated += new System.EventHandler(this.OAddress_Validated);
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(43, 155);
            this.destLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(157, 20);
            this.destLabel.TabIndex = 2;
            this.destLabel.Text = "Destination Address:";
            // 
            // destBox
            // 
            this.destBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destBox.FormattingEnabled = true;
            this.destBox.Location = new System.Drawing.Point(210, 155);
            this.destBox.Margin = new System.Windows.Forms.Padding(2);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(152, 28);
            this.destBox.TabIndex = 3;
            this.destBox.Validating += new System.ComponentModel.CancelEventHandler(this.DAddress_Validating);
            this.destBox.Validated += new System.EventHandler(this.DAddress_Validated);
            // 
            // fixedLabel
            // 
            this.fixedLabel.AutoSize = true;
            this.fixedLabel.Location = new System.Drawing.Point(34, 218);
            this.fixedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fixedLabel.Name = "fixedLabel";
            this.fixedLabel.Size = new System.Drawing.Size(88, 20);
            this.fixedLabel.TabIndex = 4;
            this.fixedLabel.Text = "Fixed Cost:";
            // 
            // fixedBox
            // 
            this.fixedBox.Location = new System.Drawing.Point(210, 218);
            this.fixedBox.Margin = new System.Windows.Forms.Padding(2);
            this.fixedBox.Name = "fixedBox";
            this.fixedBox.Size = new System.Drawing.Size(152, 26);
            this.fixedBox.TabIndex = 5;
            this.fixedBox.TextChanged += new System.EventHandler(this.FCTxt_TextChanged);
            this.fixedBox.Validating += new System.ComponentModel.CancelEventHandler(this.FC_Validating);
            this.fixedBox.Validated += new System.EventHandler(this.FC_Validated);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(102, 336);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 48);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBTN_MouseDown);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(316, 336);
            this.insertButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(130, 48);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InsertLetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 511);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fixedBox);
            this.Controls.Add(this.fixedLabel);
            this.Controls.Add(this.destBox);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.originLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsertLetterForm";
            this.Text = "InsertLetterForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.ComboBox originBox;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.ComboBox destBox;
        private System.Windows.Forms.Label fixedLabel;
        private System.Windows.Forms.TextBox fixedBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}