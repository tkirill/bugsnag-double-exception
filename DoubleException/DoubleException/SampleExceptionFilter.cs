using System;
using System.IO;
using System.Web.Mvc;

namespace DoubleException
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public sealed class SampleExceptionFilter : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null || filterContext.Exception == null)
                return;

//            if (filterContext.IsChildAction) return;  // UNCOMMENT TO FIX DOUBLE EXCEPTION

            File.AppendAllText(@"C:\logs\child-exception.log", "\n\n=============\n\n" + filterContext.Exception);
        }
    }
}