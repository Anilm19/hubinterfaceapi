namespace HubService.Data.EntityModel
{
    public class Facility: BaseEntity
    {
		public string FacilityName { get; set; }
		public string FacilityType { get; set; }
		public bool MultiFacility { get; set; }
		public string EHRVendorName { get; set; }
		public string EHRDataFormat { get; set; }
		public string EHRDataFormatVersion { get; set; }
		public bool EMPI { get; set; }
		public bool DemographicsEnabled { get; set; }
		public bool LabsEnabled { get; set; }
		public bool MedsEnabled { get; set; }
		public bool VitalsEnabled { get; set; }
		public bool AllergiesEnabled { get; set; }
    }
}

