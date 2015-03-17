using System;
using DevExpress.Xpo;

namespace LeTien.Object
{

    public partial class Branch : XPObject
    {
        public Session curSession;
        public Branch()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Branch(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.

            this.curSession = session;
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        public string BranchID;

        public string BranchName;

        public string BranchDescription;

        public static string GetNumberOfEmployeesByBranchOid(string Oid, Session session)
        {
            DevExpress.Xpo.DB.SelectedData  res =   session.ExecuteQuery("SELECT COUNT(*) FROM `Employee` WHERE `Branch` = " + Oid);

            if (res.ResultSet[0].Rows.Length > 0)
            {
                return res.ResultSet[0].Rows[0].Values[0].ToString();
            }
            else
            {
                return null;
            }
        }

    }

}