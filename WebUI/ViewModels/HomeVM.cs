using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace WebUI.ViewModels
{
    public class HomeVM
    {
      public List<Car> Cars { get; set; }
    }
}
