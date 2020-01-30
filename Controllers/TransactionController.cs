using Microsoft.AspNetCore.Mvc;
using transactionservice.Models;
using transactionservice.Services;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.IO;
using ExcelDataReader;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.PlatformAbstractions;
using transactionservice.Processors;
using employeeservice.Common;

namespace transactionservice.Controllers
{
    /// <summary>
    /// This class contains methods for CRUD operations
    /// </summary>
    [Route("api/[controller]")]
    public class TransactionController : Controller    
    {
        private readonly HtmlEncoder _htmlEncoder;
        private readonly ICloudantService _cloudantService;
        private readonly IHelper _helper;
        private readonly IPostTransactionProcessor _postTransactionProcessor;
        private readonly IPutTransactionProcessor _putTransactionProcessor;

        /// <summary>
        /// The default constructor 
        /// </summary>
        /// <param name="htmlEncoder"></param>
        /// <param name="postEmployeeProcessor"></param>
        /// <param name="putEmployeeProcessor"></param>
        /// <param name="helper"></param>
        /// <param name="cloudantService"></param>
        public TransactionController(HtmlEncoder htmlEncoder, IPostTransactionProcessor postTransactionProcessor, IPutTransactionProcessor putTransactionProcessor, IHelper helper,ICloudantService cloudantService = null)
        {
            _cloudantService = cloudantService;
            _helper = helper;
            _postTransactionProcessor = postTransactionProcessor;
            _putTransactionProcessor = putTransactionProcessor;
            _htmlEncoder = htmlEncoder;
        }
       
        /// <summary>
        /// Get all the records
        /// </summary>
        /// <returns>returns all records from database</returns>
        [HttpGet]
        public async Task<dynamic> Get()
        {
            if (_cloudantService == null)
            {
                return new string[] { "No database connection" };
            }
            else
            {
                return await _cloudantService.GetAllAsync(DBNames.transaction.ToString());
            }
        }

       
        /// <summary>
        /// Get record by ID
        /// </summary>
        /// <param name="id">ID to be selected</param>
        /// <returns>record for the given id</returns>
        [HttpGet("id")]
        public async Task<dynamic> GetByID(string id)
        {
            if (_cloudantService == null)
            {
                return new string[] { "No database connection" };
            }
            else
            {
                var response = await _cloudantService.GetByIdAsync(id, DBNames.transaction.ToString());
                return JsonConvert.DeserializeObject<Transaction>(response);
            }
        }

        /// <summary>
        /// Create a new record
        /// </summary>
        /// <param name="transaction">New record to be created</param>
        /// <returns>status of the newly added record</returns>
        [HttpPost]
        public async Task<UpdateTransactionResponse> Post([FromBody]TransactionAddRequest transaction)
        {
            if (_postTransactionProcessor != null)
            {                
                return await _postTransactionProcessor.PostNewTransactionRecord(transaction, _cloudantService);
            }
            else
            {
                return new UpdateTransactionResponse();
            }
        }

        /// <summary>
        /// Update an existing record by giving _id and _rev values
        /// </summary>
        /// <param name="transaction">record to be updated for given _id and _rev</param>
        /// <returns>status of the record updated</returns>
        [HttpPut]
        public async Task<dynamic> Update([FromBody]Transaction transaction)
        {
            if (_postTransactionProcessor != null)
            {
                return await _putTransactionProcessor.PutExistingTransactionRecord(transaction, _cloudantService);
            }
            else
            {
                return new string[] { "No database connection" };
            }
        }


        /// <summary>
        /// Delete the record for the given id
        /// </summary>
        /// <param name="id">record id to be deleted</param>
        /// <param name="rev">revision number of the record to be deleted</param>
        /// <returns>status of the record deleted</returns>
        [HttpDelete]
        public async Task<dynamic> Delete(string id, string rev)
        {
            if (_cloudantService != null)
            {
                return await _cloudantService.DeleteAsync(id, rev, DBNames.transaction.ToString());
                //Console.WriteLine("Update RESULT " + response);
                //return new string[] { employee.IBMEmailID, employee._id, employee._rev };
                //return JsonConvert.DeserializeObject<UpdateEmployeeResponse>(response.Result);
            }
            else
            {
                return new string[] { "No database connection" };
            }
        }

         
    }
}
