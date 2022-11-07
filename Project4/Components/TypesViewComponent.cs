using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Project4.Models;


namespace Project4.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IEmpRepository repo { get; set; }

        public TypesViewComponent(IEmpRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["PositionType"];

            var positiontypes = repo.employees
                .Select(x => x.PositionType)
                .Distinct()
                .OrderBy(x => x);

            return View(positiontypes);
        }
    }
}
