using AppStore.Models.Domain;
using AppStore.Models.DTO;

namespace AppStore.Repositories.Abstract
{
    public interface ILibroService
    {
        bool Add(Libro libro);
        bool Update(Libro libro);
        bool Delete(int id);
        Libro GetById(int id);
        LibroListVm List(string term = "", bool paging = false, int currentPage = 0);
        List<int> GetCategoriaByLibroId(int libroId);
    }
}
