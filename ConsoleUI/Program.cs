using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CarManager carManager = new CarManager(new EFCarDal());
var result = carManager.GetAllCars();
foreach (var car in result.Data)
{
    Console.WriteLine(car.Description);
}
