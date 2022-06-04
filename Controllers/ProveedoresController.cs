using BootCamp_API_REST_Clase17.Models;
using BootCamp_API_REST_Clase17.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace BootCamp_API_REST_Clase17.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedoresController : Controller
    {
            private readonly IUnitOfWork _context;

            public ProveedoresController(IUnitOfWork context)
            {
                _context = context;
            }

        [HttpGet]
        public ActionResult<List<Proveedores>> Get()
        {
            var entidad = _context.RepoProveedores.GetAll();
            return Ok(entidad);
        }

        [HttpGet("{id}")]
        public ActionResult GetBy(int id)
        {
            var entidad = _context.RepoProveedores.GetById(id);
            return Ok(entidad);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var entidad = _context.RepoProveedores.Delete(id);
            return Ok(entidad);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Proveedores prov)
        {
            var entidad = _context.RepoProveedores.Insert(prov);
            return Ok(entidad);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Proveedores prov, int id)
        {
            var entidad = _context.RepoProveedores.Update(prov);
            return Ok(entidad);
        }
    }
}
