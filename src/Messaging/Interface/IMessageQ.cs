﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Azure
{
    public interface IMessageQ
    {
        void Initialize(string queueName);
        void Send(string queueName, object message);
    }
}
