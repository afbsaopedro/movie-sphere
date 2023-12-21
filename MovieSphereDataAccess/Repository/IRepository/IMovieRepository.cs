using MovieSphereModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSphereDataAccess.Repository.IRepository
{
    public interface IMovieRepository : IRepository<Movie>
    {
        void Update(Movie obj);
    }
}
