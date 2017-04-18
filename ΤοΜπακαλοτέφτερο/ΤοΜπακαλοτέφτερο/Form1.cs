using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;

namespace ΤοΜπακαλοτέφτερο
{
    public partial class mainForm : Form
    {
         
        
        public mainForm()
        {
            InitializeComponent();
            Loadeksoda();
            Loadesoda();

        }
        //fortoma pinaka eksodwn sto datagrid eksodwn
        private void Loadeksoda()
        {
            

            
            OleDbConnection connection = new OleDbConnection(); 
            connection.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =C:\Users\Thomas\Desktop\Tompakaloteftero\ΤοΜπακαλοτέφτερο\ΤοΜπακαλοτέφτερο\ΤοΜπακαλοτέφτερο.mdb";
            connection.Open();
            OleDbCommand commandeksoda = new OleDbCommand();
            commandeksoda.Connection = connection;
            int index = maincomboBox.SelectedIndex + 1;
            string query = "SELECT * FROM eksoda where eksoda.minasID = "+ index +" ";
            commandeksoda.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(commandeksoda);
            DataSet ds = new DataSet();
            da.Fill(ds);
            eksodadataGridView.DataSource = ds.Tables[0];
            connection.Close();
            
        }
        //fortoma pinaka esodwn sto datagrid esodwn
        private void Loadesoda()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =C:\Users\Thomas\Desktop\Tompakaloteftero\ΤοΜπακαλοτέφτερο\ΤοΜπακαλοτέφτερο\ΤοΜπακαλοτέφτερο.mdb";
            connection.Open();
            OleDbCommand commandesoda = new OleDbCommand();
            commandesoda.Connection = connection;
            int index = maincomboBox.SelectedIndex + 1;
            string query = "SELECT * FROM esoda where esoda.minasID = " + index + " ";
            commandesoda.CommandText = query;
            OleDbDataAdapter da2 = new OleDbDataAdapter(commandesoda);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            esodadataGridView1.DataSource = ds2.Tables[0];
            connection.Close();
        }
       
        private void νΕΟΕΣΟΔΟToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Neoesodo newesodoform = new Neoesodo();
            newesodoform.ShowDialog();
        }

        private void νΕΟΣΤΑΘΕΡΟΕΞΟΔΟToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Neoeksodo neweksodoform = new Neoeksodo();
            neweksodoform.ShowDialog();
        }

        private void maincomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadeksoda();
            Loadesoda();
        }

        private void neoesodobutton_Click(object sender, EventArgs e)
        {
            prosthikiesodo newprosthikiesodo = new prosthikiesodo();
            newprosthikiesodo.ShowDialog();
        }

        private void neoeksodobutton_Click(object sender, EventArgs e)
        {
            prosthikieksodo newprosthikieκsodo = new prosthikieksodo();
            newprosthikieκsodo.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'τοΜπακαλοτέφτεροDataSet3.mines' table. You can move, or remove it, as needed.
            this.minesTableAdapter.Fill(this.τοΜπακαλοτέφτεροDataSet3.mines);

        }
    }
}
