using ChromePasswordRevealer.Data.Connection_String;
using ChromePasswordRevealer.Data.Connection_String.Abstract;
using ChromePasswordRevealer.Data.DataContext;
using ChromePasswordRevealer.Data.DataContext.Abstract;
using ChromePasswordRevealer.Data.Encryption;
using ChromePasswordRevealer.Data.Encryption.Abstract;
using ChromePasswordRevealer.Data.Repoistories;
using ChromePasswordRevealer.Data.Repoistories.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromePasswordRevealer.Data.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static ServiceCollection RegisterTypes(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IContext, Context>();
            serviceCollection.AddScoped<IConnectionString, ConnectionString>();
            serviceCollection.AddScoped<IUserDataRepository, UserDataRepository>();
            serviceCollection.AddScoped<IEncryption, DPAPIFacade>();

            return serviceCollection;
        }
    }
}
