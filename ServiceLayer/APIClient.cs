using ModelLayer.APIRequests.Customers;
using ModelLayer.APIRequests.Employee;
using ModelLayer.APIRequests.Jobs;
using ModelLayer.APIRequests.Orders;
using ModelLayer.APIRequests.Products;
using ModelLayer.APIRequests.Projects;
using ModelLayer.APIRequests.Supliers;
using ModelLayer.APIRequests.Tasks;
using ModelLayer.APIResponses;
using ModelLayer.Configurations;
using ServiceLayer.Interfaces;
using System.Net.Http;
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

        public async Task<T> GetRecrds<T>(string tableId) where T:class
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            T response = await ProcessResponse<T>(httpResponseMessage);
            return response;
        }

        public async Task<ProductRecords> GetProductRecords(string tableId)
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            ProductRecords response = await ProcessResponse<ProductRecords>(httpResponseMessage);
            return response;
        }


        public async Task<EmployeeRecords> GetEmployeeRecords(string tableId)
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            EmployeeRecords response = await ProcessResponse<EmployeeRecords>(httpResponseMessage);
            return response;
        }

        public async Task<SupplierRecords> GetSupplierRecords(string tableId)
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            SupplierRecords response = await ProcessResponse<SupplierRecords>(httpResponseMessage);
            return response;
        }

        public async Task<ProjectRecords> GetProjectRecords(string tableId)
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            ProjectRecords response = await ProcessResponse<ProjectRecords>(httpResponseMessage);
            return response;
        }


        public async Task<JobRecords> GetJobRecords(string tableId)
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            JobRecords response = await ProcessResponse<JobRecords>(httpResponseMessage);
            return response;
        }

        public async Task<TaskRecords> GetTaskRecords(string tableId)
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            TaskRecords response = await ProcessResponse<TaskRecords>(httpResponseMessage);
            return response;
        }

        public async Task<CustomerRecords> GetCustomersRecords(string tableId)
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(Constants.LIST_OF_TABLES_URL);
            CustomerRecords response = await ProcessResponse<CustomerRecords>(httpResponseMessage);
            return response;
        }

        public async Task<OrdersRecords> GetOrderRecords(string tableId)
        {
            string url = string.Format(Constants.RECORDS_IN_TABLE_URL, tableId);
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(Constants.LIST_OF_TABLES_URL);
            OrdersRecords response = await ProcessResponse<OrdersRecords>(httpResponseMessage);
            return response;
        }


        #endregion

    }
}
