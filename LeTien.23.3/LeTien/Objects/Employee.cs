using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class Employee : XPObject
    {
        public Employee()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Employee(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public string employee_id
        {
            get;
            set;
        }
        public string first_name
        {
            get;
            set;
        }

        public string last_name
        {
            get;
            set;
        }

        public int gender
        {
            get;
            set;
        }

        public string atm
        {
            get;
            set;
        }

        public DateTime birthday
        {
            get;
            set;
        }

        public string birthplace
        {
            get;
            set;
        }

        public string identity_card_id
        {
            get;
            set;
        }

        public DateTime identity_card_date
        {
            get;
            set;
        }

        public string identity_card_place
        {
            get;
            set;
        }

        public string religious
        {
            get;
            set;
        }

        public string nationality
        {
            get;
            set;
        }

        public string educated
        {
            get;
            set;
        }

        public Competence competence
        {
            get;
            set;
        }

        public string permanent_address
        {
            get;
            set;
        }

        public string temporary_address
        {
            get;
            set;
        }

        public string mobile_number
        {
            get;
            set;
        }

        public string home_phone_number
        {
            get;
            set;
        }

        public string marital_status
        {
            get;
            set;
        }

        public DateTime date_of_entry
        {
            get;
            set;
        }

        public string insurance_number
        {
            get;
            set;
        }

        public DateTime insurance_date
        {
            get;
            set;
        }

        public string labor_contract_number
        {
            get;
            set;
        }

        public DateTime labor_contract_sign_date
        {
            get;
            set;
        }

        public int labor_contract_type
        {
            get;
            set;
        }

        public DateTime labor_contract_from_date
        {
            get;
            set;
        }

        public DateTime labor_contract_to_date
        {
            get;
            set;
        }

        public double basic_salary
        {
            get;
            set;
        }

        public byte[] image
        {
            get;
            set;
        }

        public Branch branch
        {
            get;
            set;
        }

        public Attendance attendance
        {
            get;
            set;
        }


        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}