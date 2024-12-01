namespace FOS.Models.Constants
{
    public class SqlCommandConstants
    {
        public const string FOS_ORG_GET_EXISTING_PROPSECT_CUSTOMER_DETAILS = @"FOS_ORG_GET_ExistingPropsectCustomerDetails";
        public const string FOS_GET_PROSPECT_LOOKUP_DATA = @"Select  LookupType_ID as LookupTypeId
                                                         , LookupType_Description as LookupTypeDescription
                                                         , LookupValue_ID as LookupValueId
                                                         , LookupValue_Description as LookupValueDescription
                                                         from FOS_SYSAD_LookupMaster(Nolock)
                                                         Where LookupType_ID in(1 , 2 , 22)
                                                         and Is_Active = 1";

        public const string FOS_GET_BRANCH_LIST = @"Select LM.Location_ID as LocationId                                                                                                 
                                                      ,LCAT.LocationCat_Description as LocationName                                                                       
                                                from FOS_SYSAD_UserLocationMapping(Nolock) ULMP                                                                            
                                                    Inner Join FOS_SYSAD_LocationMaster(Nolock) LM       On LM.Location_ID = ULMP.Location_ID                                                                             
                                                    Inner Join FOS_SYSAD_LocationCategory(Nolock) LCAT   On LCAT.Location_Category_ID = LM.Location_Category_ID                                                           
                                                    Where LM.Company_ID = @CompanyId                                                                                          
                                                    And ULMP.User_ID = @UserId                                                                                                  
                                                    And LM.Is_Operational = 1                                                                                                
                                                    And ULMP.LOB_ID = @LobId                                                                                                
                                                    And LM.Is_Active = @IsActive";

        public const string FOS_ORG_INSERT_ProspectMaster = @"FOS_ORG_INSERT_ProspectMaster";

        public const string FOS_GET_STATE_LOOKUP = @"Select STATE_ID    as LookupValueId
                                                           ,STATE_NAME  as LookupValueDescription
                                                            from FOS_SYSAD_STATEMASTER(Nolock)
                                                            --Where Company_ID = @Company_ID
                                                            Order by STATE_NAME";

        public const string GetUserByUsername = @"FOS_Validate_Login";
        public const string GetUserProgramList = @"FOS_Get_User_ProgrmLists";
        public const string GetUserById = @"SELECT  UM.[User_ID]    as  UserId, 
	                                                UM.[User_Name]  as  UserName,
                                                    UM.[Email_ID]   as  UserEmail
	                                                FROM FOS_SYSAD_UserMaster(nolock) UM  WHERE UM.[User_ID]= @UserLoginID AND UM.Is_Active =1";
        public const string FOS_ORG_INSERT_LEADDETAILS = @"FOS_ORG_Insert_LeadDetails";
        public const string FOS_ORG_GET_LEADPROSPECTDETAILS = "FOS_ORG_GET_LeadProspectDetails";
        public const string FOS_ORG_INSERT_LEADGENERATION_HEADER = "FOS_ORG_INSERT_LeadGeneration_Header";
        public const string FOS_ORG_INSERT_LEADINDIVIDUALDETAILS = "FOS_ORG_INSERT_LeadIndividualDetails";
        public const string FOS_ORG_INSERT_LEADNONINDIVIDUALDETAILS = "FOS_ORG_INSERT_LeadNonIndividualDetails";
        public const string FOS_ORG_GET_ASSETLOOKUP = "FOS_ORG_GET_AssetLookup";
        public const string FOS_ORG_GET_LEADDETAILS = "FOS_ORG_GET_LeadDetails";
        public const string FOS_ORG_INSERT_LEADGUARANTORDETAILS = "FOS_ORG_INSERT_LeadGuarantorDetails";
        public const string FOS_ORG_GET_PROSPECTMASTERLOOKUP = "FOS_ORG_GET_ProspectMasterLookup";
        public const string FOS_ORG_GETLEADSTATUS = @"SELECT LSL.Lead_Status_ID AS StatusId,
                                                             LSL.Status_Description as StatusDescription
                                                        FROM FOS_ORG_LeadStatusLookup LSL";
        public const string FOS_ORG_GET_LEADTRANSLANDER = "FOS_ORG_GET_LeadTranslander_New";
        public const string FOS_GET_LOOKUPS_FOR_LEAD_SCREEN = @"FOS_ORG_GET_LeadGenerationLookup";
        public const string FOS_SYSAD_DOCUMENT_LOOKUPDETAILS = "FOS_SYSAD_DOCUMENT_LOOKUPDETAILS";
        public const string FOS_ORG_GET_USERNAMEAGT = "FOS_ORG_GET_USERNAMEAGT";
        public const string FOS_GET_LOB_LIST = "FOS_GET_LOB_LIST";
        public enum Mode
        {
            ADD = 1,
            MODIFY = 2,
            DELETE=3
        }
    }
}
