using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.APIResponses;
using ServiceLayer;

namespace Tadabase_Demo_Api_Integration.Controllers.ViewControllers
{
    public class DataTablesController : Controller
    {

        TableRecordsAPIClient TableRecordsAPIClient { get; }
        public DataTablesController(TableRecordsAPIClient tableRecordsAPIClient)
        {
            TableRecordsAPIClient = tableRecordsAPIClient;
        }


        public async Task<IActionResult> Index()
        {
            TablesForAppResponse tablesForAppResponse =  await TableRecordsAPIClient.GetTablesForApp();
            return View(tablesForAppResponse);
        }
    }
}