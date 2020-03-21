using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public static class Constants
    {
        public  const string API_BASE_URL = "https://api.tadabase.io";
        public const string LIST_OF_TABLES_URL = "/api/v1/data-tables";
        public const string FIELDS_IN_TABLE_URL = "/api/v1/data-tables/{0}/fields";
        public const string RECORDS_IN_TABLE_URL = "/api/v1/data-tables/{0}/records";

        public const string RECORD_IN_TABLE_URL = "/api/v1/data-tables/{0}/records/{1}";


        public const string SAVE_RECORD = "/api/v1/data-tables/{0}/records";
        public const string UPDATE_RECORD = "/api/v1/data-tables/{0}/records/{1}";
        public const string DELETE_RECORD = "/api/v1/data-tables/{0}/records/{1}";


        public const string TASK_TABLE_ID = "JDXQ80QYRl";
        public const string CUSTOMER_TABLE_ID = "lGArg7rmR6";



    }
}
