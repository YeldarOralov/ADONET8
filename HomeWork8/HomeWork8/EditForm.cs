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
    public partial class EditForm : Form
    {
        private Guest _guest;
        public EditForm(Guest guest)
        {
            InitializeComponent();
            _guest = guest;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (goOutTimeMaskedTextBox.TextLength == 0)
            {
                MessageBox.Show("Поля должны быть заполнены");
            }
            else
            {
                using (var context = new RegistrationContext())
                {
                    context.Guests.Where(p => p.FullName == _guest.FullName).FirstOrDefault().GoOutTime = Convert.ToDateTime(goOutTimeMaskedTextBox.Text);
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
