namespace ModelLayer.APIResponses
{
   

    public class TablesForAppResponse
    {
        public string type { get; set; }
        public Data_Tables[] data_tables { get; set; }
        public int total_items { get; set; }
    }

    public class Data_Tables
    {
        public string id { get; set; }
        public string name { get; set; }
    }

}
