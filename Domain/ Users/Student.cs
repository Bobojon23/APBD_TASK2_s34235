namespace APBD_T2_EquipmentRental.Domain.Users
{
    public class Student : User
    {
        public override int MaxRentals => 2;
    }
}