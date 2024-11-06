namespace FOS.Models.Constants
{
    public class Constants
    {
        public const string APP_SECRET = "wSGnVqSnc@4iNj2Qe^S-8ZnvEHQ-UyGS~y)[;yhJdt'#ox<vG%Mp8Gn{EZyG#Db";
        public const string APP_SCOPE = "amsApiRequestScope";
        public const string APP_CLIENT_ID = "A25A96F4D2E6193E5D28F52176622";
        public const string IdentityServerConfigurationKey = "IdentityServerUrl";
        /// <summary>
        /// User Claims.
        /// </summary>
        public static class UserClaim
        {
            public const string Role = "role";
            public const string Admin = "admin";
            public const string User = "user";
            public const string DataEventRecords = "userManagementApi";
            public const string AdminDataEventRecords = "userManagementApi.admin";
            public const string UserAdminEventRecords = "userManagementApi.user";
            public const string ScopeDisplayName = "Scope for the FOS API Resource";
        }

        /// <summary>
        /// Api Resources
        /// </summary>
        public static class ApiResource
        {
            public const string Role = "role";
            public const string Admin = "admin";
            public const string User = "user";
            public const string UserApi = "userManagementApi";
            public const string ApiResourceSecret = "C8EF369FEAD9FF58A847244243A6B";
            public const string UserApiScope = "userApiScope";
            public const string UserApiResouceDisplayName = "User API";
        }

        /// <summary>
        /// Contains constants for special characters.
        /// </summary>
        public static class Characters
        {
            /// <summary>
            /// The constant for ampersand character.
            /// </summary>
            public const char Ampersand = '@';

            /// <summary>
            /// The constant for backslash character.
            /// </summary>
            public const char Backslash = '\\';

            /// <summary>
            /// The constant for colon character.
            /// </summary>
            public const char Colon = ':';

            /// <summary>
            /// The constant for comma character.
            /// </summary>
            public const char Comma = ',';

            /// <summary>
            /// The constant for forward slash character.
            /// </summary>
            public const char ForwardSlash = '/';

            /// <summary>
            /// The constant for period character.
            /// </summary>
            public const char Period = '.';

            /// <summary>
            /// The constant for pipe character.
            /// </summary>
            public const char Pipe = '|';

            /// <summary>
            /// The constant for round bracket close character.
            /// </summary>
            public const char RoundBracketClose = ')';

            /// <summary>
            /// The constant for round bracket open character.
            /// </summary>
            public const char RoundBracketOpen = '(';

            /// <summary>
            /// The constant for space character.
            /// </summary>
            public const char Space = ' ';

            /// <summary>
            /// The constant for square bracket close character.
            /// </summary>
            public const char SquareBracketClose = ']';

            /// <summary>
            /// The constant for square bracket open character.
            /// </summary>
            public const char SquareBracketOpen = '[';

            /// <summary>
            /// The constant for question mark character.
            /// </summary>
            public const char QuestionMark = '?';

            /// <summary>
            /// The constant for asterisk mark character.
            /// </summary>
            public const char Asterisk = '*';

            /// <summary>
            /// The constant for carat mark character.
            /// </summary>
            public const char Carat = '^';

            /// <summary>
            /// The constant for double quote character.
            /// </summary>
            public const char DoubleQuote = '"';

            /// <summary>
            /// The constant for equals character.
            /// </summary>
            public const char Equality = '=';
        }

        /// <summary>
        /// Contains keys for different services used in the application.
        /// </summary>
        public static class FOSServiceKey
        {
            /// <summary>
            /// Contains keys for different file exporters used in the application.
            /// </summary>
            public static class FOSFileExporter
            {
                /// <summary>
                /// The key for the Excel file exporter service.
                /// </summary>
                public const string Excel = "excel";
            }
        }

        /// <summary>
        /// Contains constants related to web configurations.
        /// </summary>
        public static class Web
        {
            /// <summary>
            /// Contains constants related to authorization.
            /// </summary>
            public static class Authorization
            {
                /// <summary>
                /// The name of the request header that provides authorization info.
                /// </summary>
                public const string RequestHeaderAuthorizationKey = "Authorization";

                /// <summary>
                /// The authorization type to use.
                /// </summary>
                public const string Type = "Bearer";

                /// <summary>
                /// Contains constants for claim types.
                /// </summary>
                public static class ClaimType
                {
                    /// <summary>
                    /// The claim type for client ID.
                    /// </summary>
                    public const string ClientId = "clientId";

                    /// <summary>
                    /// The claim type for email.
                    /// </summary>
                    public const string Email = "email";

                    /// <summary>
                    /// The claim type for first name.
                    /// </summary>
                    public const string FirstName = "firstName";

                    /// <summary>
                    /// The claim type for last name.
                    /// </summary>
                    public const string LastName = "lastName";

                    /// <summary>
                    /// The claim type for login name.
                    /// </summary>
                    public const string LoginName = "loginName";

                    /// <summary>
                    /// The claim type for params.
                    /// </summary>
                    public const string Params = "params";

                    /// <summary>
                    /// The claim type for SAM account name.
                    /// </summary>
                    public const string ParamsSamAccountName = "SAM-Account-Name";

                    /// <summary>
                    /// The claim type for staff ID.
                    /// </summary>
                    public const string StaffId = "staffId";
                }
            }

            /// <summary>
            /// Contains constants for content types used in web requests and responses.
            /// </summary>
            public static class ContentType
            {
                /// <summary>
                /// The content type for JSON data format.
                /// </summary>
                /// <remarks>
                /// This constant is used to set the 'Content-Type' header of HTTP requests and responses to 'application/json'.
                /// This indicates that the body of the request or response is formatted as JSON.
                /// </remarks>
                public const string Json = "application/json";

                /// <summary>
                /// The content type for Office Excel data format.
                /// </summary>
                /// <remarks>
                /// This constant is used to set the 'Content-Type' header of HTTP requests and responses to 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet'.
                /// This indicates that the body of the request or response is formatted as an Office Excel document.
                /// </remarks>
                public const string OfficeExcel = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            }
        }

        /// <summary>
        /// Sql Column Names.
        /// </summary>
        public static class SqlColumnNames
        {
            public const string ModuleName = "Module_Name";
            public const string ProgramCode = "Program_Code";
        }
    }
}
