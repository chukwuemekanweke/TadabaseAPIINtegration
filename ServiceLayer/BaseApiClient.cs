using ModelLayer.Configurations;
using Newtonsoft.Json;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class BaseApiClient
    {

        
        protected HttpClient HttpClient { get; }
        protected AppSettings AppSettings { get; }
        protected ILoggerManager LoggerManager { get; }
        public BaseApiClient(ILoggerManager loggerManager,AppSettings appSettings)
        {
            LoggerManager = loggerManager;
            AppSettings = appSettings;
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(Constants.API_BASE_URL);
            HttpClient.DefaultRequestHeaders.Clear();
            HttpClient.DefaultRequestHeaders.Add("X-Tadabase-App-id", AppSettings.AppId);
            HttpClient.DefaultRequestHeaders.Add("X-Tadabase-App-Key", AppSettings.AppKey);
            HttpClient.DefaultRequestHeaders.Add("X-Tadabase-App-Secret", AppSettings.AppSecret);
            
        }

        public async Task<T> ProcessResponse<T>(HttpResponseMessage responseMessage) where T : class
        {
            try
            {
                HttpStatusCode statusCode = responseMessage.StatusCode;
                if (statusCode == HttpStatusCode.OK)
                {

                    string content = await responseMessage.Content.ReadAsStringAsync();
                    return  JsonConvert.DeserializeObject<T>(content);
                }
                else
                {
                    LoggerManager.LogError($"Got Http Status Code Of {statusCode}");
                    return null;
                }
            }
            catch(Exception ex)
            {
                LoggerManager.LogError(ex.Message);
                return null;
            }
        }

    }
}
