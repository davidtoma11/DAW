[ApiController]
[Route("api/[controller]")]
public class CartiController : ControllerBase
{
    private readonly BibliotecaContext _context;

    public CartiController(BibliotecaContext context)
    {
        _context = context;
    }

    // Endpoint pentru afisarea tuturor cartilor
    [HttpGet]
    public IActionResult GetCarti()
    {
        var carti = _context.Carti.Include(c => c.Editura).Include(c => c.Autori).ToList();
        return Ok(carti);
    }

    // Endpoint pentru adaugarea unei noi carti
    [HttpPost]
    public IActionResult AdaugaCarte([FromBody] Carte carte)
    {
        _context.Carti.Add(carte);
        _context.SaveChanges();
        return Ok(carte);

}
