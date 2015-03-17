using System;
using DevExpress.Xpo;

namespace LeTien.Object
{

    public class Attendance : XPObject
    {
        public Attendance()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Attendance(Session session)
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

        public DateTime AttendanceDate;

        public DateTime AttendanceCheckIn;

        public DateTime AttendanceCheckOut;

        public decimal AttendanceChant13;

        public decimal AttendanceChant20;

        public decimal AttendanceChant30;

        public decimal AttendanceChant213;

        public decimal AttendanceChant313;

        public decimal AttendanceAllowance;

        public decimal AttendanceAllowanceChant;

        public decimal AttendanceAllowanceChantMoney;

        public static DevExpress.Xpo.DB.SelectedData GetAttendanceOfEmployeeByDate(string Oid, string AttendanceDate, Session session)
        {
            return session.ExecuteQuery("SELECT * FROM `Attendance` WHERE `Employee` = " + Oid + " AND DATE(`AttendanceDate`) = '" + AttendanceDate + "'");
        }
        public static DevExpress.Xpo.DB.SelectedData GetAttendanceSymbolIDEmployeeByDate(string Oid, string AttendanceDate, Session session)
        {
            return session.ExecuteQuery("SELECT `AttendanceSymbol` FROM `Attendance` WHERE `Employee` = " + Oid + " AND DATE(`AttendanceDate`) = '" + AttendanceDate + "'");
        }

        public static int GetAttendanceSymbolColorEmployeeByDate(string Oid, string AttendanceDate, Session session)
        {
            DevExpress.Xpo.DB.SelectedData resAttendance = Attendance.GetAttendanceSymbolIDEmployeeByDate(Oid, AttendanceDate, session);
            if (resAttendance.ResultSet[0].Rows.Length > 0)
            {
                string attendanceSymbolId = resAttendance.ResultSet[0].Rows[0].Values[0].ToString();
                DevExpress.Xpo.DB.SelectedData res = session.ExecuteQuery("SELECT `SymbolColor` FROM `AttendanceSymbol` WHERE `Oid` = " + attendanceSymbolId);
                if (res.ResultSet[0].Rows.Length > 0)
                {
                    return int.Parse(res.ResultSet[0].Rows[0].Values[0].ToString());
                }
            }
            return 0;
        }
        public static string GetAttendanceSymbolKeyEmployeeByDate(string Oid, string AttendanceDate, Session session)
        {
            DevExpress.Xpo.DB.SelectedData resAttendance = Attendance.GetAttendanceSymbolIDEmployeeByDate(Oid, AttendanceDate, session);
            if (resAttendance.ResultSet[0].Rows.Length > 0)
            {
                string attendanceSymbolId = resAttendance.ResultSet[0].Rows[0].Values[0].ToString();
                DevExpress.Xpo.DB.SelectedData res = session.ExecuteQuery("SELECT `SymbolID` FROM `AttendanceSymbol` WHERE `Oid` = " + attendanceSymbolId);
                if (res.ResultSet[0].Rows.Length > 0)
                {
                    return res.ResultSet[0].Rows[0].Values[0].ToString();
                }
            }
            return null;
        }

        public static string GetAttendanceIdOfEmployeeByDate(string Oid, string AttendanceDate, Session session)
        {
            DevExpress.Xpo.DB.SelectedData res = session.ExecuteQuery("SELECT `Oid` FROM `Attendance` WHERE `Employee` = " + Oid + " AND DATE(`AttendanceDate`) = '" + AttendanceDate + "'");

            if (res.ResultSet[0].Rows.Length > 0)
            {
                return res.ResultSet[0].Rows[0].Values[0].ToString();
            }
            else
            {
                return null;
            }
        }

        public AttendanceSymbol AttendanceSymbol
        {
            get;
            set;
        }

        public Employee Employee
        {
            get;
            set;
        }

    }

}