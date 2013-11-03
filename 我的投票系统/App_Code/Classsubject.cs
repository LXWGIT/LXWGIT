using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
///Classsubject 的摘要说明
/// </summary>
public class Classsubject
{
    SqlConnection con;
	public Classsubject(string str)
	{
        connection.str = str;
        this.con = connection.getcon();
	}
    public DataSet singlesubjectmanage(string str)
    {
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = com;
        DataSet ds = new DataSet();
        da.Fill(ds, "votemaster");
        return ds;
    }
    public int singledelete(int id)
    {
      int k;
      string str="delete from voteMaster where id="+id+"";
      SqlCommand com = new SqlCommand(str, con);
      try
      {
          k = int.Parse(com.ExecuteNonQuery().ToString());
      }
      catch(Exception ex)
      {
          throw new Exception(ex.Message, ex);
      }
     
      return k;
      
    
    }
    public DataSet singleselect(int id)
    {
        string str = "select * from voteMaster where id=" + id + "";
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = com;
        da.Fill(ds, "vote");
      
        return ds;
    }
    public int singleupdate(int id, model m)
    {
        string str = "update voteMaster set voteTitle='" + m.votetitle + "',voteSum='" + m.votesum + "',endTime='" + m.endtime + "' where id=" + id + "";
        SqlCommand com = new SqlCommand(str, con);
        int k;
        try
        {
            k = int.Parse(com.ExecuteNonQuery().ToString());
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
       
        return k;
    }
    public DataSet  singleselect1(model m)
    {
        string str = "select * from voteMaster where voteTitle like '%" + m.votetitle + "%'";
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteNonQuery();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = com;
        da.Fill(ds, "vote");
      
        return ds;
    }
    public DataSet checkvote(model m)
    {
        string str = "select * from voteMaster where voteTitle='" + m.votetitle + "'";
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = com;
        da.Fill(ds, "vote");
        
        return ds;
    }
    public int insertvote(model m)
    { 
       string str="insert into voteMaster (voteTitle,image,endTime,mode) values ('"+m.votetitle+"','"+m.image +"','"+m.endtime+"','"+m.mode +"')";
       SqlCommand  com=new SqlCommand (str ,con );
       int k;
        try 
        {
           k=int.Parse (com.ExecuteNonQuery().ToString ());
        }
        catch (Exception  ex)
        {
           throw new Exception (ex.Message ,ex );
        }
       
        return k;
    }
    public DataSet selectvoteid(string votetitle)
    { 
        string str="select * from voteMaster where voteTitle='"+votetitle+"'";
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        da.SelectCommand = com;
        da.Fill(ds, "vote");
       
        return ds;
    }
    public int insertconfig(model m)
    { 
        string str="insert into voteConfig (id,checkIp) values ("+m.confiid+",'"+m.confiip +"')";
        SqlCommand com = new SqlCommand(str, con);
        int k;
        try
        {
            k = int.Parse(com.ExecuteNonQuery().ToString ());
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
       
        return k;
    }
    public int insertdetails(model m)
    {
        string str = "insert into voetDetails (voteItem,id) values ('" + m.detailitem + "','" + m.detailid + "')";
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
    public DataSet dstype()
    {
        string str = "select * from Topics ";
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        da.SelectCommand = com;
        da.Fill(ds, "type");        
        return ds;
    }
    public int typedelete(model m)
    {
        int k;
        string str = "delete from Topics where t_id=" + m.topicsid + "";
        SqlCommand com = new SqlCommand(str, con);
        try
        {
           k = com.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        return k;
    }
    public int typeupdate(model m)
    {
        int k;
        string str = "update Topics set t_IsCurrent=1 where t_id="+m.topicsid +"";
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
    public int typeupdate1(model m)
    {
        int k;
        string str = "update Topics set t_IsCurrent=0 where t_id<>" + m.topicsid + "";
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
    public DataSet dstype1(int t_id)
    { 
        string str="select * from Topics where t_id="+t_id +"";
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        da.SelectCommand = com;
        da.Fill(ds, "type");
        return ds;
    }
    public int typeinsert(model m)
    {
        string str = "insert into Topics (t_name,t_content,t_IsCurrent) values ('" + m.topicsname + "','" + m.topicscontent + "','"+m.topicsbool+"')";
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
    public DataSet subjectds(int tid)
    {
        string str = "select * from Subjects where s_tid=" + tid.ToString () + "";
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = com;
        DataSet ds = new DataSet();
        da.Fill(ds, "subject");
        return ds;
    }
    public DataSet subjectds1(int s_id)
    {
        string str = "select * from Subjects where s_id=" + s_id + "";
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        da.SelectCommand = com;
        da.Fill(ds, "subject");
        return ds;
    }
    public int subjectdelete(int s_id)
    {
        int k;
        string str = "delete from Subjects where s_id=" + s_id + "";
        SqlCommand com = new SqlCommand(str, con);
        try
        {
            k = int.Parse(com.ExecuteNonQuery().ToString());
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);

        }
        return k ;
    }
    public int subjectupdate(int s_id,string name)
    { 
       string str="update Subjects set s_name='"+name+"',s_mode=1 where s_id="+s_id +"";
       SqlCommand  com=new SqlCommand (str ,con );
       int k;
        try 
        {
          k=int.Parse (com.ExecuteNonQuery ().ToString ());
        }
        catch (Exception ex)
        {
           throw new Exception (ex.Message ,ex );
        }
        return k;
    }
    public DataSet itemds(int i_sid)    
    {
        string str = "select * from Items where i_sid=" + i_sid + "";
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        da.SelectCommand = com;
        da.Fill(ds, "item");
        return ds;
    }
    public DataSet itemds1(int i_id)
    {
        string str = "select * from Items where i_id=" + i_id + "";
        SqlCommand com = new SqlCommand(str, con);
        com.ExecuteScalar();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        da.SelectCommand = com;
        da.Fill(ds, "item");
        return ds;
    }
    public int itemupdate(string name,int id)
    {
        string str = "update Items set i_name='" + name.ToString() + "' where i_id=" + id.ToString() + "";
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
    public int itemdelete(int i_id)
    {
        string str = "delete from Items where i_id=" + i_id + "";
        SqlCommand com = new SqlCommand(str, con);
        int k;
        try
        {
            k = int.Parse(com.ExecuteNonQuery().ToString());
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        return k; 
    }
    public int iteminsert(string i_name,int i_count,int i_sid)
    {
        string str = "insert into Items values ('" + i_name + "','" + i_count + "','" + i_sid + "')";
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
