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
    public partial class Sell : Form
    {
        private int GrdTotal { get; set; } = 0;
        private int total { get; set; }
        private int i { get; set; } = 0;


        public Sell()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Coding\Inventory\database\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select ProdName, ProdPrice from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populateBill()
        {
            Con.Open();
            string query = "select * from SellTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            populate();
            populateBill();
            dateLbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prodDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sellName.Text = prodDGV1.SelectedRows[0].Cells[0].Value.ToString();
            sellPrice.Text = prodDGV1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            dateLbl.Text = DateTime.Today.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void sellAdd_Click(object sender, EventArgs e)
        {
            if (sellID.Text =="")
            {
                MessageBox.Show("Missing Bill Id");
            }
            try
            {
                Con.Open();
                string query = "insert into sellTbl values('" + sellID.Text + "','" + sellName.Text + "','" + dateLbl.Text + "'," + totalLbl.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Successfully Added");
                Con.Close();
                populateBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sellName.Text == "" || sellQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(sellPrice.Text) * Convert.ToInt32(sellQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(orderDGV);
                newRow.Cells[0].Value = i + 1;
                newRow.Cells[1].Value = sellName.Text;
                newRow.Cells[2].Value = sellQty.Text;
                newRow.Cells[3].Value = sellPrice.Text;
                newRow.Cells[4].Value = Convert.ToInt32(sellPrice.Text) * Convert.ToInt32(sellQty.Text);
                orderDGV.Rows.Add(newRow);
                i++;
                GrdTotal = GrdTotal + total;
                totalLbl.Text = "" + GrdTotal;
            }
        }

        public void prodBtn_Click(object sender, EventArgs e)
        {
            Product cat = new Product();
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
