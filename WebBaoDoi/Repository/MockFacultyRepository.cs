using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebBaoDoi.Models;

namespace WebBaoDoi.Repository
{
    public class MockFacultyRepository: IFacultyRepository
    {
        private List<Faculties> _facultyList;
        public MockFacultyRepository() 
        {
            _facultyList = new List<Faculties>
            {
                new Faculties { Id = 1, Name = "IT"},
                new Faculties { Id = 2, Name = "Business"},
                new Faculties { Id = 3, Name = "Graphic Design"},
            };
        }

        public void Add(Faculties faculties)
        {
        }

        public void Delete(int id)
        {
            
        }

        public void Edit(Faculties faculties)
        {
        }

        public IEnumerable<Faculties> GetAllFaculties()
        {
            return _facultyList;
        }

        public string? GetById(int id)
        {
            return string.Empty;
        }
    }
}
