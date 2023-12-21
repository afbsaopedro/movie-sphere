using MovieSphereModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSphereDataAccess.Repository.IRepository
{
    public interface ICourseRepository : IRepository<Course>
    {
        void Update(Course obj);
        void Save();
    }
}
