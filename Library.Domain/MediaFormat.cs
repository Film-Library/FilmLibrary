using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Domain
{
    public class MediaFormat
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual ISet<Movie> Movies { get; protected set; } = new HashSet<Movie>();

        public override string ToString() => Name;
    }
}
