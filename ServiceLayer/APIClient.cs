using ModelLayer.APIResponses;
using ModelLayer.Configurations;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class TableRecordsAPIClient:BaseApiClient
    {
        public TableRecordsAPIClient(ILoggerManager loggerManager, AppSettings appSettings) : base(loggerManager, appSettings)
        {
        }

        /// <summary>
        /// Returns the list of tables for a particular application on Tadabae
        /// </summary>
        /// <returns>TablesForAppResponse</returns>
        public async Task<TablesForAppResponse> GetTablesForApp()
        {
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(Constants.LIST_OF_TABLES_URL);
            TablesForAppResponse tablesResponse = await ProcessResponse<TablesForAppResponse>(httpResponseMessage);
            return tablesResponse;
        }

      
       /// <summary>
       /// Retrieves the fields in a Tadabase table
       /// </summary>
       /// <param name="tableId">the table id on tadabase</param>
       /// <returns>TableFieldsResponse</returns>
        public async Task<TableFieldsResponse> GetFieldsForTables(string tableId)
        {
            string url = string.Format(Constants.FIELDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(Constants.LIST_OF_TABLES_URL);
            TableFieldsResponse tableFieldsResponse = await ProcessResponse<TableFieldsResponse>(httpResponseMessage);
            return tableFieldsResponse;
        }

    }
}
