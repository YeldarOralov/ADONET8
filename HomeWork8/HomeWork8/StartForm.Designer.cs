namespace HomeWork8
{
    partial class StartForm
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
            this.guestDataGridView = new System.Windows.Forms.DataGridView();
            this.addGuestButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guestDataGridView
            // 
            this.guestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestDataGridView.Location = new System.Drawing.Point(13, 13);
            this.guestDataGridView.Name = "guestDataGridView";
            this.guestDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guestDataGridView.Size = new System.Drawing.Size(375, 425);
            this.guestDataGridView.TabIndex = 0;
            this.guestDataGridView.DoubleClick += new System.EventHandler(this.GuestDataGridView_DoubleClick);
            // 
            // addGuestButton
            // 
            this.addGuestButton.Location = new System.Drawing.Point(452, 13);
            this.addGuestButton.Name = "addGuestButton";
            this.addGuestButton.Size = new System.Drawing.Size(75, 23);
            this.addGuestButton.TabIndex = 1;
            this.addGuestButton.Text = "Добавить посетителя";
            this.addGuestButton.UseVisualStyleBackColor = true;
            this.addGuestButton.Click += new System.EventHandler(this.AddGuestButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(452, 71);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(452, 415);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addGuestButton);
            this.Controls.Add(this.guestDataGridView);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.guestDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView guestDataGridView;
        private System.Windows.Forms.Button addGuestButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button refreshButton;
    }
}