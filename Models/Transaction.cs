using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace transactionservice.Models
{
    public class Transaction
    {
        [Key]
        [JsonProperty("_id")]
        public string _id { get; set; }
        [JsonProperty("_rev")]
        public string _rev { get; set; }
        [JsonProperty("TransactionType")]
        public string TransactionType { get; set; }
        [JsonProperty("EmpName")]
        public string EmpName { get; set; }
        [JsonProperty("EmpNo")]
        public string EmpNo { get; set; }
        [JsonProperty("NBSCID")]
        public string NBSCID { get; set; }
        [JsonProperty("IBMRole")]
        public string IBMRole { get; set; }
        [JsonProperty("CurrentLoc")]
        public string CurrentLoc { get; set; }
        [JsonProperty("Squad")]
        public string Squad { get; set; }
        [JsonProperty("NewLoc")]
        public string NewLoc { get; set; }

        [JsonProperty("OldRateCardType")]
        public string OldRateCardType { get; set; }

        [JsonProperty("NewRateCardType")]
        public string NewRateCardType { get; set; }

        [JsonProperty("HCAMSrNo")]
        public string HCAMSrNo { get; set; }

        [JsonProperty("OnshoreLead")]
        public string OnshoreLead { get; set; }

        [JsonProperty("OffshoreLead")]
        public string OffshoreLead { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("DateOfReturn")]
        public string DateOfReturn { get; set; }

        [JsonProperty("ServiceType ")]
        public string ServiceType  { get; set; }

        [JsonProperty("DCName")]
        public string DCName { get; set; }
        [JsonProperty("NewDC")]
        public string NewDC { get; set; }

        [JsonProperty("NewLineManager")]
        public string NewLineManager { get; set; }

        [JsonProperty("JoinerandLeaver")]
        public string JoinerandLeaver { get; set; }


    }
}