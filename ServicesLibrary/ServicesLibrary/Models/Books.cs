using ServicesLibrary.Base.BaseRepository;

namespace ServicesLibrary.Models
{
    public class Books : BaseModel
    {
        public string Titulo { get; set; }
        public int IdAutor { get; set; }

    }
}
