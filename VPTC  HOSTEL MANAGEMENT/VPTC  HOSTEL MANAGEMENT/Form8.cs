﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VPTC__HOSTEL_MANAGEMENT
{
    public partial class Form8 : Form
    {
      
        public Form8()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nav In\OneDrive\Documents\Visual Studio 2010\Projects\VPTC  HOSTEL MANAGEMENT\VPTC  HOSTEL MANAGEMENT\HOSTEL VPTC.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        string sql;

        private void Form8_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            sql = "select * from SR";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6] ,dr[7]);
            }
            con.Close();


            int count = dataGridView1.RowCount;
            textBox2.Text = count.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
      
        }
    }
