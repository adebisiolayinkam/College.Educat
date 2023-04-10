using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College.Educat.aworan
{
    /// <summary>
    /// Summary description for ShowLogo
    /// </summary>
    public class ShowLogo : IHttpHandler
    {
        readonly EducatContext db = new EducatContext();
        public void ProcessRequest(HttpContext context)
        {
            byte[] bytes = new byte[1024];
            //long studentid = long.Parse(context.Request.QueryString["sudentid"].ToString());

            var std = db.schoolsetups.AsNoTracking().FirstOrDefault();
            if (std != null)
            {
                bytes = new byte[std.logo.Length];
                bytes = std.logo;
            }

            context.Response.BufferOutput = true;
            context.Response.Buffer = true;
            context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            context.Response.AddHeader("content-disposition", $"attachment;filename=schooollogo.jpg");
            context.Response.BinaryWrite(bytes);
            context.Response.Flush();
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}