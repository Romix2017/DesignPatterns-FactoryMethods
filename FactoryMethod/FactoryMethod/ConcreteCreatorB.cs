using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
