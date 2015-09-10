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


namespace ADO.Net
{
    public partial class Form1 : Form
    {
        //Connection String
        public string _cnString = "Server = CLUW004\\SQLEXPRESS; Database = ToDoList; Trusted_Connection=True;";
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection("Server = CLUW004\\SQLEXPRESS; Database = ToDoList; Trusted_Connection=True;");
        SqlDataAdapter da = new SqlDataAdapter();
        BindingSource tblNames = new BindingSource();



        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("INSERT INTO USERS(Name, Lastname, Role) values(@NAME, @LASTNAME,@ROLE)", con);
            da.InsertCommand.Parameters.Add("@NAME", SqlDbType.VarChar).Value = TB_name.Text;
            da.InsertCommand.Parameters.Add("@LASTNAME", SqlDbType.VarChar).Value = TB_Lastname.Text;
            da.InsertCommand.Parameters.Add("@ROLE", SqlDbType.VarChar).Value = TB_Role.Text;

            con.Open();
            da.InsertCommand.ExecuteNonQuery();
            con.Close();
            //con.Open();
            //MessageBox.Show(con.State.ToString());
            //con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM USERS", con);

            ds.Clear();

            da.Fill(ds);

            Dg.DataSource = ds.Tables[0];

            tblNames.DataSource = ds.Tables[0];

            TB_name.DataBindings.Add(new Binding("Text", tblNames, "NAME"));

            TB_Lastname.DataBindings.Add(new Binding("Text", tblNames, "LASTNAME"));

            TB_Role.DataBindings.Add(new Binding("Text", tblNames, "ROLE"));

            records();



        }
        private void TB_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Role_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tblNames.MoveNext();
            dgUpdate();
            records();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tblNames.MovePrevious();
            dgUpdate();
            records();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tblNames.MoveFirst();
            dgUpdate();
            records();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tblNames.MoveLast();
            dgUpdate();
            records();
        }

        private void dgUpdate()
        {
            Dg.ClearSelection();
            Dg.Rows[tblNames.Position].Selected = true;
            records();
        }

        private void records()
        {
            label3.Text = "Record " + tblNames.Position + " of " + (tblNames.Count - 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int x;

            da.UpdateCommand = new SqlCommand("UPDATE USERS SET NAME = @NAME, LASTNAME = @LASTNAME, ROLE = @ROLE WHERE ID_USER = @ID", con);
            da.UpdateCommand.Parameters.Add("@NAME", SqlDbType.VarChar).Value = TB_name.Text;
            da.UpdateCommand.Parameters.Add("@LASTNAME", SqlDbType.VarChar).Value = TB_Lastname.Text;
            da.UpdateCommand.Parameters.Add("@ROLE", SqlDbType.VarChar).Value = TB_Role.Text;

            da.UpdateCommand.Parameters.Add("@ID", SqlDbType.SmallInt).Value = ds.Tables[0].Rows[tblNames.Position][0];
            con.Open();

            x = da.UpdateCommand.ExecuteNonQuery();
            con.Close();

            if (x >= 1)
                MessageBox.Show("Record(s) has been updated");

        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {

            DialogResult dr;

            dr = MessageBox.Show("Are you sure?\nThere is no undo once data is deleted", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                da.DeleteCommand = new SqlCommand("Delete FROM USERS WHERE ID_USER = @ID", con);
                da.DeleteCommand.Parameters.Add("@ID", SqlDbType.SmallInt).Value = ds.Tables[0].Rows[tblNames.Position][0];

                con.Open();
                da.DeleteCommand.ExecuteNonQuery();
                con.Close();

                ds.Clear();

                da.Fill(ds);
            }
            else
            {
                MessageBox.Show("Deletion Canceled");
            }
        }
    }
}
