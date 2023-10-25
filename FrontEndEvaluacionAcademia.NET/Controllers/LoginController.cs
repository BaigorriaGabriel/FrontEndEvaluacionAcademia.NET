using Data.DTOs;
using Data.Base;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Security.Claims;
using Newtonsoft.Json;
using FrontEndEvaluacionAcademia.NET.Models;
using TpIntegradorSofttekFrontEnd.ViewModels;

namespace FrontEndEvaluacionAcademia.NET.Controllers
{
	public class LoginController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public LoginController(IHttpClientFactory httpClient)
		{
			_httpClientFactory = httpClient;
		}

		public IActionResult Login()
		{
			return View();
		}

		public async Task<IActionResult> Ingresar(LoginDto login)
		{
			var baseApi = new BaseApi(_httpClientFactory);
			var token = await baseApi.PostToApi("Login", login);
			var resultadoLogin = token as OkObjectResult;
			var resultadoObjeto = JsonConvert.DeserializeObject<UserLogin>(resultadoLogin.Value.ToString());

			var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);

			Claim claimRole = new(ClaimTypes.Role, "Administrador");

			identity.AddClaim(claimRole);


			var claimPrincipal = new ClaimsPrincipal(identity);

			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, new AuthenticationProperties
			{
				ExpiresUtc = DateTime.Now.AddDays(1),
			});

			var homeViewModel = new HomeViewModel();
			homeViewModel.CodeUser = resultadoObjeto.CodeUser;
			homeViewModel.Name = resultadoObjeto.Name;
			homeViewModel.Token = resultadoObjeto.Token;

			return View("~/Views/Home/Index.cshtml", homeViewModel);
		}

		public async Task<IActionResult> CerrarSession()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Login", "Login");
		}
	}
}
