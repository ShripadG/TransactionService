using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace transactionservice.Models
{
    public class Employee
    {
        [Key]
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("_id")]
        public string _id { get; set; }
        [JsonProperty("_rev")]
        public string _rev { get; set; }
        [JsonProperty("UnformattedEmployeeId")]
        public string UnformattedEmployeeId { get; set; }
        [JsonProperty("FormattedEmployeedId")]
        public string FormattedEmployeedId { get; set; }
        [JsonProperty("HCAMID")]
        public string HCAMID { get; set; }
        [JsonProperty("CID")]
        public string CID { get; set; }
        [JsonProperty("EmployeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty("IBMEmailID")]
        public string IBMEmailID { get; set; }

        [JsonProperty("NationwideEmailID")]
        public string NationwideEmailID { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("RoleAtIBM")]
        public string RoleAtIBM { get; set; }

        [JsonProperty("ContractService")]
        public string ContractService { get; set; }

        [JsonProperty("DGDC")]
        public string DGDC { get; set; }

        [JsonProperty("DGDCSquad")]
        public string DGDCSquad { get; set; }

        [JsonProperty("PortfolioLeadOffshore")]
        public string PortfolioLeadOffshore { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("LOB")]
        public string LOB { get; set; }

        [JsonProperty("EmployeeType")]
        public string EmployeeType { get; set; }

        [JsonProperty("WorkLocation")]
        public string WorkLocation { get; set; }

        [JsonProperty("CurrentWorkLocation")]
        public string CurrentWorkLocation { get; set; }

        [JsonProperty("LocationStatus")]
        public string LocationStatus { get; set; }

        [JsonProperty("LandedHCAMorIA")]
        public string LandedHCAMorIA { get; set; }

        [JsonProperty("BandonJoiningNationwide")]
        public string BandonJoiningNationwide { get; set; }

        [JsonProperty("CurrentBand")]
        public string CurrentBand { get; set; }

       

        ///// <summary>
        ///// 
        ///// </summary>
        //private string _AccountOnboardDate;

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonProperty("AccountOnboardDate")]
        //public string AccountOnboardDate
        //{
        //    get
        //    {
        //        DateTime dateValue;
        //        if (DateTime.TryParse(_AccountOnboardDate, new CultureInfo("en-GB"),DateTimeStyles.None, out dateValue))
        //            return dateValue.ToShortDateString();
        //        else
        //            return null;
        //    }
        //    set
        //    {
        //        DateTime dateValue;
        //        if (DateTime.TryParse(value, new CultureInfo("en-GB"), DateTimeStyles.None, out dateValue))
        //            _AccountOnboardDate = dateValue.ToShortDateString();
        //        else
        //            _AccountOnboardDate = null;
        //        //_AccountOnboardDate = value;
        //    }
        //}

        [JsonProperty("AccountOnboardDate")]
        public string AccountOnboardDate { get; set; }

        [JsonProperty("OnboardingReqRecdDate")]
        public string OnboardingReqRecdDate { get; set; }

        [JsonProperty("AccountOffboardingOffboardedDate")]
        public string AccountOffboardingOffboardedDate { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //private string _AccountOffboardingOffboardedDate;

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonProperty("AccountOffboardingOffboardedDate")]
        //public string AccountOffboardingOffboardedDate
        //{
        //    get
        //    {
        //        DateTime dateValue;
        //        if (DateTime.TryParse(_AccountOffboardingOffboardedDate, new CultureInfo("en-GB"), DateTimeStyles.None, out dateValue))
        //            return dateValue.ToShortDateString();
        //        else
        //            return null;
        //    }
        //    set
        //    {
        //        DateTime dateValue;
        //        if (DateTime.TryParse(value, new CultureInfo("en-GB"), DateTimeStyles.None, out dateValue))
        //            _AccountOffboardingOffboardedDate = dateValue.ToShortDateString();
        //        else
        //            _AccountOffboardingOffboardedDate = null;
        //        //_AccountOffboardingOffboardedDate = value;
        //    }
        //}

        [JsonProperty("OffboardingReqRecdDate")]
        public string OffboardingReqRecdDate { get; set; }

        [JsonProperty("ReasonforLeaving")]
        public string ReasonforLeaving { get; set; }

        [JsonProperty("SourceofInformation")]
        public string SourceofInformation { get; set; }

        [JsonProperty("Remarks")]
        public string Remarks { get; set; }

        [JsonProperty("RowAddedDate")]
        public string RowAddedDate { get; set; }

        [JsonProperty("BandCategoriesFormulaeBased")]
        public string BandCategoriesFormulaeBased { get; set; }

        [JsonProperty("CountryFormulaeBased")]
        public string CountryFormulaeBased { get; set; }

        [JsonProperty("OnboardDate")]
        public string OnboardDate { get; set; }

        [JsonProperty("OnboardRequestReceivedDate")]
        public string OnboardRequestReceivedDate { get; set; }

        [JsonProperty("OnboardingrequestdaysSLA")]
        public string OnboardingrequestdaysSLA { get; set; }

        [JsonProperty("OnboardingreqdaysSLAcategories")]
        public string OnboardingreqdaysSLAcategories { get; set; }

        [JsonProperty("OffboardDate")]
        public string OffboardDate { get; set; }

        [JsonProperty("OffboardReqRecdDate")]
        public string OffboardReqRecdDate { get; set; }

        [JsonProperty("Offboardingrequestdayscategories")]
        public string Offboardingrequestdayscategories { get; set; }

        [JsonProperty("OffboardingrequestdaysSLAcategories")]
        public string OffboardingrequestdaysSLAcategories { get; set; }

        [JsonProperty("TenureinMonths")]
        public string TenureinMonths { get; set; }

        [JsonProperty("TenureCategories")]
        public string TenureCategories { get; set; }

        [JsonProperty("IBMID")]
        public string IBMID { get; set; }

        [JsonProperty("PMPEndDate")]
        public string PMPEndDate { get; set; }

        [JsonProperty("DaysBetween")]
        public string DaysBetween { get; set; }

        [JsonProperty("Action")]
        public string Action { get; set; }

        [JsonProperty("EndDate")]
        public string EndDate { get; set; }

        [JsonProperty("Billable")]
        public string Billable { get; set; }

        [JsonProperty("FTE")]
        public string FTE { get; set; }

        [JsonProperty("ClientBillable")]
        public string ClientBillable { get; set; }

        [JsonProperty("WeeklyHours")]
        public string WeeklyHours { get; set; }

        [JsonProperty("RoleLevel")]
        public string RoleLevel { get; set; }

        [JsonProperty("DailyRatePrice")]
        public string DailyRatePrice { get; set; }

        [JsonProperty("DailyCost")]
        public string DailyCost { get; set; }

        [JsonProperty("IsDeleted")]
        public string IsDeleted { get; set; }

        [JsonProperty("LoginID")]
        public string LoginID { get; set; }

        [JsonProperty("dateupdated")]
        public string dateupdated { get; set; }

        [JsonProperty("NBSCostCentre")]
        public string NBSCostCentre { get; set; }

        [JsonProperty("ServiceType")]
        public string ServiceType { get; set; }

        [JsonProperty("ServiceTypeBreakdown")]
        public string ServiceTypeBreakdown { get; set; }

        [JsonProperty("NBSJRSS")]
        public string NBSJRSS { get; set; }

        [JsonProperty("BillingRole")]
        public string BillingRole { get; set; }

        [JsonProperty("MethodOfWork")]
        public string MethodOfWork { get; set; }
    }
}