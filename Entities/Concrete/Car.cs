using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public  class Car:IEntity

    {
        public int Id { get; set; }
        public int BrandId { get; set; }  //marka 
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }  //günlük kiralama fiyatı
        public string Description { get; set; } //açıklama
    }
}
