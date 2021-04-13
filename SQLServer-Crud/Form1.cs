using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServer_Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void Yenile()
        {
            dataGridView1.DataSource = Crud.List("Select * from Customers");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
