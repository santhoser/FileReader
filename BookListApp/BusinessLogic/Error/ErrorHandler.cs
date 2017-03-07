using BookListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookListApp.BusinessLogic
{
    /// <summary>
    /// Singleton Error Handler
    /// </summary>
    public static class ErrorHandler
    {
        private static List<ErrorModel> errors = new List<ErrorModel>();

        public static List<ErrorModel> ErrorList
        {
            get { return errors; }
        }
        
        public static void AddError(ErrorTypes errorCode, Exception ex)
        {
            if (!errors.Any(e => e.ErrorCode == errorCode))
            {
                errors.Add(new ErrorModel
                {
                    ErrorCode = errorCode,
                    Message = GetErrorMessage(errorCode),
                    SystemException = ex.Message ?? string.Empty
                });
            }
        }

        private static string GetErrorMessage(ErrorTypes code)
        {
            string errorMessage = string.Empty;
            switch (code)
            {
                case ErrorTypes.ER1:
                    errorMessage = "Few records not proceeded due to invalid record length.";
                    break;
                case ErrorTypes.ER2:
                    errorMessage = "Errors occoured due to incorrect string length.";
                    break;
                case ErrorTypes.ER3:
                    errorMessage = "Errors occoured due to incorrect tabs.";
                    break;
                case ErrorTypes.ER4:
                    errorMessage = "Ignored incorrect format files.";
                    break;
                case ErrorTypes.ER5:
                    errorMessage = "Failed to read a file.";
                    break;
                case ErrorTypes.ER6:
                    errorMessage = "Failed to identify a file format.";
                    break;
                case ErrorTypes.ER7:
                    errorMessage = "File location doesnot exists.";
                    break;
                default:
                    errorMessage = "Unhandled Exception Occured.";
                    break;
            }
            return errorMessage;
        }
    }
}