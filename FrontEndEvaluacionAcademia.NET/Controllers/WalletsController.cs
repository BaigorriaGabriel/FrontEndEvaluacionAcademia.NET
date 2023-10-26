using Data.Base;
using Data.DTOs;
using FrontEndEvaluacionAcademia.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace FrontEndEvaluacionAcademia.NET.Controllers
{
    public class WalletsController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public WalletsController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpContext GetHttpContext()
        {
            return HttpContext;
        }

        

        public async Task<IActionResult> Wallets()
        {

            return View();
        }




        

        
    }
}
