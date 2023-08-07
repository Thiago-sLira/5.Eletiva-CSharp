using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sqlserver.Models;

public partial class HelloSqlServerContext : DbContext
{
    public HelloSqlServerContext()
    {
    }

    public HelloSqlServerContext(DbContextOptions<HelloSqlServerContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=hello_sql_server;User=sa;Password=Str#ng_Passw#rd;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
