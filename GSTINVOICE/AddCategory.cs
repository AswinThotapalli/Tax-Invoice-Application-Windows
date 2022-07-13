﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace GSTINVOICE
{
    public partial class AddCategory : Form
    {
        string ConString = ConfigurationManager.ConnectionStrings["ApplicationForm.Properties.Settings.CMSMDataNewConnectionString"].ConnectionString;
        public AddCategory()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            txtHSN.Clear();
            txtItems.Clear();
            txtGST.Clear();
            txtCGST.Clear();
            txtSGST.Clear();
            txtDescription.Clear();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new OleDbConnection(ConString))
                {
                    OleDbCommand cmd = new OleDbCommand("insert into [HSNCodetbl] (Category,HSN_SAC,Description,GST,CGST,SGST) values ('" + txtItems.Text  + "','"+ txtHSN.Text + "','" + txtDescription.Text + "'," + txtGST.Text + "," + txtCGST.Text + "," + txtSGST.Text + ")", con);
                    con.Open();
                    if (txtItems.Text == "")
                    {
                        MessageBox.Show("Please Enter Name");
                        return;
                    }
                    else if (txtHSN.Text == "")
                    {
                        MessageBox.Show("Please Enter HSN");
                        return;
                    }
                    else if (txtDescription.Text == "")
                    {
                        MessageBox.Show("Please Enter Description");
                        return;
                    }
                    else if (txtGST.Text == "")
                    {
                        MessageBox.Show("Please Enter GST");
                        return;
                    }
                    else if (txtCGST.Text == "")
                    {
                        MessageBox.Show("Please Enter CGST");
                        return;
                    }
                    else if (txtSGST.Text == "")
                    {
                        MessageBox.Show("Please Enter SGST");
                        return;
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category Saved Successfully..!!");
                    this.ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
