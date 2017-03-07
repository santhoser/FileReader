using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookListApp.BusinessLogic
{
    public enum ErrorTypes
    {
        /// <summary>
        /// Unhandled Exception Occured.
        /// </summary>
        ER0,
        /// <summary>
        /// Few records not proceeded due to invalid record length.
        /// </summary>
        ER1,
        /// <summary>
        /// Errors occoured due to incorrect string length.
        /// </summary>
        ER2,
        /// <summary>
        /// Errors occoured due to incorrect tabs.
        /// </summary>
        ER3,
        /// <summary>
        /// Ignored incorrect format files.
        /// </summary>
        ER4,
        /// <summary>
        /// Failed to read a file.
        /// </summary>
        ER5,
        /// <summary>
        /// Failed to identify a file format.
        /// </summary>
        ER6,
        /// <summary>
        /// File location doesnot exists.
        /// </summary>
        ER7
    }
}