using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        public List<Car> GetAllCars();
        public Car getByIdCar(int carId);
        public IDataResult<List<Car>> GetAllCarss();
        public IResult Add(Car car);
        public IResult Update(Car car);
        public IResult Delete(Car car); 
    }
}
