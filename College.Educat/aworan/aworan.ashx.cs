using College.Educat.Models.Data;
using System.Linq;
using System.Web;

namespace College.Educat.aworan
{
    /// <summary>
    /// Summary description for aworan
    /// </summary>
    public class aworan : IHttpHandler
    {
        readonly EducatContext db = new EducatContext();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/jpeg";
            context.Response.Clear();

            if (!string.IsNullOrEmpty(context.Request.QueryString["sudentid"].ToString()) && context.User.Identity.IsAuthenticated)
            {
                byte[] bytes = new byte[1024];
                long studentid = long.Parse(context.Request.QueryString["sudentid"].ToString());

                var std = db.students.AsNoTracking().FirstOrDefault(x => x.Id == studentid);
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