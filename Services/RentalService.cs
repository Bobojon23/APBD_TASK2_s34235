using APBD_T2_EquipmentRental.Domain.Equipment;
using APBD_T2_EquipmentRental.Domain.Users;
using APBD_T2_EquipmentRental.Domain.Rental;
using APBD_T2_EquipmentRental.Exceptions;

namespace APBD_T2_EquipmentRental.Services
{
    public class RentalService
    {
        private List<Rental> rentals = new();
        private PenaltyCalculator penaltyCalculator = new();

        public void Rent(User user, Equipment equipment, int days)
        {
            if (!equipment.IsAvailable)
                throw new NotAvailableException("Equipment not available");

            int activeRentals = rentals.Count(r => r.User == user && r.IsActive);

            if (activeRentals >= user.MaxRentals)
                throw new RentalException("User exceeded rental limit");

            var rental = new Rental
            {
                User = user,
                Equipment = equipment,
                RentDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(days)
            };

            equipment.MarkUnavailable();
            rentals.Add(rental);
        }

        public void Return(Equipment equipment)
        {
            var rental = rentals.FirstOrDefault(r => r.Equipment == equipment && r.IsActive);

            if (rental == null)
                throw new RentalException("Rental not found");

            rental.ReturnDate = DateTime.Now;
            rental.Penalty = penaltyCalculator.Calculate(rental.DueDate, rental.ReturnDate.Value);

            equipment.MarkAvailable();
        }

        public List<Rental> GetActiveRentals(User user)
        {
            return rentals.Where(r => r.User == user && r.IsActive).ToList();
        }

        public List<Rental> GetOverdueRentals()
        {
            return rentals.Where(r => r.IsOverdue).ToList();
        }

        public List<Rental> GetAll() => rentals;
    }
}