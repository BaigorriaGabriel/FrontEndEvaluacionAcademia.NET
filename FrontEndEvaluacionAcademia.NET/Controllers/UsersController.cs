using Data.Base;
using Data.DTOs;
using FrontEndEvaluacionAcademia.NET.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace FrontEndEvaluacionAcademia.NET.Controllers
{
	public class UsersController : Controller
	{
        private readonly IHttpClientFactory _httpClient;
        public UsersController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        [Authorize]
		public IActionResult Users()
		{
			return View();
		}

        public async Task<IActionResult> UsersAddPartial([FromBody] UserDto userDto)
        {
            //// LO QUE ESTA CON 4 / DESCOMENTAR
            //var roleId = HttpContext.Session.GetInt32("RoleId");

            var userViewModel = new UserViewModel();

            if (userDto != null)
            {
                userViewModel = userDto;
            }


            var homeViewModel = new HomeViewModel();

            return PartialView("~/Views/Users/Partial/UsersAddPartial.cshtml", userViewModel);
            //deberia hacer un if en el UserAddPartial.cshtml para identificar si se modifica o se agrega un usuario?
        }

        public IActionResult Register(UserDto user)
        {
            var token = HttpContext.Session.GetString("Token");
            var baseApi = new BaseApi(_httpClient);
            var users = baseApi.PostToApi("User/Register", user, token);
            return View("~/Views/Users/Users.cshtml");
        }

        public IActionResult UpdateUser(UserDto user)
        {
            UserForUpdateDto userForUpdateDto = new UserForUpdateDto();

            userForUpdateDto.Name = user.Name;
            userForUpdateDto.Email = user.Email;
            userForUpdateDto.Dni = user.Dni;
            userForUpdateDto.Password = user.Password;


            var token = HttpContext.Session.GetString("Token");
            var baseApi = new BaseApi(_httpClient);
            var users = baseApi.PutToApi($"User/Update/{user.CodUser}", userForUpdateDto, token);
            return View("~/Views/Users/Users.cshtml");
        }

    }
}
