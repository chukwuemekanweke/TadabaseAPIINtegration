namespace ModelLayer.APIResponses
{    
    public class TableFieldsResponse
    {
        public string type { get; set; }
        public Field[] fields { get; set; }
        public int total_items { get; set; }
    }

    public class Field
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

}
