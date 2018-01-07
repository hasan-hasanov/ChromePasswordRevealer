using ChromePasswordRevealer.Data.Extensions;
using ChromePasswordRevealer.Data.Repoistories.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ChromePasswordRevealer
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
               .RegisterTypes()
               .BuildServiceProvider();

            IUserDataRepository repository = serviceProvider.GetService<IUserDataRepository>();
            var a = repository.GetAllUserData();
        }
    }
}
