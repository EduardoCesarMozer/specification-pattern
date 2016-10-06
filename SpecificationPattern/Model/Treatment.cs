
namespace SpecificationPattern.Model
{
    public class Treatment
    {
        public int Id { get; set; }
        public bool InTreatment { get; set; }
        public int AnimalId { get; set; }

        public Animal Animal { get; set; }
    }
}