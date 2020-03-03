using System;
using Microsoft.EntityFrameworkCore;

namespace Ciandt.Hiring.SampleApi
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options)
        :base(options)
        { }

        public DbSet<Musica> Musicas { get; set; }
    }

    public class Musica
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }
    }
}