using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College.Educat.Models.Views
{
    public class StuentView
    {
        EducatContext db = new EducatContext();
        public StuentView()
        {

        }
        public long Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Othername { get; set; }
        public string Gender { get; set; }
        public DateTime dob { get; set; }
        public int currentclassId { get; set; }
        public string CurrentLevel
        {
            get
            {
                return db
                    .classes
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Id == currentclassId).classname;
            }
        }
        public string Currentsession { get; set; }
        public int Currentterm { get; set; }
        public int ArmId { get; set; }
        public string Arm
        {
            get
            {


                return db.Arms.AsNoTracking().FirstOrDefault(X => X.Id == ArmId).armname;
            }
        }
        public string Guardiannames { get; set; }
        public string Guardianphoneno { get; set; }
        public string Guardianemail { get; set; }
        public string Homeaddress { get; set; }
        public string City { get; set; }
        public int? State { get; set; }
        public string StateOfOrigin
        {
            get
            {
                try
                {
                    return db.states.AsNoTracking().FirstOrDefault(x => x.Id == State).statename;
                }
                catch
                {
                    return "";
                }
            }
        }

        public int Yearofentry { get; set; }
        public bool Graduated { get; set; }
        public int Yearofgraduation { get; set; }
        public byte[] Picture { get; set; }
        public long Parentid { get; set; }
    }
}