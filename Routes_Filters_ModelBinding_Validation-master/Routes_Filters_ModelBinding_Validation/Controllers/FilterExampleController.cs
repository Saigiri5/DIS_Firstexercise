using Microsoft.AspNetCore.Mvc;
using Routes_Filters_ModelBinding_Validation.Filters;

namespace Routes_Filters_ModelBinding_Validation.Controllers
{
  public class FilterExampleController : Controller
  {
    [Profile]
    public ViewResult ProfileFilteredAction()
    {
      return View("FiltersMessage", "This is the ProfileFilteredAction method on " +
        "the FiltersHome controller");
    }

  }
}