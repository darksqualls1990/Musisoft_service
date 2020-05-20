using Modelo;
using ServiceImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Musisoft
{
    /// <summary>
    /// Descripción breve de LoginUsuarioAppNu
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class LoginUsuarioAppNu : System.Web.Services.WebService
    {

        LoginUsuarioServiceImpl loginUsuarioServiceImpl;

        public LoginUsuarioAppNu()
        {
            loginUsuarioServiceImpl = new LoginUsuarioServiceImpl();
        }

        [WebMethod]
        public Boolean validarLoguin(LoginUsuario loginUsuario)
        {
            return loginUsuarioServiceImpl.validarLogin(loginUsuario);
        }
    }
}
