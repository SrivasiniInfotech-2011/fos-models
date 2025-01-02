﻿namespace FOS.Models
{
    public class SqlParameterConstants
    {
        //Login
        public const string USER_LOGIN_ID = "@UserLoginID";
        public const string USER_NAME = "@UserName";
        public const string PASSWORD = "@Password";
        public const string ERRORCODE = "@ErrorCode";
        public const string COMPANYID = "@CompanyID";
        public const string USER_ID = "@UserID";
        public const string USER_LEVEL_ID = "@User_Level_ID";
        public const string LAST_LOGIN_DATE = "@Last_LoginDate ";
        public const string USER_THEME = "@User_Theme";
        public const string COMPANY_NAME = "@CompanyName";
        public const string COMPANY_CODE = "@CompanyCode";
        public const string LEVEL_ACCESS = "@LevelAccess";
        public const string COUNTRY_NAME = "@CountryName";
        public const string USER_TYPE = "@UserType";
        public const string MARGQUEE_TEXT = "@Marquee_Text";
        public const string ADDRESS1 = "@Address1";
        public const string ADDRESS2 = "@Address2 ";
        public const string CITY = "@City";
        public const string STATE = "@State";
        public const string ZIP_CODE = "@Zip_Code";
        public const string LNC_SERIAL_DATE = "@LNCSerDate";
        public const string LNC_DATE = "@LNCDate";
        public const string SESSION_ID = "@SessionID";
        public const string SSO_ENABLED = "@SSOEnabled";
        public const string LOGIN_COMPANY_CODE = "@LoginCompanyCode";
        public const string PREFIX_TEXT = "@PrefixText";
        public const string OPTION = "@Option";
        //Prospect
        public const string PROSPECT_COMPANY_ID = "@Company_ID";
        public const string PROSPECT_USER_ID = "@User_ID";
        public const string PROSPECT_MOBILE_NUMBER = "@Mobile_Number";
        public const string PROSPECT_AADHAR_NUMBER = "@Aadhar_Number";
        public const string PROSPECT_PAN_NUMBER = "@PAN_NUMBER";
        public const string PROSPECT_ID = "@Prospect_ID";
        public const string PROSPECT_LOCATION_ID = "@Location_ID";
        public const string PROSPECT_DATE = "@Prospect_Date";
        public const string PROSPECT_TYPE_ID = "@ProspectType_ID";
        public const string PROSPECT_CUSTOMER_ID = "@Customer_ID";
        public const string PROSPECT_CUSTOMER_CODE = "@Customer_Code";
        public const string PROSPECT_GENDER_ID = "@Gender_ID";
        public const string PROSPECT_NAME = "@Prospect_Name";
        public const string PROSPECT_DATEOFBIRTH = "@Prospect_Dateofbirth";
        public const string PROSPECT_ALTERNATE_MOBILENUMBER = "@Alternate_Mobilenumber";
        public const string PROSPECT_EMAIL = "@Email";
        public const string PROSPECT_WEBSITE = "@Website";
        public const string PROSPECT_COMMUNICATION_ADDRESS1 = "@Communication_Address1";
        public const string PROSPECT_COMMUNICATION_ADDRESS2 = "@Communication_Address2";
        public const string PROSPECT_COMMUNICATION_LANDMARK = "@Communication_Landmark";
        public const string PROSPECT_COMMUNICATION_CITY = "@Communication_City";
        public const string PROSPECT_COMMUNICATION_STATE_ID = "@Communication_State_ID";
        public const string PROSPECT_COMMUNICATION_COUNTRY_ID = "@Communication_Country_ID";
        public const string PROSPECT_COMMUNICATION_PINCODE = "@Communication_Pincode";
        public const string PROSPECT_PERMANENT_ADDRESS1 = "@Permanent_Address1";
        public const string PROSPECT_PERMANENT_ADDRESS2 = "@Permanent_Address2";
        public const string PROSPECT_PERMANENT_LANDMARK = "@Permanent_Landmark";
        public const string PROSPECT_PERMANENT_CITY = "@Permanent_City";
        public const string PROSPECT_PERMANENT_STATE_ID = "@Permanent_State_ID";
        public const string PROSPECT_PERMANENT_COUNTRY_ID = "@Permanent_Country_ID";
        public const string PROSPECT_PERMANENT_PINCODE = "@Permanent_Pincode";
        public const string PROSPECT_AADHAR_IMPAGEPATH = "@Aadhar_Impagepath";
        public const string PROSPECT_PAN_IMAGEPATH = "@PAN_Imagepath";
        public const string PROSPECT_IMAGEPATH = "@Prospect_Imagepath";
        public const string PROSPECT_CREATED_BY = "@Created_By";
        public const string PROSPECT_CODE = "@Prospect_Code";
        public const string PROSPECT_ERROR_CODE = "@Error_Code";

        public const string MODE = "@Mode";
        public const string LOB_ID = "@LOB_ID";
        public const string VALIDATION_CODE = "@Validation_Code";
        public const string VALIDATION_MESSAGE = "@Validation_Message";
        public const string CURRENT_PAGE = "@CurrentPage";
        public const string PAGE_SIZE = "@PageSize";
        public const string SEARCH_VALUE = "@SearchValue";
        public const string TOTAL_RECORDS = "@TotalRecords";
        public const string STATUS = "@Status";
        //Lead
        public const string LEAD_ID = "@Lead_ID";
        public const string PERSON_TYPE = "@Person_Type";
        public const string LEAD_VEHICLE_NUMBER = "@Vehicle_Number";
        public const string LEAD_NUMBER = "@Lead_Number";
        public const string LEAD_GUARANTORTYPE_ID = "@GuarantorType_ID";
        public const string LEAD_RELATIONSHIP_ID = "@Relationship_ID";
        public const string LEAD_GURANTOR_NAME = "@Gurantor_Name";
        public const string LEAD_GURANTOR_IMAGEPATH = "@Gurantor_Imagepath";
        public const string LEAD_GUARANTOR_AMOUNT = "@Guarantor_Amount";
        public const string LEAD_DATE = "@Lead_Date";
        public const string LEAD_FINANCE_AMONT = "@FINANCE_AMONT";
        public const string LEAD_DOCUMENT_ID = "@DOCUMENT_ID";
        public const string LEAD_TENURE = "@TENURE";
        public const string LEAD_TENURE_TYPE_ID = "@Tenure_Type_ID";
        public const string LEAD_RATE = "@RATE";
        public const string LEAD_SALES_PERSON_ID = "@Sales_Person_ID";
        public const string LEAD_REPAYMENT_FREQUENCY_ID = "@REPAYMENT_FREQUENCY_ID";
        public const string LEAD_LEAVE_PERIOD = "@LEAVE_PERIOD";
        public const string LEAD_ASSET_CLASS_ID = "@ASSET_CLASS_ID";
        public const string LEAD_ASSET_NAME_ID = "@ASSET_NAME_ID";
        public const string LEAD_ASSET_TYPE_ID = "@ASSET_TYPE_ID";
        public const string ASSET_MODEL = "@ASSET_MODEL";
        public const string LEAD_ENGINE_NUMBER = "@ENGINE_NUMBER";
        public const string LEAD_CHASSIS_NUMBER = "@CHASSIS_NUMBER";
        public const string LEAD_SERIAL_NUMBER = "@SERIAL_NUMBER";
        public const string LEAD_OWNERSHIP_ID = "@OWNERSHIP_ID";
        public const string LEAD_MODEL = "@MODEL";
        public const string LEAD_VEHICLE_TYPE_ID = "@VEHICLE_TYPE_ID";
        public const string LEAD_TAX_TYPE_ID = "@TAX_TYPE_ID";
        public const string LEAD_FUEL_TYPE_ID = "@FUEL_TYPE_ID";
        public const string LEAD_HOUSE_TYPE_ID = "@House_Type_ID";
        public const string LEAD_FLOOR_NUMBER = "@Floor_Number";
        public const string LEAD_HOUSESTATUS_ID = "@HouseStatus_ID";
        public const string LEAD_HOUSE_RENTAL_AMOUNT = "@House_Rental_Amount";
        public const string LEAD_MARITIALSTATUS_ID = "@MaritialStatus_ID";
        public const string LEAD_FATHER_NAME = "@Father_Name";
        public const string LEAD_MOTHER_NAME = "@Mother_Name";
        public const string LEAD_EMPLOYMENT_ID = "@Employment_ID";
        public const string LEAD_MONTHLY_SALARY = "@Monthly_Salary";
        public const string LEAD_SPOUSEEMPLOYMENT_ID = "@SpouseEmployment_ID";
        public const string LEAD_SPOUSE_MONTHLY_SALARY = "@Spouse_Monthly_Salary";
        public const string LEAD_ADULT_DEPENDENTS = "@Adult_Dependents";
        public const string LEAD_CHILD_DEPENDENTS = "@Child_Dependents";
        public const string LEAD_OWNED_TWO_WHEELER = "@Owned_Two_Wheeler";
        public const string LEAD_OWNED_FOUR_WHEELER = "@Owned_Four_Wheeler";
        public const string LEAD_OWNED_HEAVY_VEHICLES = "@Owned_Heavy_Vehicles";
        public const string LEAD_EXISTING_LOAN_ALIVE = "@Existing_Loan_Alive";
        public const string LEAD_EXISITNG_LOANS_MONTHLY_EMI = "@Exisitng_Loans_Monthly_EMI";
        public const string LEAD_SPOUSENAME = "@SpouseName";
        public const string LEAD_PUBLIC_CLOSELY_ID = "@Public_Closely_ID";
        public const string LEAD_DIRECTOR_PARTHERS_COUNT = "@Director_Parthers_Count";
        public const string LEAD_LISTED_EXCHANGE = "@Listed_Exchange";
        public const string LEAD_PAID_UP_CAPITAL = "@Paid_Up_Capital";
        public const string LEAD_FACE_VALUE_SHARE = "@Face_Value_Share";
        public const string LEAD_BOOK_VALUE_SHARE = "@Book_Value_Share";
        public const string LEAD_BUSINESS_PROFILE = "@Business_Profile";
        public const string LEAD_GEOGRAPHICAL_COVERAGE = "@Geographical_Coverage";
        public const string LEAD_BRANCH_COUNT = "@Branch_Count";
        public const string LEAD_GOVERNMENT_INSTITUTION_PARTICIPATION_ID = "@Government_Institution_Participation_ID";
        public const string LEAD_PROMOTER_STAKE = "@Promoter_Stake";
        public const string LEAD_JV_PARTNER_NAME = "@JV_Partner_Name";
        public const string LEAD_JV_PARTNER_PERCENTAGE = "@JV_Partner_Percentage";
        public const string LEAD_CEO_NAME = "@CEO_Name";
        public const string LEAD_CEO_DATEOFBIRTH = "@CEO_DateofBirth";
        public const string LEAD_CEO_WEDDING_DATE = "@CEO_Wedding_Date";
        public const string LEAD_EXPERIENCE = "@Experience";
        public const string LEAD_RESIDENTIAL_ADDRESS = "@Residential_Address";




        //USER MANAGEMENT INSERT
        public const string USER_MANAGEMENT_COMPANY_ID = "@Company_ID";
        public const string USER_MANAGEMENT_USER_ID = "@User_ID";
        public const string USER_MANAGEMENT_USER_CODE = "@UserCode";
        public const string USER_MANAGEMENT_USER_NAME = "@UserName";
        public const string USER_MANAGEMENT_GENDER_ID = "@Gender_ID";
        public const string USER_MANAGEMENT_PASSWORD = "@Password";
        public const string USER_MANAGEMENT_MOBILE_NUMBER = "@MobileNumber";
        public const string USER_MANAGEMENT_EMERGENCY_CONTACT_NUMBER = "@EmergencycontactNumber";
        public const string USER_MANAGEMENT_DOJ = "@DOJ";
        public const string USER_MANAGEMENT_DESIGNATION = "@Designation";
        public const string USER_MANAGEMENT_USER_LEVEL_ID = "@UserLevelID";
        public const string USER_MANAGEMENT_REPORTING_NEXT_LEVEL = "@ReportingNextlevel";
        public const string USER_MANAGEMENT_USER_GROUP = "@User_Group";
        public const string USER_MANAGEMENT_EMAIL_ID = "@EmailID";
        public const string USER_MANAGEMENT_DATEOFBIRTH = "@Dateofbirth";
        public const string USER_MANAGEMENT_FATHER_NAME = "@FatherName";
        public const string USER_MANAGEMENT_MOTHER_NAME = "@MotherName";
        public const string USER_MANAGEMENT_SPOUSE_NAME = "@SpouseName";
        public const string USER_MANAGEMENT_MARITIAL_ID = "@Maritial_ID";
        public const string USER_MANAGEMENT_AADHAR_NUMBER = "@Aadhar_Number";
        public const string USER_MANAGEMENT_PAN_NUMBER = "@PAN_Number";
        public const string USER_MANAGEMENT_Address = "@Address";
        public const string USER_MANAGEMENT_USER_IMAGE_PATH = "@User_Imagepath";
        public const string USER_MANAGEMENT_IS_ACTIVE = "@Is_Active";
        public const string USER_MANAGEMENT_CREATED_BY = "@CreatedBy";
        public const string USER_MANAGEMENT_ERROR_CODE = "@ErrorCode";


        //Field Verification
        public const string FIELD_VERIFICATION_ID = "@FieldVerification_ID";
    }
}
