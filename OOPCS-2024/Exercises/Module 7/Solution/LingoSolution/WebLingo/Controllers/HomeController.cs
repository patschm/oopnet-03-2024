using LingoGame;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using WebLingo.Models;

namespace WebLingo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static string[] wordlist = {"appel", "actie", "breed", "blind", "cadet", "creme",
                                    "deren", "dweil", "elven", "engel", "feest", "flora", "grote",
                                    "gebak", "hamer", "hoofd", "index", "icoon", "jawel", "japon",
                                    "kraan", "kleur", "licht", "laser", "motor", "markt", "nodig", "neven",
                                    "oases", "onwel", "polis", "preek", "quota", "quark", "ruzie", "schat",
                                    "treur", "typen", "uniek", "ultra", "vloer", "vorst", "wreed", "wazig",
                                    "xenon", "yacht", "yucca", "zomer", "zagen"};

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            LingoModel model = new LingoModel();
            model.WordToBeGuessed = GenerateWord();
            model.Finished = false;
            model.Attempt = 1;
            HttpContext.Session.SetString("game", JsonConvert.SerializeObject(model));
            return View(model);
            
        }
        [HttpPost]
        public ActionResult Index(string[] guess)
        {
            string sguess = string.Join(null, guess);
            string? sModel = HttpContext.Session.GetString("game");
            if (string.IsNullOrEmpty(sModel))
            {
                return RedirectToAction("Index");
            }
            LingoModel? model = JsonConvert.DeserializeObject<LingoModel>(sModel);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            LingoWord theguess = new LingoWord(sguess);
            model.WordToBeGuessed?.CompareTo(theguess);
            model.Guesses.Add(theguess);

            if (theguess.IsGuessed() || model.Attempt >= 5)
            {
                IQ iq = (IQ)model.Attempt!;
                model.YourIQ = iq.ToString();
                model.Finished = true;
            }
            model.Attempt++;
            HttpContext.Session.SetString("game", JsonConvert.SerializeObject(model));
            return View(model);
        }
        private static LingoWord GenerateWord()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int idx = rnd.Next(0, wordlist.Length);
            return new LingoWord(wordlist[idx]);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}