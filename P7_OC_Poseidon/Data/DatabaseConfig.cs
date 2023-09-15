using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Models;

namespace P7_OC_Poseidon.Data
{
    public static class DatabaseConfig
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            BidList.Configure(modelBuilder);
            CurvePoint.Configure(modelBuilder);
            Rating.Configure(modelBuilder);
            RuleName.Configure(modelBuilder);
            Trade.Configure(modelBuilder);
            User.Configure(modelBuilder);
        }
    }
}
