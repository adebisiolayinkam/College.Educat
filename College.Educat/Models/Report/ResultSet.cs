using System.Net.Http.Headers;

namespace College.Educat.Models.Report
{
    public class ResultSet
    {

        public string studentid { get; set; }
        public int subjectid { get; set; }
        public string session { get; set; }
        public string term
        {

            get
            {
                switch (termId)
                {
                    case 1:
                        return "FIRST TERM";
                    case 2:
                        return "SECOND TERM";
                    case 3:
                        return "THIRD TERM";
                    default:
                        return "";
                }
            }
        }
        public int termId { get; set; }
        public double ca { get; set; }
        public double exam { get; set; }
        public int position { get; set; }
        public string grade { get; set; }
        public double classaverage { get; set; }
        public string teacherscomment { get; set; }
        public string SubjectName { get; set; }
    }
}