using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College.Educat.students
{
    /// <summary>
    /// Summary description for MyPicture
    /// </summary>
    public class MyPicture : IHttpHandler
    {
        readonly EducatContext db = new EducatContext();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/jpeg";
            context.Response.Clear();

            if (!string.IsNullOrEmpty(context.User.Identity.Name) && context.User.Identity.IsAuthenticated)
            {
                byte[] bytes = new byte[1024];
                long studentid = long.Parse(context.User.Identity.Name);

                var std = db.students.FirstOrDefault(x => x.Id == studentid);
                if (std != null)
                {
                    bytes = new byte[std.picture.Length];
                    bytes = std.picture;
                }

                context.Response.BufferOutput = true;
                context.Response.Buffer = true;
                context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                context.Response.AddHeader("content-disposition", "attachment;filename=" + studentid + ".jpg");
                context.Response.BinaryWrite(bytes);
                context.Response.Flush();
                context.Response.End();
            }

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