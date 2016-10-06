using SpecificationPattern.Specification;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SpecificationPattern.Model
{
    public class Animal
    {
        public int Id { get; set; }
        public DateTime BirthdayDate { get; set; }
        public DateTime? DeathDate { get; set; }

        public List<Treatment> Treatments { get; set; }

        public AnimalState State =>
            AnimalSpecifications.Dead.IsSatisfiedBy(this)
                ? AnimalState.Dead
                : AnimalSpecifications.InTreatment.IsSatisfiedBy(this)
                    ? AnimalState.InTreatment
                    : AnimalState.Normal;
    }

    public enum AnimalState
    {
        [Description("Normal")]
        Normal,
        [Description("In Treatment")]
        InTreatment,
        [Description("Dead")]
        Dead
    }
}