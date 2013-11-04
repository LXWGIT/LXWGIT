using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///model 的摘要说明
/// </summary>
public class model
{
    public string username;
    public string userpassword;
    public decimal usermoney;

    public string goodsname;
    public string goodskind;
    public string goodsphoto;
    public decimal goodsprice;
    public string goodsintroduce;

    public string GoodsName { get { return goodsname; } set { goodsname = value; } }
    public string GoodsKind { get { return goodskind; } set { goodskind = value; } }
    public string GoodsPhoto { get { return goodsphoto ; } set { goodsphoto  = value; } }
    public decimal  GoodsPrice { get { return goodsprice; } set { goodsprice = value; } }
    public string GoodsIntroduce { get { return goodsintroduce; } set { goodsintroduce = value; } }
}