using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ejemplo1.Models;

public partial class DbTestContext : DbContext
{
    public DbTestContext()
    {
    }

    public DbTestContext(DbContextOptions<DbTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5435;Database=db_test;User Id=postgres;Password=Passw0rd1234;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.BlogId).HasName("blog_pkey");

            entity.ToTable("blog");

            entity.Property(e => e.BlogId).HasColumnName("blog_id");
            entity.Property(e => e.CreationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Title)
                .HasMaxLength(75)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("post_pkey");

            entity.ToTable("post");

            entity.Property(e => e.PostId).HasColumnName("post_id");
            entity.Property(e => e.Author)
                .HasMaxLength(100)
                .HasColumnName("author");
            entity.Property(e => e.BlogId).HasColumnName("blog_id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_date");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");

            entity.HasOne(d => d.Blog).WithMany(p => p.Posts)
                .HasForeignKey(d => d.BlogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_blog_post_blog_id");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("user_pkey");

            entity.ToTable("user");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.CreationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_date");
            entity.Property(e => e.Hash).HasColumnName("hash");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .HasColumnName("last_name");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_date");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
