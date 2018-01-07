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
            var userData = repository.GetAllUserData();

            foreach (var data in userData)
            {
                Console.WriteLine($"Username: {data.UserName}");
                Console.WriteLine($"URL: {data.URL}");
                Console.WriteLine($"Password: {data.Password}");

                Console.WriteLine();
            }
        }
    }
}
