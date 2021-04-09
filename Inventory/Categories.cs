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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Coding\Inventory\database\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTbl values(" + CatId.Text + ",'" + CatName.Text + "','" + CatDesc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Berhasil Ditambahkan");
                Con.Close();
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatId.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatName.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDesc.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatId.Text == "")
                {
                    MessageBox.Show("Choose The Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where CatId=" + CatId.Text + "";
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatId.Text == "" || CatName.Text == "" || CatDesc.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CatName ='" + CatName.Text + "',CatDesc ='" + CatDesc.Text + "' where CatId =" + CatId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Succesfully Updated");
                    Con.Close();
                    populate();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
            this.Hide();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            Sell prod = new Sell();
            prod.Show();
            this.Hide();
        }
    }
}
