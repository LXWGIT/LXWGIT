using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data ;
using System.Data .SqlClient ;
/// <summary>
///logical 的摘要说明
/// </summary>
public class logical
{
    SqlConnection con;
	public logical(string str)
	{
        connection.str = str;
        con = connection.getopen();
	}
    public DataSet indexds(string str)
    {
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        da.SelectCommand = com;
        da.Fill(ds, "GoodsInfo");
        return ds;
    }
    public int usercommand(string str)
    {
        int k;
        SqlCommand com = new SqlCommand(str, con);
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
    public bool userinsert(model m,string price)
    {
        decimal Price;
        try
        {
            Price =decimal .Parse ( price);
        }
        catch
        {
            return false;
        }
        string sql = "insert into tb_GoodsInfo values ('" + m.GoodsName + "','" + m.GoodsKind + "','" + m.GoodsPhoto + "'," +Price + ",'" + m.GoodsIntroduce + "')";
        SqlCommand com = new SqlCommand(sql, con);
        try
        {
           com.ExecuteNonQuery().ToString();            
        }
        catch
        {
            return false;
        }
        return true;
    }
}