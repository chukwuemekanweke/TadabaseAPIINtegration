namespace ModelLayer.APIRequests.Orders
{
    



    public class OrdersRecords
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
        public string field_43 { get; set; }
        public string field_44 { get; set; }
        public string[] field_45 { get; set; }
        public object field_72 { get; set; }
        public object field_74 { get; set; }
        public object[] field_45_val { get; set; }
        public Field_72_Val[] field_72_val { get; set; }
        public Field_74_Val[] field_74_val { get; set; }
    }

    public class Field_72_Val
    {
        public string id { get; set; }
        public string val { get; set; }
    }

    public class Field_74_Val
    {
        public string id { get; set; }
        public string val { get; set; }
    }

}
