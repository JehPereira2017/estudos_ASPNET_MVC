using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CadastroCNPJ.Models
{
    public partial class FitcardTesteContext : DbContext
    {
        public FitcardTesteContext()
        {
        }

        public FitcardTesteContext(DbContextOptions<FitcardTesteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Estabelecimento> Estabelecimento { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.DescricaoCategoria).IsUnicode(false);
            });

            modelBuilder.Entity<Estabelecimento>(entity =>
            {
                entity.Property(e => e.Agencia).IsUnicode(false);

                entity.Property(e => e.Cnpj).IsUnicode(false);

                entity.Property(e => e.Conta).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Logradouro).IsUnicode(false);

                entity.Property(e => e.NomeFantasia).IsUnicode(false);

                entity.Property(e => e.Numero).IsUnicode(false);

                entity.Property(e => e.Razaosocial).IsUnicode(false);

                entity.Property(e => e.Telefone).IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Estabelecimento)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Estabelec__id_ca__15502E78");

                entity.HasOne(d => d.IdCidadeNavigation)
                    .WithMany(p => p.Estabelecimento)
                    .HasForeignKey(d => d.IdCidade)
                    .HasConstraintName("FK__Estabelec__id_ci__1273C1CD");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Estabelecimento)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK__Estabelec__id_es__1367E606");

                entity.HasOne(d => d.StatusEstabelecimentoNavigation)
                    .WithMany(p => p.Estabelecimento)
                    .HasForeignKey(d => d.StatusEstabelecimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Estabelec__statu__145C0A3F");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Municipio)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_EstadoMunicipio");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.DescricaoStatus).IsUnicode(false);
            });
        }
    }
}
