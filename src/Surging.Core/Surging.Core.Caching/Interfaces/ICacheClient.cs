﻿using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Surging.Core.Caching.Interfaces
{
    public interface ICacheClient<T>
    {
        T GetClient(CacheEndpoint info, int connectTimeout);

        ConnectionMultiplexer Connection(CacheEndpoint endpoint, int connectTimeout);
    }
}
