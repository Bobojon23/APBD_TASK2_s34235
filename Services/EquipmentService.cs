using APBD_T2_EquipmentRental.Domain.Equipment;

namespace APBD_T2_EquipmentRental.Services
{
    public class EquipmentService
    {
        private List<Equipment> equipment = new();

        public void AddEquipment(Equipment item)
        {
            equipment.Add(item);
        }

        public List<Equipment> GetAll() => equipment;

        public List<Equipment> GetAvailable()
        {
            return equipment.Where(e => e.IsAvailable).ToList();
        }
    }
}