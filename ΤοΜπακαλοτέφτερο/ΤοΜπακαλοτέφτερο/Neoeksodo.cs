using System;
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
    public partial class Neoeksodo : Form
    {
        public Neoeksodo()
        {
            InitializeComponent();
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
            string query = "INSERT INTO statheraeksoda(Ono) VAlUES('" + neoeksodotextBox.Text + "') ";
            OleDbCommand cmd = new OleDbCommand(query, connection);


            if (cmd.ExecuteNonQuery() == 1)
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
