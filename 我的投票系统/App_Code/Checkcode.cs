using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
/// <summary>
///Checkcode 的摘要说明
/// </summary>
public class Checkcode
{
    HttpResponse response;
    public Checkcode(HttpResponse response)
    { 
      this.response =response ;
    }
    public string getnum()
    {
        Random ran = new Random();
        string num;
        num = ran.Next(1000, 9999).ToString();
        response.Cookies.Add(new HttpCookie("num", num));
        return num;
    }
    public void getcheckcode(string num)
    {
        Bitmap image = new Bitmap((int)(Math.Ceiling(num.Length * 12.5)), 22);
        Graphics g = Graphics.FromImage(image);
        Random ran = new Random();
        g.Clear(Color.White);

        for (int i = 0; i < 2; i++)
        {
            int x1 = ran.Next(image.Width);
            int y1 = ran.Next(image.Height);
            int x2 = ran.Next(image.Width);
            int y2 = ran.Next(image.Height);

            g.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);
        }
        Font f = new Font("Arial", 13, FontStyle.Bold);
        LinearGradientBrush brush = new LinearGradientBrush(new Rectangle( 0, 0,image.Width, image.Height), Color.Pink, Color.Blue, 1.2f, true);
        g.DrawString(num, f, brush, 2, 2);

        for (int i = 0; i < 100; i++)
        {
            int x = ran.Next(image.Width);
            int y = ran.Next(image.Height);
            image.SetPixel(x, y, Color.FromArgb(ran.Next()));
        }
        g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);

        MemoryStream M = new MemoryStream();
        image.Save(M, ImageFormat.Gif);

        response.ClearContent();
        response.ContentType = "image/gif";
        response.BinaryWrite(M.ToArray());

        image.Dispose();
        g.Dispose();
    }
}