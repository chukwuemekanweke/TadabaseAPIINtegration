﻿using ModelLayer.APIRequests.Customers;
using ModelLayer.APIRequests.Employee;
using ModelLayer.APIRequests.Jobs;
using ModelLayer.APIRequests.Orders;
using ModelLayer.APIRequests.Products;
using ModelLayer.APIRequests.Projects;
using ModelLayer.APIRequests.Supliers;
using ModelLayer.APIRequests.Tasks;
using ModelLayer.APIResponses;
using ModelLayer.Configurations;
using Newtonsoft.Json;
using ServiceLayer.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class TableRecordsAPIClient : BaseApiClient
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
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            TableFieldsResponse tableFieldsResponse = await ProcessResponse<TableFieldsResponse>(httpResponseMessage);
            return tableFieldsResponse;
        }

        #region Retrieving Records

        public async Task<T> GetRecrds<T>(string tableId) where T : class
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            T response = await ProcessResponse<T>(httpResponseMessage);
            return response;
        }



        #endregion




        #region Save Records

        public async Task SaveEmployee(string tableId, EmployeeRecord employeeRecord)
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("field_56[title]", employeeRecord.field_56.title);
            keyValuePairs.Add("field_56[first_name]", employeeRecord.field_56.first_name);
            keyValuePairs.Add("field_56[middle_name]", employeeRecord.field_56.middle_name);
            keyValuePairs.Add("field_56[last_name]", employeeRecord.field_56.last_name);

            keyValuePairs.Add("field_52[address]", employeeRecord.field_52.address);
            keyValuePairs.Add("field_52[address2]", employeeRecord.field_52.address2);
            keyValuePairs.Add("field_52[city]", employeeRecord.field_52.city);
            keyValuePairs.Add("field_52[state]", employeeRecord.field_52.state);
            keyValuePairs.Add("field_52[country]", employeeRecord.field_52.country);
            keyValuePairs.Add("field_52[zip]", employeeRecord.field_52.zip);
            keyValuePairs.Add("field_52[lng]", employeeRecord.field_52.lng);
            keyValuePairs.Add("field_52[lat]", employeeRecord.field_52.lat);

            keyValuePairs.Add("field_51", employeeRecord.field_51);
            keyValuePairs.Add("field_53", employeeRecord.field_53);

            StringContent content = new StringContent(JsonConvert.SerializeObject(keyValuePairs), Encoding.UTF8, "application/json");

            HttpResponseMessage httpResponseMessage = await HttpClient.PostAsync(url, content);
        }


        #endregion

    }
}
