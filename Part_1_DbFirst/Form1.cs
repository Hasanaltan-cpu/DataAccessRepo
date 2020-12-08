using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1_DbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categories.ToList();

        }
    }
}
