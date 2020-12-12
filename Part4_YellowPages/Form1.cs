using Part4_YellowPages.DataAccessLayer.Context;
using Part4_YellowPages.EntityLayer.Entities.Concrete;
using Part4_YellowPages.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part4_YellowPages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            ListOfUsers();
        }

        private void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }
        private void ListOfUsers()
        {
            dataGridView1.DataSource = db.User.Where(x => x.Status != Status.Passive).ToList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = txtAddFirstName.Text;
            user.LastName = txtAddLastName.Text;
            user.PhoneNumber = txtAddPhoneNumber.Text;
            user.Note = txtAddNote.Text;
            db.User.Add(user);
            db.SaveChanges();
            ListOfUsers();
            Eraser(grpAddUser);

        }
       
        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            User user = db.User.FirstOrDefault(x => x.Id == id);//We caught this from id number***
            user.FirstName = txtModifyFirstName.Text;
            user.LastName = txtModifyLastName.Text;
            user.PhoneNumber = txtModifyPhoneNumber.Text;
            user.Note = txtModifyNote.Text;
            user.Status = Status.Modified;
            user.ModifiedDate = DateTime.Now;
            db.SaveChanges();
            ListOfUsers();
            Eraser(grpModify);

        }
        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            txtModifyFirstName.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
            txtModifyLastName.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
            txtModifyPhoneNumber.Text = dataGridView1.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            txtModifyNote.Text = dataGridView1.CurrentRow.Cells["Note"].Value.ToString();
            txtDeletePhoneNumber.Text = id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = db.User.FirstOrDefault(x => x.Id == id);
            user.PassivedDate = DateTime.Now;
            user.Status = Status.Passive;
            db.SaveChanges();
            ListOfUsers();
            Eraser(grpDelete);
        }
    }
}
