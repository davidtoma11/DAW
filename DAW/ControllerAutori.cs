[ApiController]
[Route("api/[controller]")]
public class AutoriController : ControllerBase
{
    private readonly BibliotecaContext _context;

    public AutoriController(BibliotecaContext context)
    {
        _context = context;
    }

    // Endpoint pentru afisarea tuturor autorilor
    [HttpGet]
    public IActionResult GetAutori()
    {
        var autori = _context.Autori.ToList();
        return Ok(autori);
    }

    // Endpoint pentru adaugarea unui nou autor
    [HttpPost]
    public IActionResult AdaugaAutor([FromBody] Autor autor)
    {
        _context.Autori.Add(autor);
        _context.SaveChanges();
        return Ok(autor);
    }

}
