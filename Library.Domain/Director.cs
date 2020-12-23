using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Domain
{
    public class Director
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual ISet<Movie> Movie { get; protected set; } = new HashSet<Movie>();

        public override string ToString() => Name;

        [Obsolete("Конструктор только для ORM")]
        protected Director() { }

        public Director(string fullName/*lastName, string firstName, string middleName*/)
        {
            //this.Name = new Name(firstName, lastName, middleName);
            this.Name = fullName;
        }
    }
}
