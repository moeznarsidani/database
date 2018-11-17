using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace database
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public string cnctstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True";






        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnctstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string a = "insert into form(Id,firstname,lastname,address,contact,email,city,state,zipcode,webname,hosting,description)values('" + id.Text.ToString() + "','" + fname.Text.ToString() + "'," +
                    "'" + lname.Text.ToString() + "','" + address.Text.ToString() + "'," +
                    "'" + phone.Text.ToString() + "','" + email.Text.ToString() + "', ' " + city.Text.ToString() + " ', ' " + state.Text.ToString() + " ', ' " + zip.Text.ToString() + " ', " +
                    "' " + domain.Text.ToString() + " ', ' " + hosting.Text.ToString() + " ', ' " + pdesc.Text.ToString() + " ' )";

                SqlCommand cmd = new SqlCommand(a, con);
                cmd.ExecuteNonQuery();
                Response.Write("Added Successfully");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string myquery = "select * from form";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("Selected and Displayed Succesfully!!!");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(cnctstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string b = "update form set id= '" + id.Text.ToString() + "',firstname='" + fname.Text.ToString() + "', lastname='" + lname.Text.ToString() + "'," +
                    "  address='" + address.Text.ToString() + "', contact='" + phone.Text.ToString() + "', " + "email='" + email.Text.ToString() + "', city='" + city.Text.ToString() + "'," +
                    "state='" + state.Text.ToString() + "',zipcode='" + zip.Text.ToString() + "',webname='" + domain.Text.ToString() + "'," +
                    "hosting='" + hosting.Text.ToString() + "',description='" + pdesc.Text.ToString() + "' where id= '" + id.Text.ToString() + "' ";

                SqlCommand cmd = new SqlCommand(b, con);
                cmd.ExecuteNonQuery();
                Response.Write("Connected and updated Successfully.");
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(cnctstring);
            con2.Open();
            if (con2.State == System.Data.ConnectionState.Open)
            {
                string c = "delete from form where id= '" + id.Text.ToString() + "' ";

                SqlCommand cmd = new SqlCommand(c, con2);
                cmd.ExecuteNonQuery();
                Response.Write("Connected and Deleted Successfully");
            }



        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            id.Text = "";
            fname.Text = "";
            lname.Text = "";
            address.Text = "";
            phone.Text = "";
            email.Text = "";
            city.Text = "";
            state.Text = "";
            zip.Text = "";
            domain.Text = "";
            hosting.Text = "";
            pdesc.Text = "";

        }
    }
}

    
