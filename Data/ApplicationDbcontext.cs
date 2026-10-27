using Microsoft.EntityFrameworkCore;
using SEJMS.Models;

namespace SEJMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }


    public DbSet<ProfileItem> ProfileItems { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Employer> Employers { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<SEJMS.Models.Activity> Activities { get; set; }

        public DbSet<Resume> Resumes { get; set; }

        public DbSet<Application> Applications { get; set; }

        public DbSet<Recommendation> Recommendations { get; set; }

        public DbSet<StudentSkill> StudentSkills { get; set; }

        public DbSet<StudentActivity> StudentActivities { get; set; }

        public DbSet<Interest> Interests { get; set; }

        public DbSet<StudentInterest> StudentInterests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property(x => x.IsActive).HasDefaultValue(true);

            modelBuilder.Entity<Interest>().HasData(
                new Interest
                {
                    InterestId = 1,
                    InterestName = "Software Development",
                    Description = "Interest in developing software applications and systems."
                },
                new Interest
                {
                    InterestId = 2,
                    InterestName = "Web Development",
                    Description = "Interest in creating and maintaining websites and web applications."
                },
                new Interest
                {
                    InterestId = 3,
                    InterestName = "Mobile App Development",
                    Description = "Interest in developing applications for mobile devices."
                },
                new Interest
                {
                    InterestId = 4,
                    InterestName = "Artificial Intelligence",
                    Description = "Interest in artificial intelligence and intelligent computer systems."
                },
                new Interest
                {
                    InterestId = 5,
                    InterestName = "Machine Learning",
                    Description = "Interest in machine learning and data-driven systems."
                },
                new Interest
                {
                    InterestId = 6,
                    InterestName = "Data Science",
                    Description = "Interest in analyzing data and discovering useful insights."
                },
                new Interest
                {
                    InterestId = 7,
                    InterestName = "Database Management",
                    Description = "Interest in database design, management and optimization."
                },
                new Interest
                {
                    InterestId = 8,
                    InterestName = "Cybersecurity",
                    Description = "Interest in protecting systems, networks and data from security threats."
                },
                new Interest
                {
                    InterestId = 9,
                    InterestName = "Networking",
                    Description = "Interest in computer networks and network infrastructure."
                },
                new Interest
                {
                    InterestId = 10,
                    InterestName = "Cloud Computing",
                    Description = "Interest in cloud platforms, services and infrastructure."
                },
                new Interest
                {
                    InterestId = 11,
                    InterestName = "UI/UX Design",
                    Description = "Interest in designing user interfaces and user experiences."
                },
                new Interest
                {
                    InterestId = 12,
                    InterestName = "Game Development",
                    Description = "Interest in designing and developing computer and mobile games."
                },
                new Interest
                {
                    InterestId = 13,
                    InterestName = "Programming",
                    Description = "Interest in programming and solving problems through code."
                },
                new Interest
                {
                    InterestId = 14,
                    InterestName = "Information Technology",
                    Description = "Interest in information technology and computer systems."
                },
                new Interest
                {
                    InterestId = 15,
                    InterestName = "System Analysis",
                    Description = "Interest in analyzing and improving information systems."
                },
                new Interest
                {
                    InterestId = 16,
                    InterestName = "Project Management",
                    Description = "Interest in planning and managing technology projects."
                },
                new Interest
                {
                    InterestId = 17,
                    InterestName = "Business Analysis",
                    Description = "Interest in analyzing business needs and system requirements."
                },
                new Interest
                {
                    InterestId = 18,
                    InterestName = "Digital Marketing",
                    Description = "Interest in online marketing and digital communication."
                },
                new Interest
                {
                    InterestId = 19,
                    InterestName = "Entrepreneurship",
                    Description = "Interest in starting and developing new businesses and ideas."
                },
                new Interest
                {
                    InterestId = 20,
                    InterestName = "Technology Innovation",
                    Description = "Interest in new technologies and innovative solutions."
                }
            );
        }
    }


}
