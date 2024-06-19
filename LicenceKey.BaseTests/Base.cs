using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace LicenceKey.BaseTests;

public class Base
{
    public readonly HttpClient AnnonymousClient;
    public readonly IMapper Mapper;
    private readonly IMediator Mediator;


    public Base()
    {
        var factory = new CustomWebApplicationFactory<Program>();
        var scope = factory.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();

        AnnonymousClient = factory.CreateClient();
        Mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
        Mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

    }
}