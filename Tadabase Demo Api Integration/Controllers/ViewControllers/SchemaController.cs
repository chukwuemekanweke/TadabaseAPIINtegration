using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.APIResponses;
using ServiceLayer;

namespace Tadabase_Demo_Api_Integration.Controllers.ViewControllers
{
    public class SchemaController : Controller
    {
        TableRecordsAPIClient TableRecordsAPIClient { get; }
        public SchemaController(TableRecordsAPIClient tableRecordsAPIClient)
        {
            TableRecordsAPIClient = tableRecordsAPIClient;
        }

        public async Task<IActionResult> Index(string tableId, string tableName)
        {
            ViewBag.TableName = tableName;
            ViewBag.TableId = tableId;
            TableFieldsResponse tableFieldsResponse = await TableRecordsAPIClient.GetFieldsForTables(tableId);
            return View(tableFieldsResponse);
        }
    }
}