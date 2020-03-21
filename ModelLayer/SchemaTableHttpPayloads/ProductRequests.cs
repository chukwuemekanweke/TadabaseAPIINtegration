namespace ModelLayer.APIRequests.Products
{
    class ProductRequests
    {
    }


    public class ProductRecords
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
        public string field_65 { get; set; }
        public int field_66 { get; set; }
        public Field_73 field_73 { get; set; }
        public string[] field_75 { get; set; }
        public Field_75_Val[] field_75_val { get; set; }
    }

    public class Field_73
    {
        public string src { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string public_id { get; set; }
    }

    public class Field_75_Val
    {
        public string id { get; set; }
        public string val { get; set; }
    }

}
