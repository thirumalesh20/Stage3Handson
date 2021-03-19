
using System;

namespace GenericMedicine
{
    interface IGenerics
    {

        Medicine CreateMedicineDetail(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip);

        CartonDetail CreateCartonDetail(int medicineStripCount, DateTime launchDate, string retailerAddress, Medicine medicine);

    }
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GenericMedicineName { get; set; }
        public string Composition { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double PricePerStrip { get; set; }
    }
}
