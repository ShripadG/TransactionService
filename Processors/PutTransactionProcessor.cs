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
    public class PutTransactionProcessor : IPutTransactionProcessor
    {
        public async Task<UpdateTransactionResponse> PutExistingTransactionRecord(Transaction transactionUpdateRequest, ICloudantService cloudantService = null)
        {

            if (cloudantService != null)
            {
                var response = await cloudantService.UpdateAsync(transactionUpdateRequest, DBNames.transaction.ToString());
                return JsonConvert.DeserializeObject<UpdateTransactionResponse>(response);
            }
            else
            {
                return new UpdateTransactionResponse();
            }
        }
    }
}
