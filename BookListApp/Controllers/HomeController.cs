using BookListApp.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Web.Mvc;

namespace BookListApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string jsonResponse = string.Empty;
            BookViewModel books = new BookViewModel();
            using (var client = GetService())
            {
                var response = client.GetAsync("api/BookApi").Result;
                if (response.IsSuccessStatusCode)
                {
                    jsonResponse = response.Content.ReadAsStringAsync().Result;
                    books = JsonConvert.DeserializeObject<BookViewModel>(jsonResponse);
                }
            }
            ViewBag.Title = "Book List";
            return View(books);
        }


        private HttpClient GetService()
        {
            HttpClient client = new HttpClient() { BaseAddress = new Uri("http://localhost:22431") };
            client.DefaultRequestHeaders.Accept.Clear();
            return client;
        }

    }
}
