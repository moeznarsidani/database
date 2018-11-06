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
    public partial class dbweb : System.Web.UI.Page
    {
        public string cnctstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        
        

        protected void Button1_Click1(object sender, EventArgs e)
        { 
            SqlConnection con1 = new SqlConnection(cnctstring);
            con1.Open();
            if (con1.State == System.Data.ConnectionState.Open)
            {
                string a = "insert into info(id,firstname,lastname,contact,email,address)values('" + TextBox1.Text.ToString() + "','" + TextBox2.Text.ToString() + "','" + TextBox3.Text.ToString() + "','" + TextBox4.Text.ToString() + "','" + TextBox5.Text.ToString() + "','" + TextBox6.Text.ToString() + "')";

                SqlCommand cmd = new SqlCommand(a, con1);
                cmd.ExecuteNonQuery();
                Response.Write("Connected and inserted Successfully");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cnctstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string b = "update info set id= '" + TextBox1.Text.ToString() + "',firstname='" + TextBox2.Text.ToString() + "', lastname='" + TextBox3.Text.ToString() + "', contact='" + TextBox4.Text.ToString() + "', email='" + TextBox5.Text.ToString() + "', address='" + TextBox6.Text.ToString() + "' where id= '" + TextBox1.Text.ToString() + "' ";

                SqlCommand cmd = new SqlCommand(b, con);
                cmd.ExecuteNonQuery();
                Response.Write("Connected and updated Successfully.");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(cnctstring);
            con2.Open();
            if (con2.State == System.Data.ConnectionState.Open)
            {
                string c = "delete from info where id= '" + TextBox1.Text.ToString() + "' ";

                SqlCommand cmd = new SqlCommand(c, con2);
                cmd.ExecuteNonQuery();
                Response.Write("Deleted Successfully");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(cnctstring);
            con2.Open();
           
            string sqlquery = ("select id,firstname,lastname,contact,email,address from info where (id= " + TextBox1.Text.ToString() + ")");
            SqlCommand cmd = new SqlCommand(sqlquery, con2);
            SqlDataReader sdr = cmd.ExecuteReader();


            if (sdr.Read())
            {
               TextBox7.Text = sdr.GetValue(0)+"\n"+sdr.GetValue(1) +"\n"+ sdr.GetValue(2) + "\n" + sdr.GetValue(3) + "\n" + sdr.GetValue(4) + "\n" + sdr.GetValue(5).ToString();
                Response.Write("selected   and get data successfully!!!");
               
            }
            else
            {
                TextBox7.Text="there is no data";
            }
            
         
        }

     
    }
}