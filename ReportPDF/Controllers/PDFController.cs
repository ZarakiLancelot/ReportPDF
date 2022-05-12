using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportPDF.Controllers
{
    [ApiController]
    public class PDFController : ControllerBase
    {
        [HttpPost]
        [Route("api/generarPDF")]
        public IActionResult Post()
        {
            return Ok("PDF Generado!");
        }

        [HttpGet]
        [Route("api/report/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"PDF #{id}");
        }
    }
}
