using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace web_form
{

    public partial class person : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=desktop-8evnu8b\sqlexpress;Initial Catalog=person;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            disp_data();
        }
        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from personData";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void insertBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into personData values ('" + nameTxtBox.Text + "','" + cityTxtBox.Text + "','" + contactTxtBox.Text + "')";
            cmd.ExecuteNonQuery();

            nameTxtBox.Text = "";
            cityTxtBox.Text = "";
            contactTxtBox.Text = "";
            disp_data();
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update personData set city='" + (cityTxtBox.Text) + "', contact='" + contactTxtBox.Text + "' where name = '" + (nameTxtBox.Text) + "'";
            cmd.ExecuteNonQuery();
            disp_data();
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from personData where name = '" + (nameTxtBox.Text) + "'";
            cmd.ExecuteNonQuery();
            disp_data();
        }
    }
}