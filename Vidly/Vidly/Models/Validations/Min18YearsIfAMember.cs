using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.Validations
{
    public class Min18YearsIfAMember : ValidationAttribute                        
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //Se guarda el contexto de la validacion, en este caso es un Customer
            var customer = (Customer)validationContext.ObjectInstance;

            //Si no se eligio una Membership o si es una Membership 'Pay as You Go', no se valida nada
            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)            
                return ValidationResult.Success;

            //Valida que la fecha de nacimiento no este vacía
            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            //Calcula la edad del Customer
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            //Valida que el Customer tenga 18 años o más
            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be at least 18 years old to go on a membership");
        }
    }
}