using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBording.Tests
{
    public class TestingValidationsFields
    {
        [Fact]
        public void MyKundeModel_Invalid_When_Email_Is_Null ( )
        {
            KundeEntity getValidModel ( ) => new KundeEntity
            {
                Email = "Some value",
                Fornavn = "Some value",
                Telefon = "12345",
            };

            var myModel = getValidModel( );
            myModel.Email = null;

            Assert.True(myModel.Email == null);
        }
        [Fact]
        public void MyKundeModel_Invalid_When_Name_IsNot_Null ( )
        {
            KundeEntity getValidModel ( ) => new KundeEntity
            {
                Email = "Some value",
                Fornavn = "Some value",
                Telefon = "12345",
            };

            var myModel = getValidModel( );
            myModel.Fornavn = "juan";

            Assert.True(myModel.Fornavn != null);
        }
        [Fact]
        public void MyKundeModel_Invalid_When_Telfon_IsNot_Null ( )
        {
            KundeEntity getValidModel ( ) => new KundeEntity
            {
                Email = "Some value",
                Fornavn = "Some value",
                Telefon = "12345",
            };

            var myModel = getValidModel( );
            myModel.Telefon = "12345";

            Assert.True(myModel.Telefon != null);
        }
    }
}
