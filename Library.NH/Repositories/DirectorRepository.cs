namespace Movies.NH.Repositories
{
    using NHibernate;
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Movies.Domain;

    public class DirectorRepository : IDirectorRepository
    {
        private readonly ISessionFactory sessionFactory;

        private readonly ISession session;

        public DirectorRepository(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory ?? throw new ArgumentNullException(nameof(sessionFactory));

            this.session = this.sessionFactory.OpenSession();
        }

        public IQueryable<Director> GetAll()
        {
            return this.session.Query<Director>();
        }

        public bool TryGet(int id, out Director director)
        {
            director = this.GetAll().SingleOrDefault(t => t.Id == id);
            return director != null;
        }

        public IQueryable<Director> Filter(Expression<Func<Director, bool>> filter)
        {
            return this.GetAll().Where(filter);
        }

    }
}
