using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data ;
using System.Data .SqlClient ;
/// <summary>
///checklogin 的摘要说明
/// </summary>
public class checklogin
{
    public SqlConnection con;
    public checklogin(string str)
    {
        connection.str = str;        
        this.con=connection.getcon();
    
    }
    public int  getlogin(model m)
    {
        int k;
        string str = "select * from admin where name=@username and psw=@password";
        SqlCommand com = new SqlCommand(str,con);     
        com.Parameters.Add("@username", SqlDbType.NVarChar , 20);
        com.Parameters["@username"].Value =m.name;
        com.Parameters.Add("@password", SqlDbType.NVarChar, 50);
        com.Parameters["@password"].Value = m.password;
        try
        {
            k = (int)com.ExecuteScalar();
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            con.Close();
           
        }
        return k;
    }
}