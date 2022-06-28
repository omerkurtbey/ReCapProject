using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }


        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {

            var result = BusinessRules.Run(CheckCarImagesLimit(carImage.CarId));

            if (result != null)
            {
                return new ErrorResult(result.Message);
            }
            carImage.ImagePath = FileHelper.Upload(file, PathConstants.ImagesPath);
            _carImageDal.Add(carImage);


            return new SuccessResult(Messages.Added);
        }


        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile file, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckCarImagesLimit(carImage.CarId));
            if (result != null)
            {
                return new ErrorResult(result.Message);
            }

            FileHelper.Update(file, PathConstants.ImagesPath + carImage.ImagePath, PathConstants.ImagesPath);
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Updated);
        }
        //[SecuredOperation("admin,moderator")]
        public IResult Delete(CarImage carImage)

        {
            FileHelper.Delete(PathConstants.ImagesPath + carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.Listed);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id), Messages.Listed);
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var result = BusinessRules.Run(CheckCarIsHaveImage(carId));
            if (result != null)
            {
                return new SuccessDataResult<List<CarImage>>(GetDefaultImage(), Messages.Listed);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }

        #region BusinessRules

        private List<CarImage> GetDefaultImage()
        {
            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage { ImagePath = "DefaultImage.png" });
            return carImage;
        }

        private IResult CheckCarIsHaveImage(int carId)
        {
            if (_carImageDal.GetAll(c => c.CarId == carId).Count == 0)
            {
                return new ErrorResult(Messages.NotFound);
            }

            return new SuccessResult();
        }

        private IResult CheckCarImagesLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result > 5)
            {
                return new ErrorResult(Messages.CarImagesLimitExceded);
            }

            return new SuccessResult();
        }

        #endregion
    }
}
