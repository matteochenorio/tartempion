using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace tartempion.Models;

public partial class TartempionContext : DbContext
{
    public TartempionContext()
    {
    }

    public TartempionContext(DbContextOptions<TartempionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Etat> Etats { get; set; }

    public virtual DbSet<Famille> Familles { get; set; }

    public virtual DbSet<Fichefrai> Fichefrais { get; set; }

    public virtual DbSet<FraisForfait> FraisForfaits { get; set; }

    public virtual DbSet<HistoriqueFrai> HistoriqueFrais { get; set; }

    public virtual DbSet<Laboratoire> Laboratoires { get; set; }

    public virtual DbSet<LigneFraisForfait> LigneFraisForfaits { get; set; }

    public virtual DbSet<LigneFraisHorsForfait> LigneFraisHorsForfaits { get; set; }

    public virtual DbSet<Medecin> Medecins { get; set; }

    public virtual DbSet<Medicament> Medicaments { get; set; }

    public virtual DbSet<Motif> Motifs { get; set; }

    public virtual DbSet<Offrir> Offrirs { get; set; }

    public virtual DbSet<Rapport> Rapports { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Remplacant> Remplacants { get; set; }

    public virtual DbSet<Secteur> Secteurs { get; set; }

    public virtual DbSet<Specialite> Specialites { get; set; }

    public virtual DbSet<TypeFraisForfait> TypeFraisForfaits { get; set; }

    public virtual DbSet<Visiteur> Visiteurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=SRV-SGBD\\SQLSERVERGLOBAL;Initial Catalog=tartempion;User ID=tartempion;Password=usersio;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Etat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Etat__3213E83F18DAABA0");

            entity.ToTable("Etat");

            entity.Property(e => e.Id)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Libelle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("libelle");
        });

        modelBuilder.Entity<Famille>(entity =>
        {
            entity.HasKey(e => e.IdFamille).HasName("PK__FAMILLE__CC8A4978AB6D671E");

            entity.ToTable("FAMILLE");

            entity.Property(e => e.IdFamille)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idFamille");
            entity.Property(e => e.LibFamille)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("libFamille");
        });

