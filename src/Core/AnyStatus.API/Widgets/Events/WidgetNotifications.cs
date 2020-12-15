﻿using MediatR;
using System.Threading.Tasks;

namespace AnyStatus.API.Widgets.Events
{
    public static class WidgetNotifications
    {
        public static IMediator Mediator { get; set; }

        public static Task PublishAsync(INotification notification) => Mediator?.Publish(notification);
    }
}
