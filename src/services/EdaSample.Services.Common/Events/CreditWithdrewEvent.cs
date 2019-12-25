﻿using EdaSample.Common.Events;
using EdaSample.Common.Sagas;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdaSample.Services.Common.Events
{
    public class CreditWithdrewEvent : SagaReplyEvent
    {
        public CreditWithdrewEvent(Guid sagaId, Guid customerId)
            : base(sagaId)
        {
            CustomerId = customerId;
        }

        public Guid CustomerId { get; }
    }
}