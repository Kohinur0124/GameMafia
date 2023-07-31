using GameMafia.Core.Enum;
using GameMafia.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Data
{
    public class MafiaGameDb : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5432; User Id=postgres; Password=0124; Database=MafiaDb");
            base.OnConfiguring(optionsBuilder);
        }
        
        public DbSet<Role> Roles { get; set; }
        
        public DbSet<CountRole> CountRole { get; set; }
        
        public DbSet<User>  Users { get; set; }
        
        public DbSet<Player> Player { get; set; }
        
        public DbSet<Market> Markets { get; set; }
        
        public DbSet<Models.Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region SeedData Role

            modelBuilder.Entity<Role>().HasData(new List<Role>()
            {
                new Role()
                {
                    RoleId = 1,
                    Name = "Tinch aholi",
                    Description = "kechasi uxlaydi va kunduzi yovuz " +
                    "qahramonlarni aniqlashga va ularni yo`q qilishga " +
                    "harakat qiladi (ovoz berish o`tkaziladi)",
                    Type = RoleType.White,
                },
                new Role()
                {
                    RoleId = 2,
                    Name = "Shifokor",
                    Description = "favqulodda ishchi. Kechasi u o`yinchilardan biriga kelib, " +
                    "hayotini saqlab qolishi mumkin. Har bir o'yinda bir marta o'zini qutqara oladi",
                    Type = RoleType.White,
                },
                new Role()
                {
                    RoleId = 3,
                    Name = "Don",
                    Description = "mafiya rahbari. Kechasi butun mafiya oilasi bilan birgalikda " +
                    "u jabrlanuvchini tanlaydi va hukmni ijro etadi",
                    Type = RoleType.Black,
                },
                new Role()
                {
                    RoleId = 4,
                    Name = "Kommisar",
                    Description = "tartib qo'riqchisi. Kechasi u o'yinchilardan birining rolini " +
                    "bilishi yoki uni o'ldirishi mumkin.",
                    Type = RoleType.White,
                },
                new Role()
                {
                    RoleId = 5,
                    Name = "Mafia",
                    Description = "mafiya oilasi a'zosi. Kechasi oilasi bilan birga qurbonni tanlaydi. " +
                    "Agar eskisi o'ldirilgan bo'lsa, yangi Don bo'lishi mumkin",
                    Type = RoleType.Black,
                },
                new Role()
                {
                    RoleId = 6,
                    Name = "Suisid",
                    Description = "faqat kunduzgi o'lim ovozini yutib, g'alaba qozonadigan neytral " +
                    "rol (ha, siz kunduzi o'lishingiz kerak)",
                    Type = RoleType.Gray,
                }


            }); ;

            #endregion SeedData Role


            #region SeedData CountRole

            modelBuilder.Entity<CountRole>().HasData(new List<CountRole>
            {
                new CountRole()
                {
                    CountRoleId = 1,
                    CountPlayer = 4,
                    RoleId = 1,
                    CountRoles = 2,

                },
                new CountRole()
                {
                    CountRoleId = 2,
                    CountPlayer = 4,
                    RoleId = 2,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 3,
                    CountPlayer = 4,
                    RoleId = 3,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 4,
                    CountPlayer = 5,
                    RoleId = 1,
                    CountRoles = 3,

                },
                new CountRole()
                {
                    CountRoleId = 5,
                    CountPlayer = 5,
                    RoleId = 2,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 6,
                    CountPlayer = 5,
                    RoleId = 3,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 7,
                    CountPlayer = 6,
                    RoleId = 1,
                    CountRoles = 3,

                },
                new CountRole()
                {
                    CountRoleId = 8,
                    CountPlayer = 6,
                    RoleId = 2,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 9,
                    CountPlayer = 6,
                    RoleId = 3,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 10,
                    CountPlayer = 6,
                    RoleId = 4,
                    CountRoles = 1,
                },
               new CountRole()
                {
                    CountRoleId = 11,
                    CountPlayer = 7,
                    RoleId = 1,
                    CountRoles = 4,

                },
                new CountRole()
                {
                    CountRoleId = 12,
                    CountPlayer = 7,
                    RoleId = 2,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 13,
                    CountPlayer = 7,
                    RoleId = 3,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 14,
                    CountPlayer = 7,
                    RoleId = 4,
                    CountRoles = 1,
                },

               new CountRole()
                {
                    CountRoleId = 15,
                    CountPlayer = 8,
                    RoleId = 1,
                    CountRoles = 4,

                },
                new CountRole()
                {
                    CountRoleId = 16,
                    CountPlayer = 8,
                    RoleId = 2,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 17,
                    CountPlayer = 8,
                    RoleId = 3,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 18,
                    CountPlayer = 8,
                    RoleId = 4,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 19,
                    CountPlayer = 8,
                    RoleId = 5,
                    CountRoles = 1,
                },
               new CountRole()
                {
                    CountRoleId = 20,
                    CountPlayer = 9,
                    RoleId = 1,
                    CountRoles = 4,

                },
                new CountRole()
                {
                    CountRoleId = 21,
                    CountPlayer = 9,
                    RoleId = 2,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 22,
                    CountPlayer = 9,
                    RoleId = 3,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 23,
                    CountPlayer = 9,
                    RoleId = 4,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 24,
                    CountPlayer = 9,
                    RoleId = 5,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 25,
                    CountPlayer = 9,
                    RoleId = 6,
                    CountRoles = 1,

                },
               new CountRole()
                {
                    CountRoleId = 26,
                    CountPlayer = 10,
                    RoleId = 1,
                    CountRoles = 4,

                },
                new CountRole()
                {
                    CountRoleId = 27,
                    CountPlayer = 10,
                    RoleId = 2,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 28,
                    CountPlayer = 10,
                    RoleId = 3,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 29,
                    CountPlayer = 10,
                    RoleId = 4,
                    CountRoles = 1,
                },
                new CountRole()
                {
                    CountRoleId = 30,
                    CountPlayer = 10,
                    RoleId = 5,
                    CountRoles = 2,
                },
                new CountRole()
                {
                    CountRoleId = 31,
                    CountPlayer = 10,
                    RoleId = 6,
                    CountRoles = 1,

                },
            });

            #endregion SeedData CountRole


            #region SeedData Market
            modelBuilder.Entity<Market>().HasData(new List<Market>
            {
                new Market()
                {
                    MarketId = 1,
                    Name = "Himoya" , 
                    Price = 100,
                },
            });

            #endregion SeedData Market




            base.OnModelCreating(modelBuilder);
        }
    }
}
