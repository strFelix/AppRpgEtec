using AppRpgEtec.Services.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppRpgEtec.ViewModels.Usuarios
{
    public class UsuarioViewModel : BaseViewModel
    {
        private UsuarioService _uService;

        #region Commands
        public ICommand RegistrarCommand { get; set; }
        public ICommand AutenticarCommand { get; set; }
        #endregion

        #region AtributosPropiedades
        private string login = string.Empty;
        private string password = string.Empty;

        public string Login 
        { 
            get => login; 
            set
            {
                login = value;
                OnPropertyChanged(Login);
            }
                 
        }
        
        public string Password
        {
            get => password;
            set 
            { 
                password = value;
                OnPropertyChanged(Password);
            }
        }
        #endregion

        #region Methods

        #endregion
    }
}
