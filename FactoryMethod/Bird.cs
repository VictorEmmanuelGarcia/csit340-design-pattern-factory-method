﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Bird : IAnimal
    {
        public string Render() => "Bird!";
    }
}
