namespace APBD_T2_EquipmentRental.Services
{
    public class PenaltyCalculator
    {
        private const decimal DailyPenalty = 10;

        public decimal Calculate(DateTime dueDate, DateTime returnDate)
        {
            if (returnDate <= dueDate)
                return 0;

            int daysLate = (returnDate - dueDate).Days;
            return daysLate * DailyPenalty;
        }
    }
}