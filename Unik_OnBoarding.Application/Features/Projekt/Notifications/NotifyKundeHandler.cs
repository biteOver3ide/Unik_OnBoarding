using MediatR;

namespace Unik_OnBoarding.Application.Features.Projekt.Notifications;

public class NotifyKundeHandler : INotificationHandler<NotifyKunde>
{
    public Task Handle(NotifyKunde notification, CancellationToken cancellationToken)
    {
        // TODO Message server 
        Console.WriteLine("Meddelse er send");
        return Task.CompletedTask;
    }
}