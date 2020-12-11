using Part3_CodeFirst.DataAccessLayer.Context;
using Part3_CodeFirst.EntityLayer.Entities.Concrete;
using Part3_CodeFirst.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part3_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        
        private void ListOfCategories()
        {
            dataGridView1.DataSource = db.Categories.Where(x => x.Status != Status.Passive).ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListOfCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            //EF' kendisi otomatik atadı.
            category.CategoryName = txtAddName.Text;
            category.Description = txtAddDescription.Text;
            db.Categories.Add(category);
            db.SaveChanges(); //Database değişiklikleri kaydet
            ListOfCategories();
            Eraser(grpAdd);
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

        int id;//CellContentClick event'inin yaşam alanından Id'yi dışarıya almamızın sebebi,update ve delete işlemleri farklı scopelarda yani yaşam alanlarında gerçekleşeceğinden  From.cs sınıfı içerisinde "id" değişkeni ile CellContentClick eventinden gelecek id'yi karşıladım.Ayrıca ister Asp.Net Core Web Projesi olsun ister .Net Web Api projesi olsun,Details,Update,Delete vb işlemlerde ilgili entity yakalamak için spesifik bir özelliğe ihtiyaç duyarız,bu işlem için Id yani Identifier biçimlenmiştir.Neden Id biriciktir tekrar etmez.Peki Id'den yakalamazsak ne olur,Ef yeni bir entity ekliyormuşsun zannederek otomatik olarak bir Id atayıp update edilmek istenilen entity ekleyebilir.Ya da entityname'si aynı olan her varlığı silebilir update edebilir.Bu tarz üst seviye işlemlerde çok dikkatli olmalıyız.

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            txtUpdateName.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtUpdateDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            //txtDelete.Text=id.ToString();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Categories category = db.Categories.FirstOrDefault(x => x.Id == id); //Update edeceğin ürünü Id'den yakalamamız gerekiyor.!!!
            category.CategoryName = txtUpdateName.Text;
            category.Description = txtUpdateDescription.Text;
            category.Status = Status.Modified;
            category.ModifiedDate = DateTime.Now;
            db.SaveChanges();
            ListOfCategories();
            Eraser(grpUpdate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categories category = db.Categories.FirstOrDefault(x => x.Id == id);
            category.Status = Status.Passive;
            category.ModifiedDate = DateTime.Now;
            db.SaveChanges();
            ListOfCategories();
            Eraser(grpDelete);
        }
    }
}
