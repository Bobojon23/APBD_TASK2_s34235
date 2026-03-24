using APBD_T2_EquipmentRental.Domain.Equipment;
using APBD_T2_EquipmentRental.Domain.Users;

namespace APBD_T2_EquipmentRental.Domain.Rental
{
    public class Rental
    {
        public Equipment Equipment { get; set; }
        public User User { get; set; }

        public DateTime RentDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public decimal Penalty { get; set; }

        public bool IsActive => ReturnDate == null;

        public bool IsOverdue => IsActive && DateTime.Now > DueDate;
    }
}