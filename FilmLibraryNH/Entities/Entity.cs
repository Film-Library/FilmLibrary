using System;

namespace FilmLibrary.Entities
{
    public abstract class Entity<T> where T : Entity<T>
    {
        public virtual Int32 Id { get; protected set; }

        //Переопределение метода Equals
        public override Boolean Equals(Object obj)
        {
            var other = obj as T;
            if (other == null) return false;
            var thisIsNew = Id == 0;
            var otherIsNew = other.Id == 0;
            if (thisIsNew && otherIsNew)
                return ReferenceEquals(this, other);
            return Id.Equals(other.Id);
        }

        //реализация метода GetHashCode
        private Int32? oldHashCode;
        public override Int32 GetHashCode()
        {
            // если у нас есть хэш-код, мы его никогда не изменяем
            if (oldHashCode.HasValue)
                return oldHashCode.Value;
            //когда этот экземпляр сущности новый, мы используем 
            //основной хэш -код и запоминаем его, т.о. экземпляр //сущности НИКОГДА не сможет изменить этот хэш-код
            var thisIsNew = Id == 0;
            if (thisIsNew)
            {
                oldHashCode = base.GetHashCode();
                return oldHashCode.Value;
            }
            return Id.GetHashCode();
        }

        //переопределение оператора == 
        public static Boolean operator ==(Entity<T> lhs, Entity<T> rhs)
        {
            return Equals(lhs, rhs);
        }
        //переопределение оператора !=
        public static Boolean operator !=(Entity<T> lhs, Entity<T> rhs)
        {
            return !Equals(lhs, rhs);
        }

    }
}
