using MediatR;

namespace Unik_OnBoarding.Application.Features.Stamdata.Projekt.Notifications;

public class NotifyKunde : INotification
{
    public string Message { get; set; }
}