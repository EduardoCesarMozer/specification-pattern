using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Specification
{
    public class Specification<T>
    {
        public Func<T, bool> Criteria { get; private set; }

        public Specification(Expression<Func<T, bool>> criteria)
        {
            if (criteria == null)
                throw new ArgumentNullException("It's necessary a criteria.");
            else
                Criteria = criteria.Compile();
        }

        public bool IsSatisfiedBy(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("It's necessary an entity of type <T>.");

            return Criteria.Invoke(entity);
        }
    }
}