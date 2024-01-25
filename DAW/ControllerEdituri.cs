[ApiController]
[Route("api/[controller]")]
public class EdituriController : ControllerBase
{
    private readonly BibliotecaContext _context;

    public EdituriController(BibliotecaContext context)
    {
        _context = context;
    }

    // Endpoint pentru afisarea tuturor editurilor
    [HttpGet]
    public IActionResult GetEdituri()
    {
        var edituri = _context.Edituri.ToList();
        return Ok(edituri);
    }

    // Endpoint pentru adaugarea unei noi edituri
    [HttpPost]
    public IActionResult AdaugaEditura([FromBody] Editura editura)
    {
        _context.Edituri.Add(editura);
        _context.SaveChanges();
        return Ok(editura);
    }

}
