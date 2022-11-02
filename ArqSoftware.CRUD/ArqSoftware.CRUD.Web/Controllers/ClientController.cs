using ArqSoftware.CRUD.Models;
using ArqSoftware.CRUD.Web.Models;
using ArqSoftware.CRUD.Web.Utilidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArqSoftware.CRUD.Web.Controllers
{
    public class ClientController : Controller
    {
        // GET: ClientController
        public ActionResult Index()
        {
            var clients = UtilidadHttp<List<ClientViewModel>>.EnviarPeticionREST("clients", HttpMethod.Get);
            return View(clients);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel model)
        {
            try
            {
                var client = new Client
                {
                    CreationDate = DateTime.Now,
                    DocumentNumber = model.DocumentNumber,
                    Email = model.Email,
                    FirstMidName = model.FirstMidName,
                    LastName = model.LastName
                };

                var response = UtilidadHttp<Client>.EnviarPeticionREST("clients", HttpMethod.Post, body: client);

                if (response.Id > 0)
                    return RedirectToAction(nameof(Index));
                else
                    return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
