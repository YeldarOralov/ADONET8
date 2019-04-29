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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            ShowGuests();
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddGuestForm();
            addForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GuestDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string guestName = guestDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            using (var context = new RegistrationContext())
            {
                Guest guest = context.Guests.Where(p => p.FullName == guestName).FirstOrDefault();
                var editForm = new EditForm(guest);
                editForm.Show();
            }
        }

        private void ShowGuests()
        {
            using (var context = new RegistrationContext())
            {
                guestDataGridView.DataSource = context.Guests.ToList();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ShowGuests();
        }
    }
}
