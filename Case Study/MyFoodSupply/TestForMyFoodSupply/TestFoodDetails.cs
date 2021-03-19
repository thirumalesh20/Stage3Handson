using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyFoodSupply;

namespace TestForMyFoodSupply
{
    public class TestFoodDetails
    {
        [TestFixture]
        public class TestForMedicine
        {
            Program p = new Program();
            FoodDetail Food = new FoodDetail();

            [OneTimeSetUp]
            public void Init()
            {

                p = new Program();
                Food = new FoodDetail() { Name = "Momos", DishType = FoodDetail.Category.MainDish, ExpiryDate = DateTime.Now.AddYears(5), Price = 100.0 };


            }



            [Test]
            [TestCase("Momos", FoodDetail.Category.MainDish, 100.00, "12/5/2025")]
            public void TestFoodObjectCreation(string FoodName, int Category, double Price, DateTime ExpDate)
            {
                FoodDetail F = null;
                try
                {

                    F = p.CreateFoodDetail(FoodName, Category, ExpDate, Price);

                    Assert.IsNotNull(F);

                }
                catch (Exception)
                {

                    Assert.Fail("FoodDetail Object not created successfully");
                }



            }


            [Test]
            [TestCase("", FoodDetail.Category.MainDish, 200.00, "03/10/2021")]
            //[TestCase("Momo", FoodDetail.Category.MainDish, -12, "03/8/2021")]
            //[TestCase("Momo", FoodDetail.Category.MainDish, 200.00, "12/10/2020")] 
            public void ExceptionTestfor_FoodItem_ForEmptyString(string FoodName, int Category, double Price, DateTime ExpDate)
            {
                var exp = Assert.Throws<Exception>(() => p.CreateFoodDetail(FoodName, Category, ExpDate, Price));

                Assert.AreEqual("Dish name cannot be empty. Please provide valid value", exp.Message);

            }


            [Test]
            [TestCase("Momo", FoodDetail.Category.MainDish, -12, "03/10/2021")]
            //[TestCase("", FoodDetail.Category.MainDish, 200.00, "03/8/2021")]
            //[TestCase("Momo", FoodDetail.Category.MainDish, 200.00, "12/10/2020")]
            public void ExceptionTestfor_FoodItem_ForPriceValue(string FoodName, int Category, double Price, DateTime ExpDate)
            {
                var exp = Assert.Throws<Exception>(() => p.CreateFoodDetail(FoodName, Category, ExpDate, Price));

                Assert.AreEqual("Incorrect value for dish price. Please provide valid value", exp.Message);

            }

            [Test]
            [TestCase("Momo", FoodDetail.Category.MainDish, 200.00, "12/10/2020")]
            //[TestCase("", FoodDetail.Category.MainDish, 200.00, "03/8/2021")]
            //[TestCase("Momo", FoodDetail.Category.MainDish, 200.00, "03/10/2021")]
            public void ExceptionTestfor_FoodItem_ForExpiredate(string FoodName, int Category, double Price, DateTime ExpDate)
            {
                var exp = Assert.Throws<Exception>(() => p.CreateFoodDetail(FoodName, Category, ExpDate, Price));

                Assert.AreEqual("Incorrect expiry date. Please provide valid value", exp.Message);

            }

            //SupplyDetails testing

            [Test]
            [TestCase(10, "10/04/2021", "UberFoods", 180.00)]

            public void CheckSupplyDetailObjectCreation(int Count, DateTime Requested_Date, string Seller_Name, double Package_Charge)
            {
                SupplyDetail SD = null;
                try
                {

                    SD = p.CreateSupplyDetail(Count, Requested_Date, Seller_Name, Package_Charge, Food);
                    Assert.IsNotNull(SD);
                }
                catch
                {

                    Assert.Fail("SupplyDetail Object not created successfully");
                }
            }

            [Test]

            [TestCase(10, "10/04/2020", "UberFoods", 180.00)]

            public void Exception_TestSupplyDetail_Date(int Count, DateTime Requested_Date, string Seller_Name, double Package_Charge)
            {

                var exp = Assert.Throws<Exception>(() => p.CreateSupplyDetail(Count, Requested_Date, Seller_Name, Package_Charge, Food));

                Assert.AreEqual("Incorrect food request date. Please provide valid value", exp.Message);



            }

            [Test]

            [TestCase(-12, "10/04/2021", "UberFoods", 180.00)]

            public void Exception_TestSupplyDetails_Count(int Count, DateTime Requested_Date, string Seller_Name, double Package_Charge)
            {

                var exp = Assert.Throws<Exception>(() => p.CreateSupplyDetail(Count, Requested_Date, Seller_Name, Package_Charge, Food));

                Assert.AreEqual("Incorrect food item count. Please check", exp.Message);



            }
            [Test]

            [TestCase(10, "10/04/2021", "Uberfoods", 180.00, null)]

            public void Testing_SupplyDetail_NotNull(int count, DateTime requestedDate, string SellerName, double packageCharge, FoodDetail food)
            {

                SupplyDetail s = p.CreateSupplyDetail(count, requestedDate, SellerName, packageCharge, food);

                Assert.IsNull(s);




            }
        }
    }
}

