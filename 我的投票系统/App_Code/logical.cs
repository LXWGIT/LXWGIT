using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data ;
using System.Data.SqlClient ;
/// <summary>
///logical 的摘要说明
/// </summary>
public class logical
{
    public SqlConnection con;
    public static string t_name;
    public int t_id;
	public logical(string str)
	{
        connection.str = str;
        this.con =connection.getcon();
	}
    public DataSet  voteindex(string str)
    {
        DataSet ds = new DataSet();
        if (this.con != null)
        {
            SqlCommand com = new SqlCommand(str, con);
            com.ExecuteScalar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            da.Fill(ds, "vote");                       
        }
        return ds;
    }
    public SqlDataReader  multivote(string str)
    {
       
        SqlCommand com = new SqlCommand(str, con);
        SqlDataReader read = com.ExecuteReader();                    
        return read;   
    }
    public bool multivote1(string str)
    {

        SqlCommand com = new SqlCommand(str, con);
        try
        {
            com.ExecuteNonQuery();
        }
        catch
        {
            return false;
        }
        return true;
    }
    public DataSet  showvote(string str)
    {
        DataSet ds = new DataSet();
        if (this.con != null)
        {
            SqlCommand com = new SqlCommand(str, con);
            com.ExecuteScalar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            da.Fill(ds, "vote");
        }
        return ds;
    }
    public SqlDataReader singlevote(string str)
    {
       SqlCommand com = new SqlCommand(str, con);
       SqlDataReader dr = com.ExecuteReader();
       return dr;          
    }
    public bool singlevote1(string str)
    {
        SqlCommand com = new SqlCommand(str, con);
        try
        {
            com.ExecuteNonQuery();
        }
        catch
        {
            return false;
        }
        return true;
    }
    public SqlDataReader morevote(string str)
    {
        SqlCommand com = new SqlCommand(str, con);
        SqlDataReader dr = com.ExecuteReader();
        return dr;
    
    }
    public SqlDataReader Isrepeat(string str)
    {

      SqlCommand com = new SqlCommand(str, con);
      SqlDataReader dr=com .ExecuteReader ();
      return dr;
    
    }
    public int morevote1()
    {
        string str = "select * from Topics where t_IsCurrent=1";
        SqlCommand com = new SqlCommand(str,con );
        SqlDataReader dr= com.ExecuteReader();
        if (dr.Read())
        {
            t_name = dr["t_name"].ToString();
            t_id = int.Parse(dr["t_id"].ToString());
        }
        return t_id;
    }
    public SqlDataReader getsubject(string str)
    {
        SqlCommand com = new SqlCommand(str, con);
      SqlDataReader dr=com.ExecuteReader ();
      return dr;
    
    }
    public SqlDataReader getitem(string str)
    {
      SqlCommand com = new SqlCommand(str, con);
      SqlDataReader dr=com.ExecuteReader ();
      return dr;
    
    }

    
}