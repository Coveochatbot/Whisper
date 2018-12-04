﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WhisperAPI.Models.MLAPI;

namespace WhisperAPI.Services.MLAPI.LastClickAnalytics
{
    public interface ILastClickAnalytics
    {
        Task<List<LastClickAnalyticsResults>> GetLastClickAnalyticsResults(HashSet<string> contextEntities);
    }
}