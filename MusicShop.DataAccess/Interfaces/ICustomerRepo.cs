﻿using MusicShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.DataAccess.Interfaces
{
    public interface ICustomerRepo : IRepo<Customer>
    {
        void Update(Customer customer);

	}
}
