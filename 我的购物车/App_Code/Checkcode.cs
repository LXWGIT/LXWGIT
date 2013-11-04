using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

/// <summary>
///checkcode 的摘要说明
/// </summary>
public class Checkcode
{
    HttpResponse Response;
    public static string  num;
    public Checkcode(HttpResponse  response)
    {
        this.Response = response;
    }
   
    public string  getnum()
    {
        Random ran = new Random();
        num = ran.Next(10000, 99999).ToString ();
        Response.Cookies.Add(new HttpCookie("checkcode",num.ToString ()));
        return num;
    }
    public void getimage(string checkcode)
    {
        Bitmap image = new Bitmap((int)(Math.Ceiling(checkcode.Length * 12.5)), 22);
        Graphics G = Graphics.FromImage(image);
        Random ran = new Random();
        G.Clear(Color.White);

        for (int i = 0; i < 2; i++)
        {
            int x1 = ran.Next(image.Width);
            int y1 = ran.Next(image.Height);
            int x2 = ran.Next(image.Width);
            int y2 = ran.Next(image.Height);
            G.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);
        }
        Font font = new Font("Arial", 13, FontStyle.Bold);
        LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.Pink,1.2f,true);
        G.DrawString(checkcode, font, brush, 2, 2);

        for (int i = 0; i < 100; i++)
        {
            int x = ran.Next(image.Width);
            int y = ran.Next(image.Height);
            image.SetPixel(x,y,Color.FromArgb (ran.Next ()));
        }
        G.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);

        MemoryStream m = new MemoryStream();
        image.Save(m, ImageFormat.Gif);

        Response.ClearContent();
        Response.ContentType = "image/gif";
        Response.BinaryWrite(m.ToArray());

        image.Dispose();
        G.Dispose();
    }
}