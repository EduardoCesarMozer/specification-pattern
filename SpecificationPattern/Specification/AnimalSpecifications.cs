using SpecificationPattern.Model;
using System.Linq;

namespace SpecificationPattern.Specification
{
    public class AnimalSpecifications
    {
        public static Specification<Animal> Normal =
            new Specification<Animal>(ep =>
                (ep.Treatments == null ||
                 ep.Treatments.Where(t => t.InTreatment).Count() == 0) &&
                ep.DeathDate == null);

        public static Specification<Animal> InTreatment =
            new Specification<Animal>(ep =>
                (ep.Treatments != null &&
                 ep.Treatments.Where(t => t.InTreatment).Count() > 0) &&
                ep.DeathDate == null);

        public static Specification<Animal> Dead =
            new Specification<Animal>(ep =>
                ep.DeathDate != null);
    }
}