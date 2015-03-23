using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class Religion : XPObject
    {
        public Religion()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Religion(Session session)
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


        #region "Variables"
        [DisplayName ("M� T�n Gi�o")]
        public string ReligionID;


        [DisplayName ("T�n T�n Gi�o")]
        public string ReligionName;
        #endregion


    }

}