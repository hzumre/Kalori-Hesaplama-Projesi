﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Core.Interfaces
{
    public interface IEntity<T>
    {
        public T ID { get; set; }
    }
}
