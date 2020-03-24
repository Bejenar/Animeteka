using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace Animeteka
{
    public partial class AnimetekaContext : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public AnimetekaContext()
        {
        }

        public AnimetekaContext(DbContextOptions<AnimetekaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anime> Anime { get; set; }
        public virtual DbSet<AnimeAndGenre> AnimeAndGenre { get; set; }
        public virtual DbSet<AnimeAudit> AnimeAudit { get; set; }
        public virtual DbSet<AnimeCharacterView> AnimeCharacterView { get; set; }
        public virtual DbSet<AnimeGenreView> AnimeGenreView { get; set; }
        public virtual DbSet<AnimePersonView> AnimePersonView { get; set; }
        public virtual DbSet<AnimeType> AnimeType { get; set; }
        public virtual DbSet<AnimeView> AnimeView { get; set; }
        public virtual DbSet<CharacterAnime> CharacterAnime { get; set; }
        public virtual DbSet<Characters> Characters { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Studio> Studio { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder
                    .UseLoggerFactory(MyLoggerFactory)
                    .UseSqlServer("Data Source=DESKTOP-RACB3J8\\SQLEXPRESS;Initial Catalog=Animeteka;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anime>(entity =>
            {
                entity.HasIndex(e => e.AnimeName)
                    .HasName("UQ__Anime__CAA2805F54BC50BE")
                    .IsUnique();

                entity.HasIndex(e => e.StudioId)
                    .HasName("IDX_STUDIO_ID");

                entity.Property(e => e.AnimeId).HasColumnName("anime_id");

                entity.Property(e => e.AirDate)
                    .HasColumnName("air_date")
                    .HasColumnType("date");

                entity.Property(e => e.AnimeName)
                    .IsRequired()
                    .HasColumnName("anime_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnimeNameEn)
                    .HasColumnName("anime_name_en")
                    .HasMaxLength(255);

                entity.Property(e => e.AtypeId).HasColumnName("atype_id");

                entity.Property(e => e.EpAired).HasColumnName("ep_aired");

                entity.Property(e => e.EpCount).HasColumnName("ep_count");

                entity.Property(e => e.EpDuration).HasColumnName("ep_duration");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("date");

                entity.Property(e => e.StudioId).HasColumnName("studio_id");

                entity.HasOne(d => d.Atype)
                    .WithMany(p => p.Anime)
                    .HasForeignKey(d => d.AtypeId)
                    .HasConstraintName("FK_Anime_to_Types");

                entity.HasOne(d => d.Studio)
                    .WithMany(p => p.Anime)
                    .HasForeignKey(d => d.StudioId)
                    .HasConstraintName("FK_Anime_to_Studio");
            });

            modelBuilder.Entity<AnimeAndGenre>(entity =>
            {
                entity.HasKey(e => new {e.AnimeId, e.GenreId });

                entity.ToTable("Anime_and_Genre");

                entity.Property(e => e.AnimeId).HasColumnName("anime_id");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.HasOne(d => d.Anime)
                    .WithMany(p => p.AnimeAndGenre)
                    .HasForeignKey(d => d.AnimeId)
                    .HasConstraintName("FK__Anime_and__anime__20C1E124");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.AnimeAndGenre)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK__Anime_and__genre__21B6055D");
            });

            modelBuilder.Entity<AnimeAudit>(entity =>
            {
                entity.HasKey(e => new { e.ColumnName, e.EventDate, e.EventTypeId, e.Id, e.NewValue, e.OriginalValue, e.RecordId, e.TableName });

                entity.ToTable("Anime_audit");

                entity.Property(e => e.ColumnName).HasMaxLength(50);

                entity.Property(e => e.EventDate).HasColumnType("datetimeoffset(0)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnimeCharacterView>(entity =>
            {
                entity.HasKey(e=> new {e.AnimeId, e.CharacterName, e.IsMain, e.PersonName});

                entity.ToView("Anime_Character_View");

                entity.Property(e => e.AnimeId).HasColumnName("anime_id");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasColumnName("character_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsMain).HasColumnName("is_main");

                entity.Property(e => e.PersonName)
                    .HasColumnName("person_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnimeGenreView>(entity =>
            {
                entity.HasKey(e => new {e.AnimeId, e.GenreName });

                entity.ToView("Anime_Genre_View");

                entity.Property(e => e.AnimeId).HasColumnName("anime_id");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasColumnName("genre_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnimePersonView>(entity =>
            {
                entity.HasKey(e => new {e.AnimeId, e.PersonName, e.RoleName});

                entity.ToView("Anime_Person_View");

                entity.Property(e => e.AnimeId).HasColumnName("anime_id");

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasColumnName("person_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnimeType>(entity =>
            {
                entity.HasKey(e => e.AtypeId)
                    .HasName("PK__AnimeTyp__1434F37E6A66F953");

                entity.HasIndex(e => e.AtypeName)
                    .HasName("UQ__AnimeTyp__09C78937C0DFBB92")
                    .IsUnique();

                entity.Property(e => e.AtypeId)
                    .HasColumnName("atype_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AtypeName)
                    .IsRequired()
                    .HasColumnName("atype_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnimeView>(entity =>
            {
                entity.HasKey(e => new { e.AirDate, e.AnimeId, e.AnimeName, e.AtypeName, e.EpAired, e.EpCount, e.EpDuration, e.ReleaseDate, e.StudioName });

                entity.ToView("Anime_View");

                entity.Property(e => e.AirDate)
                    .HasColumnName("air_date")
                    .HasColumnType("date");

                entity.Property(e => e.AnimeId).HasColumnName("anime_id");

                entity.Property(e => e.AnimeName)
                    .IsRequired()
                    .HasColumnName("anime_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AtypeName)
                    .IsRequired()
                    .HasColumnName("atype_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EpAired).HasColumnName("ep_aired");

                entity.Property(e => e.EpCount).HasColumnName("ep_count");

                entity.Property(e => e.EpDuration).HasColumnName("ep_duration");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("date");

                entity.Property(e => e.StudioName)
                    .IsRequired()
                    .HasColumnName("studio_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CharacterAnime>(entity =>
            {
                entity.HasKey(e => e.CharAnimeId)
                    .HasName("PK__Characte__3E85070C80553D39");

                entity.ToTable("Character_Anime");

                entity.Property(e => e.CharAnimeId).HasColumnName("char_anime_id");

                entity.Property(e => e.AnimeId).HasColumnName("anime_id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.IsMain).HasColumnName("is_main");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.HasOne(d => d.Anime)
                    .WithMany(p => p.CharacterAnime)
                    .HasForeignKey(d => d.AnimeId)
                    .HasConstraintName("FK__Character__anime__2B3F6F97");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.CharacterAnime)
                    .HasForeignKey(d => d.CharacterId)
                    .HasConstraintName("FK__Character__chara__2C3393D0");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CharacterAnime)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Character__perso__3B75D760");
            });

            modelBuilder.Entity<Characters>(entity =>
            {
                entity.HasKey(e => e.CharacterId)
                    .HasName("PK__Characte__11D7652ECE89847B");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasColumnName("character_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CharacterNameEn)
                    .HasColumnName("character_name_en")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => new { e.AppUserId, e.ColumnName, e.EventDate, e.EventTypeId, e.Id, e.NewValue, e.OriginalValue, e.RecordId, e.TableName, e.TenantId});

                entity.Property(e => e.ColumnName).HasMaxLength(50);

                entity.Property(e => e.EventDate).HasColumnType("datetimeoffset(0)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasIndex(e => e.GenreName)
                    .HasName("UQ__Genre__1E98D15152A7D51C")
                    .IsUnique();

                entity.Property(e => e.GenreId)
                    .HasColumnName("genre_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasColumnName("genre_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.DateB)
                    .HasColumnName("dateB")
                    .HasColumnType("date");

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasColumnName("person_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PersonNameEn)
                    .HasColumnName("person_name_en")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => new { e.AnimeId, e.PersonId, e.RoleId });

                entity.Property(e => e.AnimeId).HasColumnName("anime_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Anime)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.AnimeId)
                    .HasConstraintName("FK__Personal__anime___276EDEB3");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Personal__person__267ABA7A");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Personal__role_i__286302EC");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Roles__760965CCC25AFB8D");

                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ__Roles__783254B1D1E80E52")
                    .IsUnique();

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Studio>(entity =>
            {
                entity.HasIndex(e => e.StudioName)
                    .HasName("UQ__Studio__ABA8EFE45BAE9B8F")
                    .IsUnique();

                entity.Property(e => e.StudioId).HasColumnName("studio_id");

                entity.Property(e => e.StudioName)
                    .IsRequired()
                    .HasColumnName("studio_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Login)
                    .HasName("UQ__User__5E55825B8B698C5B")
                    .IsUnique();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(u => new { u.UserId, u.Role});

                entity.ToTable("User_Roles");

                entity.HasIndex(e => e.UserId)
                    .HasName("UQ__User_Rol__206D917124AAA715")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserRoles)
                    .HasForeignKey<UserRoles>(d => d.UserId)
                    .HasConstraintName("FK__User_Role__User___1CBC4616");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
