using ApiDeGastosMensais.DATA;
using ApiDeGastosMensais.DATA.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDeGastosMensais.API.Controllers
{   
    [Route("api/gasto")]
    [ApiController]
    public class GastoControler: ControllerBase
    {
        private readonly DataContext _context;

        public GastoControler(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Gasto>> GetAll()
        {
            return _context.Gasto.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Gasto> GetById(int id)
        {
            return _context.Gasto.Find(id);
        }

        [HttpPost]
        public ActionResult<Gasto> Create([FromBody] Gasto gasto)
        {
            _context.Gasto.Add(gasto);
            _context.SaveChanges();
            return gasto;
        
        }

        [HttpPut]
        public ActionResult<Gasto> Update([FromBody] Gasto gasto)
        {
            _context.Entry(gasto).State = EntityState.Modified;
            _context.SaveChanges();
            return gasto;
               
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Gasto gasto = _context.Gasto.Find(id);
            _context.Gasto.Remove(gasto);
            _context.SaveChanges();

        }



    
    }

}
