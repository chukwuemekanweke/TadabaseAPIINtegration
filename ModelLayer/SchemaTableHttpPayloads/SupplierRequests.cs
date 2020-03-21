namespace ModelLayer.APIRequests.Supliers
{
    class SupplierRequests
    {
    }



    public class SupplierRecords
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
        public string field_68 { get; set; }
        public string field_69 { get; set; }
        public string field_70 { get; set; }
        public string field_71 { get; set; }
    }

}
