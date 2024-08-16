﻿using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class FinancialAsset
{
    public int Id { get; set; }

    public string Ticker { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int AssetTypeId { get; set; }

    public decimal UnitPrice { get; set; }

    public virtual AssetType AssetType { get; set; } = null!;
}
