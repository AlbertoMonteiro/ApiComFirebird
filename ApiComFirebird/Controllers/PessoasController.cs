using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Http;
using ApiComFirebird.Models;

namespace ApiComFirebird.Controllers
{
    public class PessoasController : ApiController
    {
        private readonly ContextoDoBancoDeDados _contexto;

        public PessoasController()
        {
            _contexto = new ContextoDoBancoDeDados();
            _contexto.Database.CreateIfNotExists();
        }

        // GET api/pessoas
        public IEnumerable<Pessoa> Get()
        {
            return _contexto.Pessoa.ToList();
        }

        // GET api/pessoas/5
        public Pessoa Get(long id)
        {
            return _contexto.Pessoa.Find(id);
        }

        // POST api/pessoas
        public void Post([FromBody]Pessoa pessoa)
        {
            _contexto.Pessoa.AddOrUpdate(pessoa);
            _contexto.SaveChanges();
        }

        // PUT api/pessoas/5
        public void Put(long id, [FromBody]Pessoa pessoa)
        {
            pessoa.Id = id;
            _contexto.Pessoa.AddOrUpdate(pessoa);
            _contexto.SaveChanges();
        }

        // DELETE api/pessoas/5
        public void Delete(long id)
        {
            var entry = _contexto.Entry(new Pessoa { Id = id });
            entry.State = EntityState.Deleted;
            _contexto.SaveChanges();
        }
    }
}
