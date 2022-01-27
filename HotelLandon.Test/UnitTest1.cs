using System;
using System.Collections.Generic;
using Xunit;
using System.Data;


namespace HotelLandon.Test
{
    public class UnitTest1
    {
        string[] eleves;

        [Theory]
        [InlineData("Ferhat")]
        [InlineData("saad")]
        [InlineData("mallaury")]
        [InlineData("mathieu")]
        [InlineData("mourad")]
        [InlineData("lassina")]
        [InlineData("leo")]
        [InlineData("latifa")]
        [InlineData("guy")]
        public void Camarades(string name)
        {
            // Arrange : 
            int nbEleves = 9;
            //string[] eleves;

            // Act :
            for (int i=0; i > 9; i++) 
            { 
                string Name = name;                              
                eleves[i] = Name;                
            }

            //Assert :
            Assert.Equal(nbEleves, eleves.Length);


        }
    }
}
