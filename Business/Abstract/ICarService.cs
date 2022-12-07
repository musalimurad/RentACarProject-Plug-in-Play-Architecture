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
        public IDataResult<List<Car>> GetAllCars();
        public IDataResult<Car> getByIdCar(int carId);
        public IResult Add(Car car);
        public IResult Update(Car car);
        public IResult Delete(Car car); 
    }
}
