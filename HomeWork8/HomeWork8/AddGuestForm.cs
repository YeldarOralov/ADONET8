using HomeWork8.DataAccess;
using HomeWork8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork8
{
    public partial class AddGuestForm : Form
    {
        public AddGuestForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.TextLength == 0 || numberTextBox.TextLength == 0 || purposeTextBox.TextLength==0)
            {
                MessageBox.Show("Поля должны быть заполнены");
            }
            else
            {
                using (var context = new RegistrationContext())
                {
                    context.Guests.Add(new Guest
                    {
                        FullName = nameTextBox.Text,
                        DocumentNumber = numberTextBox.Text,
                        Purpose=purposeTextBox.Text
                    });
                    context.SaveChanges();
                }
                Form.ActiveForm.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
