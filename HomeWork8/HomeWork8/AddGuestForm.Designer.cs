namespace HomeWork8
{
    partial class AddGuestForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.purposeTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.purposeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(13, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(140, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(13, 94);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(140, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // purposeTextBox
            // 
            this.purposeTextBox.Location = new System.Drawing.Point(13, 146);
            this.purposeTextBox.Name = "purposeTextBox";
            this.purposeTextBox.Size = new System.Drawing.Size(140, 20);
            this.purposeTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "ФИО";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(13, 75);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(98, 13);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "Номер документа";
            // 
            // purposeLabel
            // 
            this.purposeLabel.AutoSize = true;
            this.purposeLabel.Location = new System.Drawing.Point(13, 127);
            this.purposeLabel.Name = "purposeLabel";
            this.purposeLabel.Size = new System.Drawing.Size(71, 13);
            this.purposeLabel.TabIndex = 6;
            this.purposeLabel.Text = "Цель визита";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(184, 37);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(184, 94);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 286);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.purposeLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.purposeTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddGuestForm";
            this.Text = "AddGuestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox purposeTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label purposeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
    }
}