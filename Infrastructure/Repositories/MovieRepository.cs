using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;

namespace Infrastructure.Repositories
{
    public class MovieRepository
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> Get30HighestRatedMovies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie GetByCondition(Expression<Predicate<Movie>> filter)
        {
            throw new NotImplementedException();
        }

   

        public IEnumerable<Movie> GetByGenre(int id)
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Movie entity)
        {
            throw new NotImplementedException();
        }

       

        public int Update(Movie entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
