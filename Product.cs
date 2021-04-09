using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Coding\Inventory\database\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "CatName";
            CatCb.DataSource = dt;
            Con.Close();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void prodAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ProductTbl values(" + prodId.Text + ",'" + prodName.Text + "'," + prodQty.Text + ",'" + CatCb.SelectedValue.ToString() + "', " + prodPrice.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                populate();
                //" + prodPrice.Text + ",
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prodDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodId.Text = prodDGV.SelectedRows[0].Cells[0].Value.ToString();
            prodName.Text = prodDGV.SelectedRows[0].Cells[1].Value.ToString();
            prodQty.Text = prodDGV.SelectedRows[0].Cells[2].Value.ToString();
            CatCb.SelectedValue = prodDGV.SelectedRows[0].Cells[3].Value.ToString();
            prodPrice.Text = prodDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void prodEdt_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodId.Text == "" || prodName.Text == "" || prodQty.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update ProductTbl set ProdName ='" + prodName.Text + "', ProdQty =" + prodQty.Text + ", ProdCat ='" + CatCb.SelectedValue.ToString() + "' where ProdId =" + prodId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Succesfully Updated");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prodDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodId.Text == "")
                {
                    MessageBox.Show("Choose The Product to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductTbl where ProdId=" + prodId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Succesfully");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void sellBtn_Click(object sender, EventArgs e)
        {
            Sell cat = new Sell();
            cat.Show();
            this.Hide();
        }

        public void catBtn_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            cat.Show();
            this.Hide();
        }
    }
}
