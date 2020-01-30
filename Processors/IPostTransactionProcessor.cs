using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transactionservice.Models;
using transactionservice.Services;

namespace transactionservice.Processors
{
    public interface IPostTransactionProcessor
    {
        Task<UpdateTransactionResponse> PostNewTransactionRecord(TransactionAddRequest transactionAddRequest, ICloudantService cloudantService = null);
    }
}
