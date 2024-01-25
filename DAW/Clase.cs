public class Autor
{
    public int AutorId { get; set; }
    public string Nume { get; set; }
    public virtual ICollection<Carte> Carti { get; set; }
}

public class Carte
{
    public int CarteId { get; set; }
    public string Titlu { get; set; }
    public virtual ICollection<Autor> Autori { get; set; }
    public int EdituraId { get; set; }
    public virtual Editura Editura { get; set; }
}

public class Editura
{
    public int EdituraId { get; set; }
    public string Nume { get; 
    public virtual ICollection<Autor> Autori { get; set; }
    public virtual ICollection<Carte> Carti { get; set; }
}