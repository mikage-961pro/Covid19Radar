﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Radar.DataAccess
{
    public interface ISequenceRepository
    {
        Task<int> GetNextAsync(string key, int startNo);
    }
}
