namespace ModelLayer.APIRequests.Customers
{
   


    public class CustomerRecords
    {
        public Item[] items { get; set; }
        public string type { get; set; }
        public int total_items { get; set; }
        public int total_pages { get; set; }
        public int current_page { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string field_41 { get; set; }
        public int field_42 { get; set; }
        public string[] field_61 { get; set; }
        public string field_62 { get; set; }
        public string field_63 { get; set; }
        public string field_64 { get; set; }
        public Field_39 field_39 { get; set; }
        public Field_40 field_40 { get; set; }
    }

    public class Field_39
    {
        public string title { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
    }

    public class Field_40
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

}
