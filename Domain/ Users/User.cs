namespace APBD_T2_EquipmentRental.Domain.Users
{
    public abstract class User
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract int MaxRentals { get; }
    }
}