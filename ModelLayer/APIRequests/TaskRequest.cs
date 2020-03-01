namespace ModelLayer.APIRequests.Tasks
{
    class TaskRequest
    {
    }



    public class TaskRecords
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
        public string field_57 { get; set; }
        public string field_58 { get; set; }
        public string field_59 { get; set; }
        public string[] field_60 { get; set; }
        public Field_60_Val[] field_60_val { get; set; }
    }

    public class Field_60_Val
    {
        public string id { get; set; }
        public string val { get; set; }
    }






}
