using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TiendasEmpleados.Controllers
{
    public class CargosController : ApiController
    {
        // GET: api/Cargos
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cargos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cargos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cargos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cargos/5
        public void Delete(int id)
        {
        }
    }
}
