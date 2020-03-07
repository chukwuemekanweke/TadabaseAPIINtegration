using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;
using ModelLayer.APIRequests;
using ModelLayer.APIRequests.Customers;
using ModelLayer.APIRequests.Employee;
using ModelLayer.APIRequests.Jobs;
using ModelLayer.APIRequests.Orders;
using ModelLayer.APIRequests.Products;
using ModelLayer.APIRequests.Projects;
using ModelLayer.APIRequests.Supliers;
using ModelLayer.APIRequests.Tasks;
using Newtonsoft.Json;
using ServiceLayer;

namespace Tadabase_Demo_Api_Integration.Controllers.ViewControllers
{
    public class RecordsController : Controller
    {

        TableRecordsAPIClient TableRecordsAPIClient { get; }
        public RecordsController(TableRecordsAPIClient tableRecordsAPIClient)
        {
            TableRecordsAPIClient = tableRecordsAPIClient;
        }

        [HttpPost("[action]")]
        public async Task<JsonResult> Employees([FromBody] EmployeeRequest<EmployeeRecord> model)
        {
            GenericPostResponse genericPostResponse =  await TableRecordsAPIClient.SaveEmployee(model.TableId, model.Data);
            return Json(genericPostResponse);
        }

        public IActionResult Index(string tableId , Tables tableName)
        {
            switch (tableName)
            {
               
                case Tables.Projects:
                    return RedirectToAction("Projects",new { tableId});

                    break;
                case Tables.Orders:
                    return RedirectToAction("Orders", new { tableId });

                    break;
                case Tables.Tasks:
                    return RedirectToAction("Tasks", new { tableId });

                    break;
                case Tables.Jobs:
                    return RedirectToAction("Jobs", new { tableId });

                    break;
                case Tables.Supplier:
                    return RedirectToAction("Supplier", new { tableId });

                    break;
                case Tables.Customers:
                    return RedirectToAction("Customers", new { tableId });

                    break;
                case Tables.Employees:
                    return RedirectToAction("Employees", new { tableId });

                    break;
                case Tables.Product:
                    return RedirectToAction("Product", new { tableId });

                    break;
                default:
                    return RedirectToAction("Index", "DataTables");
                    break;
            }
            return View();
        }

       
        [HttpGet("[action]/{tableId}")]
        public async Task<IActionResult> Projects(string tableId)
        {
            ViewBag.TableId = tableId;

            ProjectRecords records = await TableRecordsAPIClient.GetRecrds<ProjectRecords>(tableId);
            return View(records);
        }

        [HttpGet("[action]/{tableId}")]
        public async Task<IActionResult> Orders(string tableId)
        {
            ViewBag.TableId = tableId;

            OrdersRecords records = await TableRecordsAPIClient.GetRecrds<OrdersRecords>(tableId);
            return View(records);
        }

        [HttpGet("[action]/{tableId}")]
        public async Task<IActionResult> Tasks(string tableId)
        {
            ViewBag.TableId = tableId;

            TaskRecords records = await TableRecordsAPIClient.GetRecrds<TaskRecords>(tableId);
            return View(records);
        }

        [HttpGet("[action]/{tableId}")]
        public async Task<IActionResult> Jobs(string tableId)
        {
            ViewBag.TableId = tableId;

            JobRecords records = await TableRecordsAPIClient.GetRecrds<JobRecords>(tableId);
            return View(records);
        }

        [HttpGet("[action]/{tableId}")]
        public async Task<IActionResult> Supplier(string tableId)
        {
            ViewBag.TableId = tableId;

            SupplierRecords records = await TableRecordsAPIClient.GetRecrds<SupplierRecords>(tableId);
            return View(records);
        }

        [HttpGet("[action]/{tableId}")]
        public async Task<IActionResult> Customers(string tableId)
        {
            ViewBag.TableId = tableId;

            CustomerRecords records = await TableRecordsAPIClient.GetRecrds<CustomerRecords>(tableId);
            return View(records);
        }

        [HttpGet("[action]/{tableId}")]
        public async Task<IActionResult> Employees(string tableId)
        {
            ViewBag.TableId = tableId;

            EmployeeRecords records = await TableRecordsAPIClient.GetRecrds<EmployeeRecords>(tableId);
            return View(records);
        }

        [HttpGet("[action]/{tableId}")]
        public async Task<IActionResult> Product(string tableId)
        {
            ViewBag.TableId = tableId;
            ProductRecords records = await TableRecordsAPIClient.GetRecrds<ProductRecords>(tableId);
            return View(records);
        }
    }
}