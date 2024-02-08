using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Laboratorium3.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratorium3Tests.Models
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void Computer_ValidData_ShouldPassValidation()
        {
            // Arrange
            var computer = new Computer
            {
                Id = 1,
                Nazwa = "Komputer Testowy",
                Procesor = "Testowy Procesor",
                Memory = 8,
                Karta_Graficzna = "Testowa Karta Graficzna",
                Producent = "Testowy Producent",
                Data_Produkcji = DateTime.Now,
                Priority = Priority.High // Zak³adam, ¿e masz enum Priority zdefiniowany w modelu
            };

            // Act
            var validationContext = new ValidationContext(computer, null, null);
            var validationResult = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(computer, validationContext, validationResult, true);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Computer_InvalidData_ShouldFailValidation()
        {
            // Arrange
            var computer = new Computer
            {
                Id = 2,
                Nazwa = null, // Invalid, as it is required
                Procesor = "Testowy Procesor",
                Memory = 8,
                Karta_Graficzna = "Testowa Karta Graficzna",
                Producent = "Testowy Producent",
                Data_Produkcji = DateTime.Now,
                Priority = (Priority)100 // Invalid value for Priority enum
            };

            // Act
            var validationContext = new ValidationContext(computer, null, null);
            var validationResult = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(computer, validationContext, validationResult, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(1, validationResult.Count); // 1 expected validation error
            Assert.IsTrue(validationResult[0].ErrorMessage.Contains("Priority"));
        }

    }
}
