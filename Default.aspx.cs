using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;
public partial class _Default : System.Web.UI.Page
{
    MySqlConnection c1 = new MySqlConnection("server=b1cd7557-6515-4315-b173-a41000718d78.mysql.sequelizer.com;User Id=qhjmurvgkjyckfli;Password=igJW4areBPSwLjbX3JVDAbLwAKKBhG5z3mME5hFL8sai7ALovjkWz73gCnurwW53;Persist Security Info=True;database=dbb1cd755765154315b173a41000718d78");
    public void bindgrid(string rr)
    {
         try
        {
        DataSet dt = new DataSet();
        c1.Open();
        MySqlDataAdapter da = new MySqlDataAdapter(rr, c1);
        da.Fill(dt);
        GridView1.DataSource = dt.Tables[0];
        GridView1.DataBind(); da.Dispose();        
        }
         catch (Exception er)
         {
         }
         finally
         {
             c1.Close();
         }
    }
    protected void Page_Load(object sender, EventArgs e)
    {           
        bindgrid("select * from sample");
        TextBox1.Focus();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        if (TextBox1.Text != "*")
        {
            bindgrid("select * from sample where Mobile='" + TextBox1.Text + "'");
        }
        else
        {
            bindgrid("select * from sample");
        }
    }
}
