using Data.DTOs;

namespace FrontEndEvaluacionAcademia.NET.ViewModels
{
    public class UserViewModel
    {
        public int CodUser { get; set; }
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static implicit operator UserViewModel(UserDto v)
        {
            var userViewModel = new UserViewModel();
            userViewModel.CodUser = v.CodUser;
            userViewModel.Name = v.Name;
            userViewModel.Dni = v.Dni;
            //COMENTO PARA EXIGIRLE AL USUARIO QUE COMPLETE ESTOS CAMPOS
            //SINO, POR TEMA DE LA ENCRIPTACION DE LA CONTRASEÑA, POR MAS QUE NO SE MODIFIQUE LA CONTRASEÑA,
            //SE VA A MODIFICAR YA QUE SE VA A VOLVER A ENCRIPTAR LA CONTRASEÑA YA ENCRIPTADA
            //userViewModel.Email = v.Email;
            //userViewModel.Password = v.Password;

            return userViewModel;
        }
    }
}
