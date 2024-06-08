using WebBaoDoi.Models;

namespace WebBaoDoi.Repository
{
    public interface IFacultyRepository
    {
        void Delete(int id);
        void Edit(Faculties faculties);
        void Add(Faculties faculties);
        IEnumerable<Faculties> GetAllFaculties();
        string? GetById(int id);
    }
}
