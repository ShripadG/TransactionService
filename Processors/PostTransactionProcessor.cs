using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transactionservice.Models;
using transactionservice.Services;
using Newtonsoft.Json;
using employeeservice.Common;

namespace transactionservice.Processors
{
    public class PostTransactionProcessor : IPostTransactionProcessor
    {
        public async Task<UpdateTransactionResponse> PostNewTransactionRecord(TransactionAddRequest transactionAddRequest, ICloudantService cloudantService = null)
        {            
            if (cloudantService != null)
            {
                var response = await cloudantService.CreateAsync(transactionAddRequest, DBNames.transaction.ToString());
                return JsonConvert.DeserializeObject<UpdateTransactionResponse>(response);
            }
            else
            {
                return new UpdateTransactionResponse();
            }
        }
    }
}
