using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using Npgsql.PostgresTypes;
using TodoApi.Data;

namespace TodoApi.Data
{
    public class TotoContextFactory : IDesignTimeDbContextFactory<TodoContext>
    {
        public TodoContext CreateDbContext(String[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<TodoContext>();
            optionBuilder.UseNpgsql("Host = localhost; Port5432; Database=TodoDb; Username = postgres; Password = yourpassword");
            return new TodoContext(optionBuilder.Options);
        }
    }
}