        modelBuilder.Entity<Fichefrai>(entity =>
        {
            entity.HasKey(e => new { e.IdVisiteur, e.Mois }).HasName("PK__fichefra__EDD484AE63409DE2");

            entity.ToTable("fichefrais");

            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.Mois)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mois");
            entity.Property(e => e.DateModif)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("dateModif");
            entity.Property(e => e.IdEtat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("CR")
                .IsFixedLength()
                .HasColumnName("idEtat");
            entity.Property(e => e.MontantValide)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("montantValide");
            entity.Property(e => e.NbJustificatifs)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("nbJustificatifs");

            entity.HasOne(d => d.IdEtatNavigation).WithMany(p => p.Fichefrais)
                .HasForeignKey(d => d.IdEtat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__fichefrai__idEta__534D60F1");

            entity.HasOne(d => d.IdVisiteurNavigation).WithMany(p => p.Fichefrais)
                .HasForeignKey(d => d.IdVisiteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__fichefrai__idVis__5441852A");
        });

        modelBuilder.Entity<FraisForfait>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FraisFor__3213E83F0EA91BE9");

            entity.ToTable("FraisForfait");

            entity.Property(e => e.Id)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.IdHistoriqueFrais).HasColumnName("idHistoriqueFrais");
            entity.Property(e => e.IdTypeFraisForfait).HasColumnName("idTypeFraisForfait");
            entity.Property(e => e.Libelle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("libelle");
            entity.Property(e => e.Mensuel).HasColumnName("mensuel");

            entity.HasOne(d => d.IdHistoriqueFraisNavigation).WithMany(p => p.FraisForfaits)
                .HasForeignKey(d => d.IdHistoriqueFrais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_FraisForfait_historiqueFrais");

            entity.HasOne(d => d.IdTypeFraisForfaitNavigation).WithMany(p => p.FraisForfaits)
                .HasForeignKey(d => d.IdTypeFraisForfait)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_FraisForfait_typeFraisForfait");
        });

        modelBuilder.Entity<HistoriqueFrai>(entity =>
        {
            entity.HasKey(e => e.IdHistoriqueFrais).HasName("PK__historiq__CAFDD9E11C86CF3F");

            entity.ToTable("historiqueFrais");

            entity.Property(e => e.IdHistoriqueFrais)
                .ValueGeneratedNever()
                .HasColumnName("idHistoriqueFrais");
            entity.Property(e => e.DateDebut).HasColumnName("dateDebut");
            entity.Property(e => e.DateFin).HasColumnName("dateFin");
            entity.Property(e => e.Montant).HasColumnName("montant");
        });

        modelBuilder.Entity<Laboratoire>(entity =>
        {
            entity.HasKey(e => e.IdLabo);

            entity.ToTable("Laboratoire");

            entity.Property(e => e.IdLabo).HasColumnName("idLabo");
            entity.Property(e => e.NomLabo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nomLabo");
        });

        modelBuilder.Entity<LigneFraisForfait>(entity =>
        {
            entity.HasKey(e => new { e.IdVisiteur, e.Mois, e.IdFraisForfait }).HasName("PK__LigneFra__9BB2656B801200C8");

            entity.ToTable("LigneFraisForfait");

            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.Mois)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mois");
            entity.Property(e => e.IdFraisForfait)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idFraisForfait");
            entity.Property(e => e.Quantite)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("quantite");

            entity.HasOne(d => d.IdFraisForfaitNavigation).WithMany(p => p.LigneFraisForfaits)
                .HasForeignKey(d => d.IdFraisForfait)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LigneFrai__idFra__59063A47");

            entity.HasOne(d => d.Fichefrai).WithMany(p => p.LigneFraisForfaits)
                .HasForeignKey(d => new { d.IdVisiteur, d.Mois })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LigneFraisForfai__5812160E");
        });

        modelBuilder.Entity<LigneFraisHorsForfait>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LigneFra__3213E83F6C4D6FF0");

            entity.ToTable("LigneFraisHorsForfait");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("date");
            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.Libelle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("libelle");
            entity.Property(e => e.Mois)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mois");
            entity.Property(e => e.Montant)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("montant");

            entity.HasOne(d => d.Fichefrai).WithMany(p => p.LigneFraisHorsForfaits)
                .HasForeignKey(d => new { d.IdVisiteur, d.Mois })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LigneFraisHorsFo__5EBF139D");
        });

        modelBuilder.Entity<Medecin>(entity =>
        {
            entity.HasKey(e => e.IdMedecin).HasName("PK__MEDECIN__180DFB72A467BB3F");

            entity.ToTable("MEDECIN");

            entity.Property(e => e.IdMedecin).HasColumnName("idMedecin");
            entity.Property(e => e.Adresse)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("adresse");
            entity.Property(e => e.Departement).HasColumnName("departement");
            entity.Property(e => e.IdSpecialite)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idSpecialite");
            entity.Property(e => e.Nom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("prenom");
            entity.Property(e => e.Tel)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tel");

            entity.HasOne(d => d.IdSpecialiteNavigation).WithMany(p => p.Medecins)
                .HasForeignKey(d => d.IdSpecialite)
                .HasConstraintName("medecin_fk");
        });

        modelBuilder.Entity<Medicament>(entity =>
        {
            entity.HasKey(e => e.IdMedicament).HasName("PK__MEDICAME__1A80318975B0160A");

            entity.ToTable("MEDICAMENT");

            entity.Property(e => e.IdMedicament)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idMedicament");
            entity.Property(e => e.Composition)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("composition");
            entity.Property(e => e.ContreIndications)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("contreIndications");
            entity.Property(e => e.Effets)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("effets");
            entity.Property(e => e.IdFamille)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idFamille");
            entity.Property(e => e.NomCommercial)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("nomCommercial");

            entity.HasOne(d => d.IdFamilleNavigation).WithMany(p => p.Medicaments)
                .HasForeignKey(d => d.IdFamille)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("medicament_fk");
        });

        modelBuilder.Entity<Motif>(entity =>
        {
            entity.HasKey(e => e.IdMotif).HasName("PK__MOTIF__186EF2C3B827C930");

            entity.ToTable("MOTIF");

            entity.Property(e => e.IdMotif).HasColumnName("idMotif");
            entity.Property(e => e.LibMotif)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("libMotif");
        });

        modelBuilder.Entity<Offrir>(entity =>
        {
            entity.HasKey(e => new { e.IdRapport, e.IdMedicament }).HasName("PK__OFFRIR__8E6CD178F4FD9F77");

            entity.ToTable("OFFRIR");

            entity.Property(e => e.IdRapport).HasColumnName("idRapport");
            entity.Property(e => e.IdMedicament)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idMedicament");
            entity.Property(e => e.Quantite).HasColumnName("quantite");

            entity.HasOne(d => d.IdMedicamentNavigation).WithMany(p => p.Offrirs)
                .HasForeignKey(d => d.IdMedicament)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("offrir_fk2");

            entity.HasOne(d => d.IdRapportNavigation).WithMany(p => p.Offrirs)
                .HasForeignKey(d => d.IdRapport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("offrir_fk1");
        });

        modelBuilder.Entity<Rapport>(entity =>
        {
            entity.HasKey(e => e.IdRapport).HasName("PK__RAPPORT__0FC4D260BA2AAC86");

            entity.ToTable("RAPPORT");

            entity.Property(e => e.IdRapport).HasColumnName("idRapport");
            entity.Property(e => e.AvisMedecin)
                .HasDefaultValue(1)
                .HasColumnName("avisMedecin");
            entity.Property(e => e.Bilan)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("bilan");
            entity.Property(e => e.DateRapport).HasColumnName("dateRapport");
            entity.Property(e => e.DureeVisite).HasColumnName("dureeVisite");
            entity.Property(e => e.EstRemplacant).HasColumnName("estRemplacant");
            entity.Property(e => e.HeurePrevue).HasColumnName("heurePrevue");
            entity.Property(e => e.HeureReelle).HasColumnName("heureReelle");
            entity.Property(e => e.IdMedecin).HasColumnName("idMedecin");
            entity.Property(e => e.IdMedicament)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("3MYC7")
                .HasColumnName("idMedicament");
            entity.Property(e => e.IdMotif).HasColumnName("idMotif");
            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");

            entity.HasOne(d => d.IdMedecinNavigation).WithMany(p => p.Rapports)
                .HasForeignKey(d => d.IdMedecin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rapport_fk2");

            entity.HasOne(d => d.IdMotifNavigation).WithMany(p => p.Rapports)
                .HasForeignKey(d => d.IdMotif)
                .HasConstraintName("rapport_fk3");

            entity.HasOne(d => d.IdVisiteurNavigation).WithMany(p => p.Rapports)
                .HasForeignKey(d => d.IdVisiteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rapport_fk1");

            entity.HasMany(d => d.IdMedicaments).WithMany(p => p.IdRapports)
                .UsingEntity<Dictionary<string, object>>(
                    "Presentation",
                    r => r.HasOne<Medicament>().WithMany()
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__PRESENTAT__idMed__0F624AF8"),
                    l => l.HasOne<Rapport>().WithMany()
                        .HasForeignKey("IdRapport")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__PRESENTAT__idRap__0E6E26BF"),
                    j =>
                    {
                        j.HasKey("IdRapport", "IdMedicament").HasName("PK__PRESENTA__8E6CD178FA2E6021");
                        j.ToTable("PRESENTATION");
                        j.IndexerProperty<int>("IdRapport").HasColumnName("idRapport");
                        j.IndexerProperty<string>("IdMedicament")
                            .HasMaxLength(12)
                            .IsUnicode(false)
                            .IsFixedLength()
                            .HasColumnName("idMedicament");
                    });
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.IdRegion).HasName("PK_REGION");

            entity.ToTable("Region");

            entity.Property(e => e.IdRegion)
                .ValueGeneratedNever()
                .HasColumnName("idRegion");
            entity.Property(e => e.IdSecteur).HasColumnName("idSecteur");
            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.LibRegion)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("libRegion");

            entity.HasOne(d => d.IdSecteurNavigation).WithMany(p => p.Regions)
                .HasForeignKey(d => d.IdSecteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SECTEUR");

            entity.HasOne(d => d.IdVisiteurNavigation).WithMany(p => p.Regions)
                .HasForeignKey(d => d.IdVisiteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VISITEUR");
        });

        modelBuilder.Entity<Remplacant>(entity =>
        {
            entity.HasKey(e => e.IdRemplacant).HasName("PK_REMPLACANT");

            entity.ToTable("Remplacant");

            entity.Property(e => e.IdRemplacant).HasColumnName("idRemplacant");
            entity.Property(e => e.EstRemplacant).HasColumnName("estRemplacant");
            entity.Property(e => e.IdMedecin).HasColumnName("idMedecin");
            entity.Property(e => e.IdRapport)
                .HasDefaultValue(1)
                .HasColumnName("idRapport");

            entity.HasOne(d => d.IdMedecinNavigation).WithMany(p => p.Remplacants)
                .HasForeignKey(d => d.IdMedecin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REMPLACANT_MEDECIN");
        });

        modelBuilder.Entity<Secteur>(entity =>
        {
            entity.HasKey(e => e.IdSecteur).HasName("PK_SECTEUR");

            entity.ToTable("Secteur");

            entity.Property(e => e.IdSecteur)
                .ValueGeneratedNever()
                .HasColumnName("idSecteur");
            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.LibSecteur)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("libSecteur");

            entity.HasOne(d => d.IdVisiteurNavigation).WithMany(p => p.Secteurs)
                .HasForeignKey(d => d.IdVisiteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VISITEURSECTEUR");
        });

        modelBuilder.Entity<Specialite>(entity =>
        {
            entity.HasKey(e => e.IdSpecialite).HasName("PK__SPECIALI__1023B156947E42A3");

            entity.ToTable("SPECIALITE");

            entity.Property(e => e.IdSpecialite)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idSpecialite");
            entity.Property(e => e.LibSpecialite)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("libSpecialite");
        });

        modelBuilder.Entity<TypeFraisForfait>(entity =>
        {
            entity.HasKey(e => e.IdTypeFraisForfait).HasName("PK__typeFrai__948837038D3D467D");

            entity.ToTable("typeFraisForfait");

            entity.Property(e => e.IdTypeFraisForfait)
                .ValueGeneratedNever()
                .HasColumnName("idTypeFraisForfait");
            entity.Property(e => e.Libelle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("libelle");
        });

        modelBuilder.Entity<Visiteur>(entity =>
        {
            entity.HasKey(e => e.IdVisiteur).HasName("PK_VISITEUR");

            entity.ToTable("Visiteur");

            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.Cp)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cp");
            entity.Property(e => e.DateEmbauche)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dateEmbauche");
            entity.Property(e => e.IdLabo).HasColumnName("idLabo");
            entity.Property(e => e.Identifiant)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("identifiant");
            entity.Property(e => e.Nom)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Prenom)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("prenom");
            entity.Property(e => e.Rue)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("rue");
            entity.Property(e => e.Ville)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ville");

            entity.HasOne(d => d.IdLaboNavigation).WithMany(p => p.Visiteurs)
                .HasForeignKey(d => d.IdLabo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Laboratoire");

            entity.HasMany(d => d.IdRegions).WithMany(p => p.IdVisiteurs)
                .UsingEntity<Dictionary<string, object>>(
                    "Travailler",
                    r => r.HasOne<Region>().WithMany()
                        .HasForeignKey("IdRegion")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TRAVAILLER"),
                    l => l.HasOne<Visiteur>().WithMany()
                        .HasForeignKey("IdVisiteur")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_VISITEURTRAVAIL"),
                    j =>
                    {
                        j.HasKey("IdVisiteur", "IdRegion").HasName("PK_TRAVAILLER");
                        j.ToTable("Travailler");
                        j.IndexerProperty<string>("IdVisiteur")
                            .HasMaxLength(3)
                            .IsUnicode(false)
                            .IsFixedLength()
                            .HasColumnName("idVisiteur");
                        j.IndexerProperty<int>("IdRegion").HasColumnName("idRegion");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
