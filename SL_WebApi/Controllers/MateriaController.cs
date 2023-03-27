using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SL_WebApi.Controllers
{
    public class MateriaController : Controller
    {
        //[HttpGet]
        //[Route("api/Materia/GetAll")]
        //// GET: Materia
        //public IHttpActionResult GetAll()
        //{
        //    ML.Result result = BL.Materia.GetAll();
        //    if (result.Correct)
        //    {
        //        //return Ok(result);
        //        return Content(HttpStatusCode.OK, result);
        //    }
        //    else
        //    {
        //        return Content(HttpStatusCode.NotFound, result);
        //        //return NotFound(result);
        //    }
        //}

        //[HttpGet]
        //[Route("api/Materia/GetById/{IdMateria}")]
        //public IHttpActionResult GetById(int IdMateria)
        //{

        //    ML.Result result = BL.Materia.GetById(IdMateria);

        //    if (result.Correct)
        //    {
        //        return Content(HttpStatusCode.OK, result);
        //    }
        //    else
        //    {
        //        return Content(HttpStatusCode.NotFound, result);
        //    }
        //}

        //[HttpPost]
        //[Route("api/Materia/Add")]
        //public IHttpActionResult Post([FromBody] ML.Materia materia)
        //{

        //    ML.Result result = BL.Materia.Add(materia);

        //    if (result.Correct)
        //    {
        //        return Content(HttpStatusCode.OK, result);
        //    }
        //    else
        //    {
        //        return Content(HttpStatusCode.NotFound, result);
        //    }
        //}

        //[HttpPost]
        //[Route("api/Materia/Update/{IdMateria}")]
        //public IHttpActionResult Put(int IdMateria, [FromBody] ML.Materia materia)
        //{
        //    materia.IdMateria = IdMateria;
        //    ML.Result result = BL.Materia.Update(materia);

        //    if (result.Correct)
        //    {
        //        return Content(HttpStatusCode.OK, result);
        //    }
        //    else
        //    {
        //        return Content(HttpStatusCode.NotFound, result);
        //    }
        //}

        //[HttpDelete]
        //[Route("api/Materia/Delete/{IdMateria}")]
        //public IHttpActionResult Delete(ML.Materia materia)
        //{

        //    ML.Result result = BL.Materia.Delete(materia);

        //    if (result.Correct)
        //    {
        //        return Content(HttpStatusCode.OK, result);
        //    }
        //    else
        //    {
        //        return Content(HttpStatusCode.NotFound, result);
        //    }
        //}
    }
}