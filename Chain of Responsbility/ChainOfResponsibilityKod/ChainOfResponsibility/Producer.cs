using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    abstract class Producer
    {
        protected Producer producer;
        public void BuildChain (Producer producer)
        {
            this.producer = producer;
        }

        public abstract void MakeDemand(PlaneMessage message);

    }
}
