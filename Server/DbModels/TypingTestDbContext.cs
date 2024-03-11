using Microsoft.EntityFrameworkCore;
using ModelLibrary.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DbModels
{
    public class TypingTestDbContext : DbContext
    {
        public TypingTestDbContext(DbContextOptions options) : base(options) { }
        public TypingTestDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            // SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());

            var mydata = "D:\\Mein progectos\\ShiftType\\Server\\TypingDb.db";
           // var mydata2 = "D:\\йцуйцу\\Server\\net6.0\\TypingDb.db";
            builder.UseSqlite($"Data Source={mydata}");
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<TestResult> Results { get; set; }
    }
}
