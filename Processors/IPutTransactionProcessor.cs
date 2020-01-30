using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transactionservice.Models;
using transactionservice.Services;

namespace transactionservice.Processors
{
    public interface IPutTransactionProcessor
    {
        Task<UpdateTransactionResponse> PutExistingTransactionRecord(Transaction transactionUpdateRequest, ICloudantService cloudantService = null);
    }
}
