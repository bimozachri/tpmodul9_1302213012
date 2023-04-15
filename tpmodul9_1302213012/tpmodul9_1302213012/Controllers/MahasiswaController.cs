using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302213012.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private static List<Mahasiswa> dataMhs = new List<Mahasiswa>
        {
            new Mahasiswa("Bimo Zachriansyah Wicaksono Hermawan", "1302213012"),
            new Mahasiswa("Muhammad Vikhan Muharram", "1302213089"),
            new Mahasiswa("Muhammad Fadhil Ardiansyah Supiyan", "1302210006"),
            new Mahasiswa("Heru Ikhsan Maulana", "1302210009"),
            new Mahasiswa("Faris Siddiq Ramdan Putra", "1302213133")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMhs;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMhs[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMhs.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            dataMhs[id] = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMhs.RemoveAt(id);
        }
    }
}