using System;
using DevExpress.Xpo;

namespace LeTien.Object
{

    public class PublicHoliday : XPObject
    {
        public PublicHoliday()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public PublicHoliday(Session session)
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

        public string PublicHolidayName;
        public DateTime PublicHolidayStart;
        public DateTime PublicHolidayEnd;
        public string PublicHolidayDescription;
    }

}