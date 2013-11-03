using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
///logicalmanage 的摘要说明
/// </summary>
public class logicalmanage
{
    SqlConnection con;
	public logicalmanage(string str)
	{
        connection.str = str;
        this.con = connection.getcon();
	}
    public int updaterepeat(string item)
    {
        int k;
        string str = "update Profiles set p_IsRepeat='" + item + "'";
        SqlCommand com = new SqlCommand(str, con);
        try
        {
           k = int.Parse(com.ExecuteNonQuery().ToString());
        }
        catch(Exception  ex)
        {
            throw new Exception(ex.Message, ex);
        }
        return k;
    
    }
    public int updatevote(int item)
    {
        int k;
       string str="update Items set i_count=i_count+1 where i_id="+item.ToString ()+"";
       SqlCommand com = new SqlCommand(str, con);
       try
       {
           k = int.Parse(com.ExecuteNonQuery().ToString());
       }
       catch(Exception  ex)
       {
           throw new Exception(ex.Message, ex);
       }
       return k;
    }
    public DataSet  gettopicsid(string str)
    {
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = com;
        DataSet ds = new DataSet();
        da.Fill(ds, "topics");
        return ds;
    }
   
}