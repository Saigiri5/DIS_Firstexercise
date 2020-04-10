using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Routes_Filters_ModelBinding_Validation.Filters
{
  public class ProfileAttribute : ActionFilterAttribute
  {
    private Stopwatch timer;

    public override void OnActionExecuting(ActionExecutingContext context)
    {
      timer = Stopwatch.StartNew();
    }

    public override void OnActionExecuted(ActionExecutedContext context)
    {
      timer.Stop();

      string result = "<div>Elapsed time: " + $"{timer.Elapsed.TotalMilliseconds} ms</div>";
      byte[] bytes = Encoding.ASCII.GetBytes(result);

      context.HttpContext.Response.Body.Write(bytes, 0, bytes.Length);
    }
  }
}