namespace APBD_T2_EquipmentRental.Domain.Users
{
    public class Employee : User
    {
        public override int MaxRentals => 5;
    }
}