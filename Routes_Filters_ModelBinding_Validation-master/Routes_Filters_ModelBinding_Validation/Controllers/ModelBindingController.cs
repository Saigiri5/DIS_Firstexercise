using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Routes_Filters_ModelBinding_Validation.Models;

namespace Routes_Filters_ModelBinding_Validation.Controllers
{
  public class ModelBindingController : Controller
  {
    private IRepository repository;

    public ModelBindingController(IRepository repo)
    {
      repository = repo;
    }

    public ViewResult Index(int id) => View(repository[id]);

    public ViewResult IndexWithAddress(int id) => View(repository[id]);

    public ViewResult IndexNullSafe(int id) => View(repository[id] ?? repository.People.First());

    public ViewResult Create() => View(new Person());

    [HttpPost]
    public ViewResult Create(Person model) => View("IndexNullSafe", model);

    public ViewResult CreateWithAddress() => View(new Person());

    [HttpPost]
    public ViewResult CreateWithAddress(Person model) => View("IndexWithAddress", model);

    public ViewResult NamesArray(string[] names) => View(names ?? new string[0]);

    public ViewResult NamesList(IList<string> names) => View(names ?? new List<string>());

    public ViewResult Address(IList<AddressSummary> addresses) => View(addresses ?? new List<AddressSummary>());

    public ViewResult Createproject()
        {
            project Project = new project();
            return View(Project);
        }
        [HttpPost]
        public ViewResult Createproject(project Project)
        {
            return View(Project);
        }
    }
}