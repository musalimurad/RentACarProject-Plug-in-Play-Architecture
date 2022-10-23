using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager carManager = new CarManager(new EFCarDal());
Car carOptima = new() { BrandId = 1, ColorId = 2, DailyPrice = 70, ModelYear = DateTime.Now, Description = "Kia Optima yeni" };
//carManager.Add(carOptima);
Car carOptimaKohne = new() { BrandId = 1, ColorId = 4, DailyPrice = 75, ModelYear = DateTime.Now, Description = "Kia Optima Kohne vuruq var" };
//carManager.Add(carOptimaKohne);

Car deleteCar1 = new() { Id = 2 };
//carManager.Delete(deleteCar1);

Car testCarUpdate = new() { Id = 3, Description = "test-2" };
carManager.Update(testCarUpdate);
var result = carManager.GetAllCars();
foreach (var car in result.Data)
{
    Console.WriteLine(car.Description);
}
