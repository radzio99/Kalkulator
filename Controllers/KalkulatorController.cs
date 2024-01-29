using Kalkulator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kalkulator.Controllers
{
    public class KalkulatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Wynik(KalkulatorModel kalkulator)
        {
            int wynik = 0;
            if (kalkulator.znak == "dod") wynik = kalkulator.Liczba1 +
           kalkulator.Liczba2;
            else if (kalkulator.znak == "ode") wynik = kalkulator.Liczba1 -
           kalkulator.Liczba2;
            else if (kalkulator.znak == "mnoz") wynik = kalkulator.Liczba1 * kalkulator.Liczba2;
            else if (kalkulator.znak == "dziel") wynik = kalkulator.Liczba1 / kalkulator.Liczba2;
            ViewBag.wynik = wynik;
            return View("Wynik", wynik);
        }
        public IActionResult KalkulatorForm()
        {
            return View();
        }

    }
}
