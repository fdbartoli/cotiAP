﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotiAP.Logic
{
     interface IABMLogic<T>
    {

        List<T> GetAll();
        void Delete(int id);
        void Add(T newItem);

        void Update(T item);
    }
}
