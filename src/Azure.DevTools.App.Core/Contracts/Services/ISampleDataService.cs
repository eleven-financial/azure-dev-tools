﻿using System.Collections.Generic;
using System.Threading.Tasks;

using Azure.DevTools.App.Core.Models;

namespace Azure.DevTools.App.Core.Contracts.Services;

// Remove this class once your pages/features are using your data.
public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetContentGridDataAsync();

    Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
}
