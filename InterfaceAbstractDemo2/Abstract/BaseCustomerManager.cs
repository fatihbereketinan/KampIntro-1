﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo2.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to DB : "+ customer.FirstName);
        }
    }
}
