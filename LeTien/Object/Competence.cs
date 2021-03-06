using System;
using DevExpress.Xpo;

namespace LeTien.Object
{

    public class Competence : XPObject
    {
        public Competence()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Competence(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        public string CompetenceID;

        public string CompetenceName;

        public string CompetenceDescription;

        public static string GetNumberOfEmployeesByCompetenceOid(string Oid, Session session)
        {
            DevExpress.Xpo.DB.SelectedData res = session.ExecuteQuery("SELECT COUNT(*) FROM `Employee` WHERE `Competence` = " + Oid);

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