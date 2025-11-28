using MassTransit;
using OrderFlowClase.Shared.Events;

internal class UserRegisteredConsumer : IConsumer<UserCreatedEvent>
{

    private ILogger<UserRegisteredConsumer> _logger;

    public UserRegisteredConsumer(ILogger<UserRegisteredConsumer> logger)
    {
        _logger = logger;
    }

    public Task Consume(ConsumeContext<UserCreatedEvent> context)
    {

        var user = context.Message;

        _logger.LogInformation("New user registered: {UserId}, Email: {Email}", user.userId, user.email);

        return Task.CompletedTask;
    }
}