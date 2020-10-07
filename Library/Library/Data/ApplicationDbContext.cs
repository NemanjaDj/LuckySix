using System;
using System.Collections.Generic;
using System.Text;
using Library.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\LocalDB1;Initial Catalog=Library;Integrated Security=True");
            }
        }

        internal DbSet <Book> Books { get; set; }
        internal DbSet<BookRent> BookRents { get; set; }
        internal DbSet<Genre> Genres { get; set; }
        internal DbSet<NumberOfBooks> NumberOfBooks { get; set; }
        internal DbSet<Rating> Ratings { get; set; }
        internal DbSet<ApplicationUser> AppUsers { get; set; }
        internal DbSet<Writer> Writers { get; set; }
        internal DbSet<BookGenre> BookGenre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookGenre>()
        .HasKey(c => new { c.BookId, c.GenreId });

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{


        //    modelBuilder.Entity<BookRent>(entity =>
        //    {
        //        entity.HasKey(br => br.RentId);
        //        entity.Property(br => br.RentId).ValueGeneratedOnAdd();
        //    });


        //    modelBuilder.Entity<Genre>(entity =>
        //    {
        //        entity.HasKey(g => g.GenreId);
        //        entity.Property(g => g.GenreId).ValueGeneratedOnAdd();
        //        entity.Property(g => g.GenreName).IsRequired().HasMaxLength(30);
        //    });


        //    modelBuilder.Entity<NumberOfBooks>(entity =>
        //    {
        //        entity.HasKey(nb => nb.NumberOfBooksId);
        //        entity.Property(nb => nb.NumberOfBooksId).ValueGeneratedOnAdd();
        //    });


        //    modelBuilder.Entity<Rating>(entity =>
        //    {
        //        entity.HasKey(r => r.RatingId);
        //        entity.Property(r => r.RatingId).ValueGeneratedOnAdd();
        //    });

        //    modelBuilder.Entity<Writer>(entity =>
        //    {
        //        entity.HasKey(w => w.WriterId);
        //        entity.Property(w => w.WriterId).ValueGeneratedOnAdd();
        //        entity.Property(w => w.WriterName).IsRequired();
        //        entity.HasMany(w => w.Books)
        //        .WithOne(b => b.Writer);
        //    });

        //    modelBuilder.Entity<Book>(entity =>
        //    {
        //        entity.HasKey(b => b.BookId);
        //        entity.Property(b => b.BookId).ValueGeneratedOnAdd();
        //        entity.Property(b => b.BookName).IsRequired().HasMaxLength(80);
        //        entity.HasOne(b => b.Writer)
        //        .WithMany(w => w.Books);
        //        entity.HasOne(b => b.NumberOfBooks)
        //        .WithOne(nb => nb.Book)
        //        .HasForeignKey<NumberOfBooks>(nb => nb.BookId);
        //    });

        //    base.OnModelCreating(modelBuilder);

        //    //Book and Genre manyToMany
        //    modelBuilder.Entity<BookGenre>()
        //    .HasKey(bg => new { bg.BookId, bg.GenreId });

        //    modelBuilder.Entity<BookGenre>()
        //        .HasOne(bg => bg.Book)
        //        .WithMany(b => b.BookGenres)
        //        .HasForeignKey(bg => bg.BookId);

        //    modelBuilder.Entity<BookGenre>()
        //        .HasOne(bg => bg.Genre)
        //        .WithMany(g => g.BookGenres)
        //        .HasForeignKey(bg => bg.GenreId);

        //    //Book and User (BookRent) manyToMany
        //    modelBuilder.Entity<BookRent>()
        //        .HasOne(br => br.Book)
        //        .WithMany(b => b.BookRents)
        //        .HasForeignKey(br => br.BookId);

        //    //Book and User (Rating) manyToMany
        //    modelBuilder.Entity<Rating>()
        //        .HasOne(r => r.Book)
        //        .WithMany(b => b.Ratings)
        //        .HasForeignKey(r => r.BookId);

        //}
    }
}
