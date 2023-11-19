using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        [MinLengthAttribute(3,ErrorMessage ="2 karakterden fazla olmalıdır.")]
        public string CarName { get; set; }
        public string ModelYear { get; set; }
        //[Greater]
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
