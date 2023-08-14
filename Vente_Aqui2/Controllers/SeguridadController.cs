﻿using Modelo.Acciones;
using Negocio.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Vente_Aqui2.Controllers
{
    public class SeguridadController : Controller
    {
        //Vinculacion a Acciones Consulta en capa de Datos
        public AccionesConsulta validar = new AccionesConsulta();
        public AccionesMantenimiento mantenimiento = new AccionesMantenimiento();

        //Creando la vista del signup
        #region Sign-up
        public ActionResult signup()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Verificar_Usuario(string uname = "", string psw = "", string psw2 = "", int user = 0) 
        {
            bool verificado = false;
            while (verificado != true)
            {
                if (psw == psw2)
                {
                    validar.RegistrarUsuarios(uname, psw2);
                    verificado = true;
                }
                else
                {                    
                    verificado = false;
                }
            }            
            
            string vista = "";
            
            string controlador = "";
            if (user == 1)
            {
                vista = "VistaCliente";
                controlador = "Registrar";
                return RedirectToAction(vista, controlador);
            }else if(user == 2)
            {
                vista = "VistaAdministrador";
                controlador = "Registrar";
                return RedirectToAction(vista, controlador);
            }
            else
            {
                vista = "/Home/Error/";
            }
            return RedirectToAction("Home", "Home");
        }
        #endregion

        //Retorno de vista para Login

        #region Login
        public ActionResult Login()
        {
          return View("Login");
        }
        
        

        [HttpPost]

        //Proceso de verificacion de datos para el LogIn
        public ActionResult VerificarLogin(string uname, string psw) 
        {
            var Usuario = validar.listadousuarios().ToList();
            string vista= "";
            string controlador = "";
            mantenimiento.User = uname;

            try
            {
                if (Usuario.Exists(x => x.Nom_Usuario == uname && x.Psswd == psw && x.Tipo_usuario == "Admin"))
                {
                    vista = "VistaAdministrador";
                    controlador = "Registrar";
                    return RedirectToAction(vista, controlador);
                }
                else if (Usuario.Exists(x => x.Nom_Usuario == uname && x.Psswd == psw && x.Tipo_usuario == "Client"))
                {
                    vista = "VistaCliente";
                    controlador = "Registrar";
                    return RedirectToAction(vista, controlador);
                }

                else
                {
                    vista = "/Home/Error/";
                }
                return RedirectToAction("Home", "Home");
            }catch (Exception ex)
            {
                return View(ex);
            }

        }

        #endregion 
    }
}