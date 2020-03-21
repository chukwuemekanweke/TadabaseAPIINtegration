namespace ModelLayer.APIRequests.Projects
{   
    public class ProjectRecords
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
        public string field_47 { get; set; }
        public string field_48 { get; set; }
        public Field_49 field_49 { get; set; }
        public Field_50 field_50 { get; set; }
    }

    public class Field_49
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

    public class Field_50
    {
        public string start { get; set; }
        public string end { get; set; }
        public string all_day { get; set; }
    }

}
