﻿using Blockcore.Controllers.Models;

namespace Blockcore.Features.BlockStore.Models
{
    public class LastBalanceDecreaseTransactionModel
    {
        public TransactionVerboseModel Transaction { get; set; }

        public int BlockHeight { get; set; }
    }
}
