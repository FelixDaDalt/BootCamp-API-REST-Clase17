using BootCamp_API_REST_Clase17.Models;
using BootCamp_API_REST_Clase17.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BootCamp_API_REST_Clase17.Controllers
{



    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public ProductosController(IUnitOfWork context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Productos>> GetAll()
        {
            var entidad = _context.RepoProductos.GetAll();
            return Ok(entidad);
        }

        [HttpGet("{id}")]
        public ActionResult Getby(int id)
        {
            var entidad = _context.RepoProductos.GetById(id);
            return Ok(entidad);
        }

        [HttpGet]
        public ActionResult<List<Productos>> GetAllProv()
        {
            var entidad = _context.RepoProductos.ProdProv();
            return Ok(entidad);
        }

        [HttpGet("{id}")]
        public ActionResult GetByProv(int id)
        {
            var entidad = _context.RepoProductos.ProdProv(id);
            return Ok(entidad);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var entidad = _context.RepoProductos.Delete(id);
            return Ok(entidad);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Productos prod)
        {
            var entidad = _context.RepoProductos.Insert(prod);
            return Ok(entidad);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Productos prod, int id)
        {
            var entidad = _context.RepoProductos.Update(prod);
            return Ok(entidad);
        }
    }
}
