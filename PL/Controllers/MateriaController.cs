using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class MateriaController : Controller
    {
        // GET: Materia
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Materia materia = new ML.Materia();
            ML.Result result = BL.Materia.GetAll();

            if (result.Correct)
            {
                materia.Materias = result.Objects;
                return View(materia);
            }
            else
            {
                return View(materia);
            }
        }

        [HttpGet]
        //Formulario
        public ActionResult Form(int? IdMateria)
        {
            ML.Materia materia = new ML.Materia();
            if (IdMateria == null)
            {
                //Add Formulario vacio
                return View(materia);
            }
            else
            {
                //GetById
                ML.Result result = BL.Materia.GetById(IdMateria.Value);

                if (result.Correct)
                {
                    materia = (ML.Materia)result.Object;
                    return View(materia);
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al consultar la informacion";
                    return View("Modal");
                }
            }
        }

        [HttpPost]
        public ActionResult Form(ML.Materia materia)
        {
            ML.Result result = new ML.Result();

            if (materia.IdMateria == 0)
            {
                //Add
                result = BL.Materia.Add(materia);

                if (result.Correct)
                {
                    ViewBag.Message = "Se completo el registro satisfactoriamente";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al insertar el registro";
                }
                return View("Modal");
            }
            else
            {
                //Update
                result = BL.Materia.Update(materia);
                if (result.Correct)
                {
                    ViewBag.Message = "Se actualizo el registro satisfactoriamente";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al actualizar el registro";
                }
                return View("Modal");
            }
        }

        [HttpGet]
        public ActionResult Delete(ML.Materia materia)
        {
            ML.Result result = new ML.Result();

            result = BL.Materia.Delete(materia);
            if (result.Correct)
            {
                ViewBag.Message = "Se elimino el registro satisfactoriamente";
            }
            else
            {
                ViewBag.Message = "Ocurrio un error al eliminar el registro";
            }
            return View("Modal");
        }
    }
}