using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
///sqlconnection 的摘要说明
/// </summary>
public class connection
{
    public static string str;
    public static SqlConnection con;
	public static SqlConnection  getopen()
	{
        con = new SqlConnection(str);
        con.Open();
        return con;
	}
}