using Xunit;
using System;
using HotelLandon.Models;

namespace HotelLandon.Test
{

    public class UnitTest1
    {
        [Fact]
        public void Customer()
        {
            // Arrange : initialisation des variables
            Customer customer = new()
            {
                FirstName = "yo",
                LastName = "ba",
                BirthDate = new DateTime(2000, 02, 19)
            };

            // Act : Executer le operations necesssaires

            // Assert : Verifier que le resultat attend est égale à celui du produit

            Assert.True(customer.FirstName.Length > 1);
           // Assert.True(GetType(customer.LastName));
            Assert.NotNull(customer);

        }

        [Fact]
        public void Calculer()
        {
            int s = 10;
            int d = 3;
            int result = s * d;
            Assert.True(result > 20 );
        }

        [Theory]
        [InlineData("mohammad","ali")]
        [InlineData("albert","einstein")]
        [InlineData("buzz","aldrin")]
        public void Famous_people(string FirstName, string LastName)
        {
            for(int i =0; i>3;i++)
            {
                Celeberity Celeb = new()
                {
                    firstName = FirstName,
                    lastName = LastName,
                };
            }
            Assert.IsNotType(Customer, Celeb);
        }

        private class Celeberity
        {
            public string firstName;
            public string lastName;

           
        }
    } 
}