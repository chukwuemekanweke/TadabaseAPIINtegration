namespace ModelLayer.APIRequests.Employee
{



    public class EmployeeSingleRecord
    {
        public string type { get; set; }
        public EmployeeRecord item { get; set; }
    }


    public class EmployeeRecords
    {
        public EmployeeRecord[] items { get; set; }
        public string type { get; set; }
        public int total_items { get; set; }
        public int total_pages { get; set; }
        public int current_page { get; set; }
    }



    public class EmployeeRecord
    {
        public string id { get; set; }
        public string field_51 { get; set; }
        public string field_53 { get; set; }
        public Field_54 field_54 { get; set; }
        public string field_55 { get; set; }
        public Field_52 field_52 { get; set; }
        public Field_56 field_56 { get; set; }
    }

    public class Field_54
    {
        public string src { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string public_id { get; set; }
    }

    public class Field_52
    {
        public string address { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        public string lng { get; set; }
        public string lat { get; set; }
    }

    public class Field_56
    {
        public string title { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
    }

}
