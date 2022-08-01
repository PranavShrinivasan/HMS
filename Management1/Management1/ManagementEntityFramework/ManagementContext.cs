using Management1.Models;
using Microsoft.EntityFrameworkCore;

namespace Management1.ManagementEntityFramework
{
    public class ManagementContext:DbContext
    {
        public ManagementContext(DbContextOptions<ManagementContext>options):base(options)
        {

        }

        public DbSet<ScheduleAppoinment> _scheduleAppt { get; set; }
        public DbSet<ViewPatient> _viewpt { get; set; }
        public DbSet<ResponseReport> _Resporpt { get; set; }
    }
}
