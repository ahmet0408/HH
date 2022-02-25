using HH.bll.DTOs.ClientDTO;
using HH.bll.Services.ClientService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

         public IActionResult Index()
         {
            return View();
         }
         [HttpGet]
         public IActionResult Create()
         {
            return View();
         }
         [HttpPost]
        public async Task<IActionResult> Create(CreateClientDTO client)
        {
            if (ModelState.IsValid)
            {
                await _clientService.CreatClient(client);

                return RedirectToAction("Index");
            }
            return View(client);
        }

    }
}
