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
    public partial class Neoesodo : Form
    {
        public Neoesodo()
        {
            InitializeComponent();
        }

        private void Neoesodo_Load(object sender, EventArgs e)
        {

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
            string query = "INSERT INTO statheraesoda(Ono) VAlUES('" + neoesodotextBox.Text + "') ";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            

            if (cmd.ExecuteNonQuery()==1)
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
