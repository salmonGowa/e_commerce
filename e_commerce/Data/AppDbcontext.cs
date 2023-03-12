using Microsoft.EntityFrameworkCore;

namespace e_commerce.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options): base(options)
        {

        }

    }
}
 