﻿using System;
using System.Collections.Generic;

namespace EntityFramworkLab1.Models;

public partial class DailyTransaction
{
    public int? UserId { get; set; }

    public int? TransactionAmount { get; set; }
}
