using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Policy.Infrastructure.CustomException;
using Policy.Infrastructure.Response;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;

namespace Policy.Api.Controllers
{
    public class BaseController : Controller
    {
        protected ILogger<BaseController> _log;

        private void LogEx(Exception ex)
        {
            var st = new StackTrace(ex, true); // create the stack trace
            var firstSt = st.GetFrames().FirstOrDefault();
            StringBuilder stb = new StringBuilder();
            stb.Append("ERROR_EX ");
            if (firstSt != null)
            {
                stb.Append("\nDetails: ");
                stb.Append(ex.Message);
                stb.Append("\nFile: ");
                stb.Append(firstSt.GetFileName());
                stb.Append("\nLine: ");
                stb.Append("\nColumn: ");
                stb.Append(firstSt.GetFileColumnNumber());
                stb.Append("\nMethod: ");
                stb.Append(firstSt.GetMethod());
                stb.Append("\nClass: ");
                stb.Append(firstSt.GetMethod().DeclaringType);
                stb.Append("\nInner: ");
                stb.Append(ex.InnerException?.Message);
                Serilog.Log.Logger.Information(stb.ToString());
            }
        }

        protected EndpointResult ProcessExceptionResult(Exception ex)
        {
            if (ex is SecurityException || ex is UserException)
            {
                return new EndpointResult(HttpStatusCode.BadRequest, new EndpointError(ex.Message));
            }

            LogEx(ex);
            return new EndpointResult(HttpStatusCode.BadRequest, new EndpointError("SYSTEM_ERROR"));
        }
    }
}