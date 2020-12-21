using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Domain
{
    public class Actor
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual ISet<Movie> Movies { get; protected set; } = new HashSet<Movie>();

        public virtual Countrie Countrie { get; protected set; }

        public override string ToString() => $"{Name} из {Countrie}";
    }
}
