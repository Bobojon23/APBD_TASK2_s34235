using APBD_T2_EquipmentRental.Domain.Users;
using APBD_T2_EquipmentRental.Domain.Equipment;
using APBD_T2_EquipmentRental.Services;
using APBD_T2_EquipmentRental.Exceptions;

class Program
{
    static void Main()
    {
        var equipmentService = new EquipmentService();
        var userService = new UserService();
        var rentalService = new RentalService();

        var student = new Student { FirstName = "Jan", LastName = "Kowalski" };
        var laptop = new Laptop { Name = "Dell XPS", CPU = "i7", RAM = 16 };

        userService.AddUser(student);
        equipmentService.AddEquipment(laptop);

        try
        {
            rentalService.Rent(student, laptop, 1);
            Console.WriteLine("Rental successful");

            rentalService.Return(laptop);
            Console.WriteLine("Returned successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"Active rentals: {rentalService.GetAll().Count}");
    }
}