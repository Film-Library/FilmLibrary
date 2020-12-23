namespace Movies.NH.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Movies.Domain;

    public interface IDirectorRepository
    {
        IQueryable<Director> Filter(Expression<Func<Director, bool>> filter);

        //Director Get(int id);

        IQueryable<Director> GetAll();

        bool TryGet(int id, out Director director);
    }
}