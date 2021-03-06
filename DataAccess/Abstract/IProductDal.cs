﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Dal -> Data Access Layer (.Net) //Dao -> Data Access Object (Java)
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
