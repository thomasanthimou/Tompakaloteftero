﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ΤοΜπακαλοτέφτερο
{
    public partial class prosthikieksodo : Form
    {
        public prosthikieksodo()
        {
            InitializeComponent();
        }

        private void prosthikieksodo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'τοΜπακαλοτέφτεροDataSet2.statheraeksoda' table. You can move, or remove it, as needed.
            this.statheraeksodaTableAdapter.Fill(this.τοΜπακαλοτέφτεροDataSet2.statheraeksoda);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =C:\Users\Thomas\Desktop\Tompakaloteftero\ΤοΜπακαλοτέφτερο\ΤοΜπακαλοτέφτερο\ΤοΜπακαλοτέφτερο.mdb";
            connection.Open();
            OleDbCommand command = new OleDbCommand("INSERT INTO eksoda(ono,imerominia,amount,remarks,minas) VALUES('" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','"+ dateTimePicker1.Value.Month +"')",connection);

           if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("ΑΠΟΘΗΚΕΥΤΗΚΕ");
                this.Close();
            }
            else
            {
                MessageBox.Show("ΔΕΝ ΑΠΟΘΗΚΕΥΤHΚΕ");
            }
        }
    }
}
