﻿using Listening.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listening.Domain.Event
{
    public record EpisodeUpdatedEvent(Episode Value) : INotification;
}