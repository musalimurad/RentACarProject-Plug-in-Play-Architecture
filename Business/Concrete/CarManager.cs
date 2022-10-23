﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Message.CarSuccess);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete( car);
            return new SuccessResult(Message.CarDeleteSuccess);
        }

        public IDataResult<List<Car>> GetAllCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Message.CarDataLoadedSuccess);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Message.CarUpdateSuccess);
        }
    }
}
