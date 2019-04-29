namespace HomeWork8
{
    partial class EditForm
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
            this.editButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.goOutTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.goOutTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(272, 27);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(272, 76);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // goOutTimeMaskedTextBox
            // 
            this.goOutTimeMaskedTextBox.Location = new System.Drawing.Point(31, 53);
            this.goOutTimeMaskedTextBox.Mask = "00:00";
            this.goOutTimeMaskedTextBox.Name = "goOutTimeMaskedTextBox";
            this.goOutTimeMaskedTextBox.Size = new System.Drawing.Size(141, 20);
            this.goOutTimeMaskedTextBox.TabIndex = 2;
            this.goOutTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // goOutTimeLabel
            // 
            this.goOutTimeLabel.AutoSize = true;
            this.goOutTimeLabel.Location = new System.Drawing.Point(31, 27);
            this.goOutTimeLabel.Name = "goOutTimeLabel";
            this.goOutTimeLabel.Size = new System.Drawing.Size(123, 13);
            this.goOutTimeLabel.TabIndex = 3;
            this.goOutTimeLabel.Text = "Добавьте время ухода";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 133);
            this.Controls.Add(this.goOutTimeLabel);
            this.Controls.Add(this.goOutTimeMaskedTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.editButton);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.MaskedTextBox goOutTimeMaskedTextBox;
        private System.Windows.Forms.Label goOutTimeLabel;
    }
}