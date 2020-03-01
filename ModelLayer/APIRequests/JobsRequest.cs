namespace ModelLayer.APIRequests.Jobs
{
   


    public class JobRecords
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
        public string field_38 { get; set; }
    }

}
