using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data ;
using System.Data .SqlClient ;

/// <summary>
///checkip 的摘要说明
/// </summary>
public class checkip
{
	SqlConnection con;
	public checkip(string str)
	{
        connection.str = str;
        this.con = connection.getcon();
	}
    public int checkip1(string str)
    {
        SqlCommand com = new SqlCommand(str, con);        
        int k =int.Parse (com.ExecuteScalar().ToString ());     
        return k;
    }
    public int insertvote(string str)
    {
        SqlCommand com = new SqlCommand(str, con);
        int k;
        try
        {
            k = int.Parse(com.ExecuteNonQuery().ToString());
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        return k;
    }
}