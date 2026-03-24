using APBD_T2_EquipmentRental.Domain.Users;

namespace APBD_T2_EquipmentRental.Services
{
    public class UserService
    {
        private List<User> users = new();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetAll() => users;
    }
}