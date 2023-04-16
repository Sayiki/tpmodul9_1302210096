using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302210096.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswa : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("ARZAQ AJRADIKA", "1302210096"),
            new Mahasiswa("YESA", "02"),
            new Mahasiswa("TRIANI", "03"),
            new Mahasiswa("HERMAWAN", "04"),
            new Mahasiswa("DHAFA", "05")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            dataMahasiswa[id] = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
