using MovieSphereDataAccess.Data;
using MovieSphereDataAccess.Repository.IRepository;
using MovieSphereModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieSphereDataAccess.Repository
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private ApplicationDbContext _db;

        public MovieRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Movie obj)
        {
            _db.Movies.Update(obj);
        }
    }
}
