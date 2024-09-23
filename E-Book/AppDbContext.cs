
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


using Microsoft.EntityFrameworkCore;

namespace E_Book_DataAccess.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext( DbContextOptions<AppDbContext> options):base(options)
        {

        }
       
    }
}
