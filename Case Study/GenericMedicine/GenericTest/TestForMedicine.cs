using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMedicine;

namespace GenericTest
{
    [TestFixture]
    public class TestForMedicine
    {
        Program p = new Program();
        Medicine med = new Medicine();

        [OneTimeSetUp]
        public void Init()
        {

            p = new Program();
            med = new Medicine() { Name = "Dolo-65", GenericMedicineName = "Pain Killer", Composition = "comp1,comp2", ExpiryDate = DateTime.Now.AddYears(5), PricePerStrip = 5.00 };


        }



        [Test]
        [TestCase("Dolo-65", "Pain killer", "comp1,comp2", "12/5/2024", 5.00)]
        public void TestMedicineObjectCreation(string MedName, string MedicineType, string Composition, DateTime Expire, double Price)
        {
            Medicine medi = null;
            try
            {

                medi = p.CreateMedicineDetail(MedName, MedicineType, Composition, Expire, Price);

                Assert.IsNotNull(medi);

            }
            catch (Exception)
            {

                Assert.Fail("Medicine Object not created ");
            }



        }


        [Test]
        [TestCase("Dolo-65", "", "comp1,comp2", "10/02/2024", 5.00)]
        //[TestCase("Dolo-65", "Pain killer", "comp1,comp2", "10/02/2022", 0.1)]
        //[TestCase("Dolo-65", "Pain killer", "comp1,comp2", "10/03/2023", 5.00)]
        public void ExceptionTestMedicineEmptyGenericString(string MedName, string MedicineType, string Composition, DateTime Expire, double Price)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateMedicineDetail(MedName, MedicineType, Composition, Expire, Price));

            Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", exp.Message);

        }


        [Test]
        [TestCase("Dolo-65", "Pain killer", "comp1,comp2", "10/02/2025", -12)]
        //[TestCase("Dolo-65", "", "comp1,comp2", "10/02/2024", 5.00)]
        //[TestCase("Dolo-65", "Pain killer", "comp1,comp2", "10/03/2020", 5.00)]
        public void ExceptionTestMedicinePriceBelowZero(string MedName, string MedicineType, string Composition, DateTime Expire, double Price)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateMedicineDetail(MedName, MedicineType, Composition, Expire, Price));

            Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", exp.Message);

        }

        [Test]
        [TestCase("Dolo-65", "Pain killer", "comp1,comp2", "10/03/2020", 5.00)]
        //[TestCase("Dolo-65", "", "comp1,comp2", "10/02/2024", 5.00)]
        //[TestCase("Dolo-65", "Pain killer", "comp1,comp2", "10/02/2025", 0.1)]
        public void ExceptionTestMedicineExpiryDateLessThanCurrent(string MedName, string MedicineType, string Composition, DateTime Expire, double Price)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateMedicineDetail(MedName, MedicineType, Composition, Expire, Price));

            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exp.Message);

        }

        //Carton object cheking


        [Test]
        [TestCase(1, "10/04/2021", "Retailer address")]
        //[TestCase(0, "10/04/2021", "Retailer address")] 
        //[TestCase(12, "11/02/2020", "Retailer address"]    




        public void CheckCortonObjectCreation(int Count, DateTime LaunchDate, string Address)
        {
               CartonDetail c = null;
               try
               {

                 c = p.CreateCartonDetail(Count, LaunchDate, Address, med);
                  Assert.IsNotNull(c);
               }
               catch
               {

                  Assert.Fail("Corton Object not created successfully");
               }
        }

        [Test]
        [TestCase(12, "10/01/2020", "Retailer address")]

        public void ExceptionTestCortonLaunchDateLessThanCurrent(int Count, DateTime LaunchDate, string Address)
        {

           var exp = Assert.Throws<Exception>(() => p.CreateCartonDetail(Count, LaunchDate, Address, med));

           Assert.AreEqual("Incorrect launch date. Please provide valid value", exp.Message);



        }

        [Test]
        [TestCase(0, "10/04/2021", "Retailer address")]
         public void ExceptionTestCorton(int Count, DateTime LaunchDate, string Address)
         {


              var exp = Assert.Throws<Exception>(() => p.CreateCartonDetail(Count, LaunchDate, Address, med));

              Assert.AreEqual("Incorrect strip count. Please check", exp.Message);


         }

        [Test]
        [TestCase(12, "10/01/2020", "Retailer address", null)]

        public void CheckForNullCartonObject(int count, DateTime launchYears, string address, Medicine medi)
        {
            CartonDetail carton = p.CreateCartonDetail(count, launchYears, address, medi);

            Assert.IsNull(carton);


        }
    }
}