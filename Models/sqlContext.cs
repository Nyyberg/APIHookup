using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiHookup.Models;

public partial class sqlContext : DbContext
{
    public sqlContext()
    {
    }

    public sqlContext(DbContextOptions<sqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adresse> Adresses { get; set; }

    public virtual DbSet<Body> Bodies { get; set; }

    public virtual DbSet<CustomCalendarBe> CustomCalendarBes { get; set; }

    public virtual DbSet<ElEffekforbrug> ElEffekforbrugs { get; set; }

    public virtual DbSet<ForespElTilslutning> ForespElTilslutnings { get; set; }

    public virtual DbSet<ForespMerkeplade> ForespMerkeplades { get; set; }

    public virtual DbSet<FspKalender> FspKalenders { get; set; }

    public virtual DbSet<FspLonData2019> FspLonData2019s { get; set; }

    public virtual DbSet<FspLonData2019Afd> FspLonData2019Afds { get; set; }

    public virtual DbSet<FspLonDatum> FspLonData { get; set; }

    public virtual DbSet<FspTidsReg> FspTidsRegs { get; set; }

    public virtual DbSet<Header> Headers { get; set; }

    public virtual DbSet<HookupBe> HookupBes { get; set; }

    public virtual DbSet<KapabilitetForsp> KapabilitetForsps { get; set; }

    public virtual DbSet<Kapabillitet> Kapabillitets { get; set; }

    public virtual DbSet<LinieNr> LinieNrs { get; set; }

    public virtual DbSet<LinienrForesp> LinienrForesps { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Maskinkartotekt> Maskinkartotekts { get; set; }

    public virtual DbSet<MærkepladeTabel> MærkepladeTabels { get; set; }

    public virtual DbSet<Postnr> Postnrs { get; set; }

    public virtual DbSet<QHentProjekter> QHentProjekters { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceIkkeUdført> ServiceIkkeUdførts { get; set; }

    public virtual DbSet<ServiceRepForespørgsel> ServiceRepForespørgsels { get; set; }

    public virtual DbSet<TblAfdelinger> TblAfdelingers { get; set; }

    public virtual DbSet<TblAftraek> TblAftraeks { get; set; }

    public virtual DbSet<TblAltReg> TblAltRegs { get; set; }

    public virtual DbSet<TblArbejdere> TblArbejderes { get; set; }

    public virtual DbSet<TblBelastning> TblBelastnings { get; set; }

    public virtual DbSet<TblBeskeder> TblBeskeders { get; set; }

    public virtual DbSet<TblChange> TblChanges { get; set; }

    public virtual DbSet<TblChargeNr> TblChargeNrs { get; set; }

    public virtual DbSet<TblDage> TblDages { get; set; }

    public virtual DbSet<TblDelRecord> TblDelRecords { get; set; }

    public virtual DbSet<TblDesignere> TblDesigneres { get; set; }

    public virtual DbSet<TblDoC> TblDoCs { get; set; }

    public virtual DbSet<TblDokuCert> TblDokuCerts { get; set; }

    public virtual DbSet<TblDokumentation> TblDokumentations { get; set; }

    public virtual DbSet<TblEmneTyper> TblEmneTypers { get; set; }

    public virtual DbSet<TblExOmkost> TblExOmkosts { get; set; }

    public virtual DbSet<TblFaktura> TblFakturas { get; set; }

    public virtual DbSet<TblFasteFradrag> TblFasteFradrags { get; set; }

    public virtual DbSet<TblFasteTillaeg> TblFasteTillaegs { get; set; }

    public virtual DbSet<TblFejlkoder> TblFejlkoders { get; set; }

    public virtual DbSet<TblFinish> TblFinishes { get; set; }

    public virtual DbSet<TblForbrug> TblForbrugs { get; set; }

    public virtual DbSet<TblFradrag> TblFradrags { get; set; }

    public virtual DbSet<TblFradragDatum> TblFradragData { get; set; }

    public virtual DbSet<TblFradragForespørgsel> TblFradragForespørgsels { get; set; }

    public virtual DbSet<TblFuskLinie> TblFuskLinies { get; set; }

    public virtual DbSet<TblIpo> TblIpos { get; set; }

    public virtual DbSet<TblJobliste> TblJoblistes { get; set; }

    public virtual DbSet<TblKalender> TblKalenders { get; set; }

    public virtual DbSet<TblKilde> TblKildes { get; set; }

    public virtual DbSet<TblKontaktLev> TblKontaktLevs { get; set; }

    public virtual DbSet<TblKontakter> TblKontakters { get; set; }

    public virtual DbSet<TblKundeDatum> TblKundeData { get; set; }

    public virtual DbSet<TblKunder> TblKunders { get; set; }

    public virtual DbSet<TblLager> TblLagers { get; set; }

    public virtual DbSet<TblLagerOpt> TblLagerOpts { get; set; }

    public virtual DbSet<TblLagerOptNy> TblLagerOptNies { get; set; }

    public virtual DbSet<TblLagerQuery> TblLagerQueries { get; set; }

    public virtual DbSet<TblLevFirma> TblLevFirmas { get; set; }

    public virtual DbSet<TblLevKontakt> TblLevKontakts { get; set; }

    public virtual DbSet<TblLonDatum> TblLonData { get; set; }

    public virtual DbSet<TblLonperiode> TblLonperiodes { get; set; }

    public virtual DbSet<TblMatDatum> TblMatData { get; set; }

    public virtual DbSet<TblMatNavne> TblMatNavnes { get; set; }

    public virtual DbSet<TblMatNorm> TblMatNorms { get; set; }

    public virtual DbSet<TblMaterialer> TblMaterialers { get; set; }

    public virtual DbSet<TblMatriceHoveder> TblMatriceHoveders { get; set; }

    public virtual DbSet<TblMatricerTilPunch> TblMatricerTilPunches { get; set; }

    public virtual DbSet<TblNcr> TblNcrs { get; set; }

    public virtual DbSet<TblNcrfailCode> TblNcrfailCodes { get; set; }

    public virtual DbSet<TblNcrfailCode1> TblNcrfailCodes1 { get; set; }

    public virtual DbSet<TblNcrhandCode> TblNcrhandCodes { get; set; }

    public virtual DbSet<TblObgFradrag> TblObgFradrags { get; set; }

    public virtual DbSet<TblObgTillaeg> TblObgTillaegs { get; set; }

    public virtual DbSet<TblOmstempling> TblOmstemplings { get; set; }

    public virtual DbSet<TblOmstpGenerelt> TblOmstpGenerelts { get; set; }

    public virtual DbSet<TblOmstpLinie> TblOmstpLinies { get; set; }

    public virtual DbSet<TblOperation> TblOperations { get; set; }

    public virtual DbSet<TblOptaellinger> TblOptaellingers { get; set; }

    public virtual DbSet<TblOvertid> TblOvertids { get; set; }

    public virtual DbSet<TblPakkeListe> TblPakkeListes { get; set; }

    public virtual DbSet<TblPaller> TblPallers { get; set; }

    public virtual DbSet<TblPenetrantVisuel> TblPenetrantVisuels { get; set; }

    public virtual DbSet<TblPlanAktivitet> TblPlanAktivitets { get; set; }

    public virtual DbSet<TblPlanPo> TblPlanPos { get; set; }

    public virtual DbSet<TblPlanProd> TblPlanProds { get; set; }

    public virtual DbSet<TblPlanProdLinie> TblPlanProdLinies { get; set; }

    public virtual DbSet<TblPositioner> TblPositioners { get; set; }

    public virtual DbSet<TblPressuretest> TblPressuretests { get; set; }

    public virtual DbSet<TblRekvTransport> TblRekvTransports { get; set; }

    public virtual DbSet<TblRingeTilBalge> TblRingeTilBalges { get; set; }

    public virtual DbSet<TblRingeTilLederor> TblRingeTilLederors { get; set; }

    public virtual DbSet<TblStykliste> TblStyklistes { get; set; }

    public virtual DbSet<TblTiderEnkelt> TblTiderEnkelts { get; set; }

    public virtual DbSet<TblTiderSum> TblTiderSums { get; set; }

    public virtual DbSet<TblTidsreg> TblTidsregs { get; set; }

    public virtual DbSet<TblTilbud> TblTilbuds { get; set; }

    public virtual DbSet<TblTillaeg> TblTillaegs { get; set; }

    public virtual DbSet<TblTillaegDatum> TblTillaegData { get; set; }

    public virtual DbSet<TblTillaegForespørgsel> TblTillaegForespørgsels { get; set; }

    public virtual DbSet<TblValutum> TblValuta { get; set; }

    public virtual DbSet<TblVare> TblVares { get; set; }

    public virtual DbSet<TblVareEnheder> TblVareEnheders { get; set; }

    public virtual DbSet<TblVareGrupper> TblVareGruppers { get; set; }

    public virtual DbSet<TblVareKategori> TblVareKategoris { get; set; }

    public virtual DbSet<TblVareNumre> TblVareNumres { get; set; }

    public virtual DbSet<Tblcertifikater> Tblcertifikaters { get; set; }

    public virtual DbSet<Tblforsp> Tblforsps { get; set; }

    public virtual DbSet<Tblhoved> Tblhoveds { get; set; }

    public virtual DbSet<Tblkunde> Tblkundes { get; set; }

    public virtual DbSet<Tbllinie> Tbllinies { get; set; }

    public virtual DbSet<TbllinieCorrupted> TbllinieCorrupteds { get; set; }

    public virtual DbSet<Tbltegninger> Tbltegningers { get; set; }

    public virtual DbSet<Vedligeholdelse> Vedligeholdelses { get; set; }

    public virtual DbSet<VedligeholdelseForespørgsel> VedligeholdelseForespørgsels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:firstTest");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adresse>(entity =>
        {
            entity.HasKey(e => e.FabrikatTlf).HasName("Adresse$PrimaryKey");

            entity.ToTable("Adresse");

            entity.Property(e => e.FabrikatTlf)
                .HasMaxLength(12)
                .HasColumnName("Fabrikat_tlf");
            entity.Property(e => e.Adresse1)
                .HasMaxLength(50)
                .HasColumnName("Adresse 1");
            entity.Property(e => e.Adresse2)
                .HasMaxLength(50)
                .HasColumnName("Adresse 2");
            entity.Property(e => e.Fabrikat).HasMaxLength(50);
            entity.Property(e => e.KontaktPerson1)
                .HasMaxLength(50)
                .HasColumnName("Kontakt_person1");
            entity.Property(e => e.Mobilnr).HasMaxLength(12);
            entity.Property(e => e.Postnr).HasMaxLength(8);
        });

        modelBuilder.Entity<Body>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__body__3214EC272F4AF72F");

            entity.ToTable("body");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("bodyType");
            entity.Property(e => e.Custom).HasColumnName("custom");
            entity.Property(e => e.HookupBeId).HasColumnName("hookupBe_ID");
            entity.Property(e => e.ParameterName).HasColumnName("parameterName");
            entity.Property(e => e.SqlQuery).HasColumnName("sqlQuery");

            entity.HasOne(d => d.HookupBe).WithMany(p => p.Bodies)
                .HasForeignKey(d => d.HookupBeId)
                .HasConstraintName("FK__body__hookupBe_I__6DEC4894");
        });

        modelBuilder.Entity<CustomCalendarBe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CustomCa__3214EC27BBDF2239");

            entity.ToTable("CustomCalendarBe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HookupBeId).HasColumnName("hookupBe_ID");
            entity.Property(e => e.HookupDateTime)
                .HasColumnType("datetime")
                .HasColumnName("hookupDateTime");

            entity.HasOne(d => d.HookupBe).WithMany(p => p.CustomCalendarBes)
                .HasForeignKey(d => d.HookupBeId)
                .HasConstraintName("FK__CustomCal__hooku__6B0FDBE9");
        });

        modelBuilder.Entity<ElEffekforbrug>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("El_effekforbrug");

            entity.Property(e => e.BeskrivbelseElTilslut).HasColumnName("Beskrivbelse_el_tilslut");
            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.Spænding).HasMaxLength(50);
            entity.Property(e => e.Tekst).HasMaxLength(255);
            entity.Property(e => e.TilslutningTavle).HasColumnName("Tilslutning_tavle");
        });

        modelBuilder.Entity<ForespElTilslutning>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Foresp el tilslutning");

            entity.Property(e => e.BeskrivbelseElTilslut).HasColumnName("Beskrivbelse_el_tilslut");
            entity.Property(e => e.FabNavn)
                .HasMaxLength(50)
                .HasColumnName("Fab_navn");
            entity.Property(e => e.HjælpeFelt)
                .HasMaxLength(10)
                .HasColumnName("Hjælpe felt");
            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.Spænding).HasMaxLength(50);
            entity.Property(e => e.Tekst).HasMaxLength(255);
        });

        modelBuilder.Entity<ForespMerkeplade>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Foresp merkeplade");

            entity.Property(e => e.FabNavn)
                .HasMaxLength(50)
                .HasColumnName("Fab_navn");
            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.Maskinnr).HasMaxLength(50);
            entity.Property(e => e.Tekst).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.År).HasMaxLength(50);
        });

        modelBuilder.Entity<FspKalender>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("fspKalender");

            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.DagDato).HasPrecision(0);
            entity.Property(e => e.DagId).HasColumnName("DagID");
            entity.Property(e => e.KalId).HasColumnName("KalID");
        });

        modelBuilder.Entity<FspLonData2019>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("fspLonData2019");

            entity.Property(e => e.SumOfAfspadsering).HasColumnName("Sum Of Afspadsering");
            entity.Property(e => e.SumOfLonIalt).HasColumnName("Sum Of LonIalt");
            entity.Property(e => e.SumOfLonUdbetalt).HasColumnName("Sum Of LonUdbetalt");
            entity.Property(e => e.SumOfNtimer).HasColumnName("Sum Of NTimer");
            entity.Property(e => e.SumOfOtimer).HasColumnName("Sum Of OTimer");
            entity.Property(e => e.SumOfSkole).HasColumnName("Sum Of Skole");
            entity.Property(e => e.SumOfSygBarn).HasColumnName("Sum Of SygBarn");
            entity.Property(e => e.SumOfSygSelv).HasColumnName("Sum Of SygSelv");
            entity.Property(e => e.SumOfTimeLon).HasColumnName("Sum Of TimeLon");
            entity.Property(e => e.SumOfTtimer).HasColumnName("Sum Of TTimer");
        });

        modelBuilder.Entity<FspLonData2019Afd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("fspLonData2019Afd");

            entity.Property(e => e.AfdId)
                .HasMaxLength(255)
                .HasColumnName("AfdID");
            entity.Property(e => e.SumOfAfspadsering).HasColumnName("Sum Of Afspadsering");
            entity.Property(e => e.SumOfLonIalt).HasColumnName("Sum Of LonIalt");
            entity.Property(e => e.SumOfLonUdbetalt).HasColumnName("Sum Of LonUdbetalt");
            entity.Property(e => e.SumOfNtimer).HasColumnName("Sum Of NTimer");
            entity.Property(e => e.SumOfOtimer).HasColumnName("Sum Of OTimer");
            entity.Property(e => e.SumOfSkole).HasColumnName("Sum Of Skole");
            entity.Property(e => e.SumOfSygBarn).HasColumnName("Sum Of SygBarn");
            entity.Property(e => e.SumOfSygSelv).HasColumnName("Sum Of SygSelv");
            entity.Property(e => e.SumOfTimeLon).HasColumnName("Sum Of TimeLon");
            entity.Property(e => e.SumOfTtimer).HasColumnName("Sum Of TTimer");
        });

        modelBuilder.Entity<FspLonDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("fspLonData");

            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.Efternavn).HasMaxLength(255);
            entity.Property(e => e.Fornavn).HasMaxLength(255);
            entity.Property(e => e.SumOfAfspadsering).HasColumnName("Sum Of Afspadsering");
            entity.Property(e => e.SumOfLonIalt).HasColumnName("Sum Of LonIalt");
            entity.Property(e => e.SumOfLonUdbetalt).HasColumnName("Sum Of LonUdbetalt");
            entity.Property(e => e.SumOfNtimer).HasColumnName("Sum Of NTimer");
            entity.Property(e => e.SumOfOtimer).HasColumnName("Sum Of OTimer");
            entity.Property(e => e.SumOfSkole).HasColumnName("Sum Of Skole");
            entity.Property(e => e.SumOfSygBarn).HasColumnName("Sum Of SygBarn");
            entity.Property(e => e.SumOfSygSelv).HasColumnName("Sum Of SygSelv");
            entity.Property(e => e.SumOfTimeLon).HasColumnName("Sum Of TimeLon");
            entity.Property(e => e.SumOfTtimer).HasColumnName("Sum Of TTimer");
        });

        modelBuilder.Entity<FspTidsReg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("fspTidsReg");

            entity.Property(e => e.AfdId).HasColumnName("AfdID");
            entity.Property(e => e.OrdreId).HasColumnName("OrdreID");
            entity.Property(e => e.OrdreNavn).HasMaxLength(255);
            entity.Property(e => e.TidInd).HasPrecision(0);
            entity.Property(e => e.TidUd).HasPrecision(0);
        });

        modelBuilder.Entity<Header>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("header");

            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.HeaderKey).HasColumnName("headerKey");
            entity.Property(e => e.HookupBeId).HasColumnName("hookupBe_ID");

            entity.HasOne(d => d.HookupBe).WithMany()
                .HasForeignKey(d => d.HookupBeId)
                .HasConstraintName("FK__header__hookupBe__6FD49106");
        });

        modelBuilder.Entity<HookupBe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__hookupBe__3214EC2708569B9E");

            entity.ToTable("hookupBe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IntervalIsEveryDay).HasColumnName("interval_isEveryDay");
            entity.Property(e => e.IntervalIsEveryMonth).HasColumnName("interval_isEveryMonth");
            entity.Property(e => e.IntervalIsEveryWeek).HasColumnName("interval_isEveryWeek");
            entity.Property(e => e.IntervalTimeOfDay)
                .HasColumnType("datetime")
                .HasColumnName("interval_TimeOfDay");
            entity.Property(e => e.MethodType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("method_type");
            entity.Property(e => e.Url)
                .IsUnicode(false)
                .HasColumnName("url");
        });

        modelBuilder.Entity<KapabilitetForsp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Kapabilitet forsp");

            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.PdfFilVedhæftet).HasColumnName("Pdf fil vedhæftet");
            entity.Property(e => e.Tekst).HasMaxLength(255);
        });

        modelBuilder.Entity<Kapabillitet>(entity =>
        {
            entity.HasKey(e => e.LinieNr).HasName("Kapabillitet$PrimaryKey");

            entity.ToTable("Kapabillitet");

            entity.HasIndex(e => e.LinieNr, "Kapabillitet$Linie_nrKapabillitet").IsUnique();

            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.Kapabillitet1).HasColumnName("Kapabillitet");
            entity.Property(e => e.PdfFilVedhæftet).HasColumnName("Pdf fil vedhæftet");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<LinieNr>(entity =>
        {
            entity.HasKey(e => e.LinieNr1).HasName("Linie_nr$PrimaryKey");

            entity.ToTable("Linie_nr");

            entity.HasIndex(e => e.Id, "Linie_nr$ID");

            entity.Property(e => e.LinieNr1)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.Andet).HasMaxLength(5);
            entity.Property(e => e.Drift).HasDefaultValue(false);
            entity.Property(e => e.Godkendt).HasMaxLength(255);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Plasering).HasMaxLength(50);
            entity.Property(e => e.SerieNr)
                .HasMaxLength(255)
                .HasColumnName("Serie_nr");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Tekst).HasMaxLength(255);
            entity.Property(e => e.År).HasMaxLength(8);
        });

        modelBuilder.Entity<LinienrForesp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Linienr foresp");

            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.LinieNrAndet)
                .HasMaxLength(5)
                .HasColumnName("Linie_nr_Andet");
            entity.Property(e => e.LinieNrAndet2)
                .HasMaxLength(5)
                .HasColumnName("Linie_nr_Andet$2");
            entity.Property(e => e.LinieNrDrift).HasColumnName("Linie_nr_Drift");
            entity.Property(e => e.LinieNrDrift3).HasColumnName("Linie_nr_Drift$3");
            entity.Property(e => e.Plasering).HasMaxLength(50);
            entity.Property(e => e.SerieNr)
                .HasMaxLength(255)
                .HasColumnName("Serie_nr");
            entity.Property(e => e.Tekst).HasMaxLength(255);
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__log__3214EC27559D8E7A");

            entity.ToTable("log");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ErrorMessage).HasColumnName("errorMessage");
            entity.Property(e => e.HookupBeId).HasColumnName("hookupBe_ID");
            entity.Property(e => e.IsSuccessful).HasColumnName("isSuccessful");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.HookupBe).WithMany(p => p.Logs)
                .HasForeignKey(d => d.HookupBeId)
                .HasConstraintName("FK__log__hookupBe_ID__73A521EA");
        });

        modelBuilder.Entity<Maskinkartotekt>(entity =>
        {
            entity.HasKey(e => e.Maskinnr).HasName("Maskinkartotekt$PrimaryKey");

            entity.ToTable("Maskinkartotekt");

            entity.HasIndex(e => e.FabrikatTlf, "Maskinkartotekt$Fabrikat_tlf");

            entity.Property(e => e.Maskinnr).HasMaxLength(50);
            entity.Property(e => e.DossierNr)
                .HasMaxLength(50)
                .HasColumnName("Dossier_nr");
            entity.Property(e => e.FabrikatTlf)
                .HasMaxLength(12)
                .HasColumnName("Fabrikat_tlf");
            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.Lokation).HasMaxLength(8);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.År).HasMaxLength(6);

            entity.HasOne(d => d.FabrikatTlfNavigation).WithMany(p => p.Maskinkartotekts)
                .HasForeignKey(d => d.FabrikatTlf)
                .HasConstraintName("Maskinkartotekt$AdresseMaskinkartotekt");

            entity.HasOne(d => d.LinieNrNavigation).WithMany(p => p.Maskinkartotekts)
                .HasForeignKey(d => d.LinieNr)
                .HasConstraintName("Maskinkartotekt$Linie_nrMaskinkartotekt");
        });

        modelBuilder.Entity<MærkepladeTabel>(entity =>
        {
            entity.HasKey(e => e.LinieNr).HasName("Mærkeplade_tabel$PrimaryKey");

            entity.ToTable("Mærkeplade_tabel");

            entity.HasIndex(e => e.Maskinnr, "Mærkeplade_tabel$Maskinnr").IsUnique();

            entity.HasIndex(e => e.LinieNr, "Mærkeplade_tabel$Mærkeplade_tabelLinie_nr");

            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.BeskrivbelseElTilslut).HasColumnName("Beskrivbelse_el_tilslut");
            entity.Property(e => e.Effekt).HasDefaultValue(0f);
            entity.Property(e => e.FabNavn)
                .HasMaxLength(50)
                .HasColumnName("Fab_navn");
            entity.Property(e => e.Forsikring).HasDefaultValue(0);
            entity.Property(e => e.HjælpeFelt)
                .HasMaxLength(10)
                .HasColumnName("Hjælpe felt");
            entity.Property(e => e.Luftmængde).HasDefaultValue(0f);
            entity.Property(e => e.Maskinnr).HasMaxLength(50);
            entity.Property(e => e.Spænding).HasMaxLength(50);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Strøm).HasDefaultValue(0f);
            entity.Property(e => e.Tilslutning).HasDefaultValue(0);
            entity.Property(e => e.TilslutningTavle)
                .HasDefaultValue(0)
                .HasColumnName("Tilslutning_tavle");
            entity.Property(e => e.Trykluft).HasDefaultValue(0f);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.Vægt).HasDefaultValue(0);
            entity.Property(e => e.År).HasMaxLength(50);

            entity.HasOne(d => d.LinieNrNavigation).WithOne(p => p.MærkepladeTabel)
                .HasForeignKey<MærkepladeTabel>(d => d.LinieNr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Mærkeplade_tabel$Linie_nrMærkeplade_tabel");
        });

        modelBuilder.Entity<Postnr>(entity =>
        {
            entity.HasKey(e => e.Postnr1).HasName("Postnr$PrimaryKey");

            entity.ToTable("Postnr");

            entity.Property(e => e.Postnr1)
                .HasMaxLength(8)
                .HasColumnName("Postnr");
            entity.Property(e => e.By).HasMaxLength(50);
        });

        modelBuilder.Entity<QHentProjekter>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qHentProjekter");

            entity.Property(e => e.Firma).HasMaxLength(60);
            entity.Property(e => e.Initialer).HasMaxLength(5);
            entity.Property(e => e.Ktype)
                .HasMaxLength(60)
                .HasColumnName("KType");
            entity.Property(e => e.OrdreDato).HasPrecision(0);
            entity.Property(e => e.OrdreNr).HasMaxLength(30);
            entity.Property(e => e.TilbudId).HasColumnName("TilbudID");
            entity.Property(e => e.TilbudNr).HasMaxLength(20);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServiceNr).HasName("Service$PrimaryKey");

            entity.ToTable("Service");

            entity.Property(e => e.ServiceNr).HasColumnName("Service_nr");
            entity.Property(e => e.DatoStart)
                .HasPrecision(0)
                .HasColumnName("Dato_start");
            entity.Property(e => e.DatoUdført)
                .HasPrecision(0)
                .HasColumnName("Dato_udført");
            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.Priotet).HasMaxLength(50);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.LinieNrNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.LinieNr)
                .HasConstraintName("Service$Linie_nrService");
        });

        modelBuilder.Entity<ServiceIkkeUdført>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Service_ikke_udført");

            entity.Property(e => e.DatoStart)
                .HasPrecision(0)
                .HasColumnName("Dato_start");
            entity.Property(e => e.DatoUdført)
                .HasPrecision(0)
                .HasColumnName("Dato_udført");
            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.LinieNrTekst)
                .HasMaxLength(255)
                .HasColumnName("Linie_nr_Tekst");
            entity.Property(e => e.Priotet).HasMaxLength(50);
            entity.Property(e => e.ServiceNr).HasColumnName("Service_nr");
            entity.Property(e => e.ServiceTekst).HasColumnName("Service_Tekst");
        });

        modelBuilder.Entity<ServiceRepForespørgsel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Service rep forespørgsel");

            entity.Property(e => e.DatoStart)
                .HasPrecision(0)
                .HasColumnName("Dato_start");
            entity.Property(e => e.DatoUdført)
                .HasPrecision(0)
                .HasColumnName("Dato_udført");
            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.LinieNrTekst)
                .HasMaxLength(255)
                .HasColumnName("Linie_nr_Tekst");
            entity.Property(e => e.ServiceNr).HasColumnName("Service_nr");
            entity.Property(e => e.ServiceTekst).HasColumnName("Service_Tekst");
        });

        modelBuilder.Entity<TblAfdelinger>(entity =>
        {
            entity.HasKey(e => e.AfdId).HasName("tblAfdelinger$PrimaryKey");

            entity.ToTable("tblAfdelinger");

            entity.Property(e => e.AfdId).HasColumnName("AfdID");
            entity.Property(e => e.AfdNavn).HasMaxLength(255);
        });

        modelBuilder.Entity<TblAftraek>(entity =>
        {
            entity.HasKey(e => e.AftraekId).HasName("tblAftraek$PrimaryKey");

            entity.ToTable("tblAftraek");

            entity.HasIndex(e => e.AftraekId, "tblAftraek$AftraekID");

            entity.HasIndex(e => e.MatId, "tblAftraek$MatID");

            entity.HasIndex(e => e.PosRevId, "tblAftraek$PosRevID");

            entity.HasIndex(e => e.TilbudId, "tblAftraek$TilbudID");

            entity.Property(e => e.AftraekId).HasColumnName("AftraekID");
            entity.Property(e => e.AfStumper).HasDefaultValue(false);
            entity.Property(e => e.AftraekD).HasPrecision(0);
            entity.Property(e => e.AftraekEnhed).HasMaxLength(32);
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.ForbrugEnhed).HasMaxLength(32);
            entity.Property(e => e.ForbrugMasse).HasDefaultValue(0f);
            entity.Property(e => e.ItemPos).HasMaxLength(5);
            entity.Property(e => e.MatId).HasColumnName("MatID");
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Stnr)
                .HasMaxLength(10)
                .HasColumnName("STnr");
            entity.Property(e => e.TilbudId).HasColumnName("TilbudID");

            entity.HasOne(d => d.Mat).WithMany(p => p.TblAftraeks)
                .HasForeignKey(d => d.MatId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblAftraek$[D:\\første\\MaterialerBE.mdb].tblMaterialertblAftraek");
        });

        modelBuilder.Entity<TblAltReg>(entity =>
        {
            entity.HasKey(e => e.AltId).HasName("tblAltReg$PrimaryKey");

            entity.ToTable("tblAltReg");

            entity.Property(e => e.AltId).HasColumnName("AltID");
            entity.Property(e => e.AltColorIndex).HasDefaultValue(0);
            entity.Property(e => e.AltColorRgb)
                .HasMaxLength(16)
                .HasColumnName("AltColorRGB");
            entity.Property(e => e.AltErAfdeling).HasDefaultValue(false);
            entity.Property(e => e.AltErAktiv).HasDefaultValue(false);
            entity.Property(e => e.AltNavn).HasMaxLength(255);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<TblArbejdere>(entity =>
        {
            entity.HasKey(e => e.ArbId).HasName("tblArbejdere$PrimaryKey");

            entity.ToTable("tblArbejdere");

            entity.HasIndex(e => e.AfdId, "tblArbejdere$AfdID");

            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.AfdId)
                .HasMaxLength(255)
                .HasColumnName("AfdID");
            entity.Property(e => e.AfdelingId)
                .HasDefaultValue(0)
                .HasColumnName("AfdelingID");
            entity.Property(e => e.AnsatDato).HasPrecision(0);
            entity.Property(e => e.Efternavn).HasMaxLength(255);
            entity.Property(e => e.Fornavn).HasMaxLength(255);
            entity.Property(e => e.Ipoandel).HasColumnName("IPOandel");
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Tillaeg).HasDefaultValue(0f);
        });

        modelBuilder.Entity<TblBelastning>(entity =>
        {
            entity.HasKey(e => e.LinieId).HasName("tblBelastning$PrimaryKey");

            entity.ToTable("tblBelastning");

            entity.HasIndex(e => e.DagId, "tblBelastning$DagID");

            entity.HasIndex(e => e.TilbudsId, "tblBelastning$TilbudsID");

            entity.Property(e => e.LinieId).HasColumnName("LinieID");
            entity.Property(e => e.DagId).HasColumnName("DagID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TidBalgrum).HasDefaultValue(0f);
            entity.Property(e => e.TidHal1).HasDefaultValue(0f);
            entity.Property(e => e.TidHal2).HasDefaultValue(0f);
            entity.Property(e => e.TidHalvfab).HasDefaultValue(0f);
            entity.Property(e => e.TidHydro).HasDefaultValue(0f);
            entity.Property(e => e.TilbudsId).HasColumnName("TilbudsID");

            entity.HasOne(d => d.Dag).WithMany(p => p.TblBelastnings)
                .HasForeignKey(d => d.DagId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblBelastning$tblDagetblBelastning");
        });

        modelBuilder.Entity<TblBeskeder>(entity =>
        {
            entity.HasKey(e => e.HejId).HasName("tblBeskeder$PrimaryKey");

            entity.ToTable("tblBeskeder");

            entity.HasIndex(e => e.ArbId, "tblBeskeder$ArbID");

            entity.Property(e => e.HejId).HasColumnName("HejID");
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.Hjem).HasMaxLength(255);
            entity.Property(e => e.LinkPic).HasMaxLength(255);
            entity.Property(e => e.Morg).HasMaxLength(255);

            entity.HasOne(d => d.Arb).WithMany(p => p.TblBeskeders)
                .HasForeignKey(d => d.ArbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblBeskeder$[D:\\første\\TidsRegDB.mdb].{407F72AF-E483-4F85-99BB-A7086A378EDC}");
        });

        modelBuilder.Entity<TblChange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tblChanges$PrimaryKey");

            entity.ToTable("tblChanges");

            entity.HasIndex(e => e.RegId, "tblChanges$RegID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChangedD).HasPrecision(0);
            entity.Property(e => e.RegId)
                .HasDefaultValue(0)
                .HasColumnName("RegID");
            entity.Property(e => e.TidIndNew).HasPrecision(0);
            entity.Property(e => e.TidIndOld).HasPrecision(0);
            entity.Property(e => e.TidUdNew).HasPrecision(0);
            entity.Property(e => e.TidUdOld).HasPrecision(0);
            entity.Property(e => e.User).HasMaxLength(32);
        });

        modelBuilder.Entity<TblChargeNr>(entity =>
        {
            entity.HasKey(e => e.ChargeId).HasName("tblChargeNr$PrimaryKey");

            entity.ToTable("tblChargeNr");

            entity.HasIndex(e => e.CertId, "tblChargeNr$CertID");

            entity.HasIndex(e => e.LinieId, "tblChargeNr$LinieID");

            entity.HasIndex(e => e.RekvId, "tblChargeNr$RekvID");

            entity.Property(e => e.ChargeId).HasColumnName("ChargeID");
            entity.Property(e => e.CertId).HasColumnName("CertID");
            entity.Property(e => e.ChargeNr).HasMaxLength(255);
            entity.Property(e => e.LinieId).HasColumnName("LinieID");
            entity.Property(e => e.RekvId).HasColumnName("RekvID");

            entity.HasOne(d => d.Cert).WithMany(p => p.TblChargeNrs)
                .HasForeignKey(d => d.CertId)
                .HasConstraintName("tblChargeNr$[D:\\første\\RekvTables.mdb].{777D93FE-478D-459C-BF7D-28E3B7F46216}");

            entity.HasOne(d => d.Rekv).WithMany(p => p.TblChargeNrs)
                .HasForeignKey(d => d.RekvId)
                .HasConstraintName("tblChargeNr$[D:\\første\\RekvTables.mdb].{1BCBF13D-D58A-40E3-93C7-A3D483BA2449}");
        });

        modelBuilder.Entity<TblDage>(entity =>
        {
            entity.HasKey(e => e.DagId).HasName("tblDage$PrimaryKey");

            entity.ToTable("tblDage");

            entity.Property(e => e.DagId).HasColumnName("DagID");
            entity.Property(e => e.DagDato).HasPrecision(0);
            entity.Property(e => e.KapBalgrum).HasDefaultValue(0f);
            entity.Property(e => e.KapHal1).HasDefaultValue(0f);
            entity.Property(e => e.KapHal2).HasDefaultValue(0f);
            entity.Property(e => e.KapHalvfab).HasDefaultValue(0f);
            entity.Property(e => e.KapHydro).HasDefaultValue(0f);
            entity.Property(e => e.KapIpo)
                .HasDefaultValue(0f)
                .HasColumnName("KapIPO");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<TblDelRecord>(entity =>
        {
            entity.HasKey(e => e.DelId).HasName("tblDelRecord$PrimaryKey");

            entity.ToTable("tblDelRecord");

            entity.HasIndex(e => e.PlanLinieId, "tblDelRecord$PlanLinieID");

            entity.HasIndex(e => e.PlanProdId, "tblDelRecord$PlanProdID");

            entity.HasIndex(e => e.PosRevId, "tblDelRecord$PosRevID");

            entity.Property(e => e.DelId).HasColumnName("DelID");
            entity.Property(e => e.AntalProd).HasDefaultValue(0);
            entity.Property(e => e.PlanLinieId)
                .HasDefaultValue(0)
                .HasColumnName("PlanLinieID");
            entity.Property(e => e.PlanProdId)
                .HasDefaultValue(0)
                .HasColumnName("PlanProdID");
            entity.Property(e => e.PosRevId)
                .HasDefaultValue(0)
                .HasColumnName("PosRevID");
        });

        modelBuilder.Entity<TblDesignere>(entity =>
        {
            entity.HasKey(e => e.DesignerId).HasName("tblDesignere$PrimaryKey");

            entity.ToTable("tblDesignere");

            entity.HasIndex(e => e.Initialer, "tblDesignere$Initialer").IsUnique();

            entity.Property(e => e.DesignerId).HasColumnName("DesignerID");
            entity.Property(e => e.Aktiv).HasDefaultValue(false);
            entity.Property(e => e.Initialer).HasMaxLength(5);
            entity.Property(e => e.Mail).HasMaxLength(60);
            entity.Property(e => e.Navn).HasMaxLength(60);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Tlf).HasMaxLength(20);
        });

        modelBuilder.Entity<TblDoC>(entity =>
        {
            entity.HasKey(e => e.DocId).HasName("tblDoC$PrimaryKey");

            entity.ToTable("tblDoC");

            entity.HasIndex(e => e.PosRevId, "tblDoC$PosRevID");

            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.DateFixed).HasPrecision(0);
            entity.Property(e => e.FluidGrp).HasMaxLength(255);
            entity.Property(e => e.Lt)
                .HasDefaultValue(false)
                .HasColumnName("LT");
            entity.Property(e => e.Modul).HasMaxLength(255);
            entity.Property(e => e.Mt)
                .HasDefaultValue(false)
                .HasColumnName("MT");
            entity.Property(e => e.NoBo).HasMaxLength(255);
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.Pt)
                .HasDefaultValue(false)
                .HasColumnName("PT");
            entity.Property(e => e.Pt20)
                .HasDefaultValue(false)
                .HasColumnName("PT20");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Rt)
                .HasDefaultValue(false)
                .HasColumnName("RT");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Standard).HasMaxLength(255);
            entity.Property(e => e.TestPressure).HasMaxLength(255);
            entity.Property(e => e.Vt)
                .HasDefaultValue(false)
                .HasColumnName("VT");
        });

        modelBuilder.Entity<TblDokuCert>(entity =>
        {
            entity.HasKey(e => e.DokuCertId).HasName("tblDokuCert$PrimaryKey");

            entity.ToTable("tblDokuCert");

            entity.HasIndex(e => e.PosRevId, "tblDokuCert$PosRevID");

            entity.Property(e => e.DokuCertId).HasColumnName("DokuCertID");
            entity.Property(e => e.DateCreated).HasPrecision(0);
            entity.Property(e => e.DateSent).HasPrecision(0);
            entity.Property(e => e.DokuFile).HasMaxLength(255);
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
        });

        modelBuilder.Entity<TblDokumentation>(entity =>
        {
            entity.HasKey(e => e.DokuReqId).HasName("tblDokumentation$PrimaryKey");

            entity.ToTable("tblDokumentation");

            entity.HasIndex(e => e.PosRevId, "tblDokumentation$PosRevID");

            entity.Property(e => e.DokuReqId).HasColumnName("DokuReqID");
            entity.Property(e => e.BellowNorm).HasMaxLength(20);
            entity.Property(e => e.CategoryText).HasMaxLength(20);
            entity.Property(e => e.ClientName).HasMaxLength(255);
            entity.Property(e => e.ClientOrderNo).HasMaxLength(100);
            entity.Property(e => e.ClientQuoteNo).HasMaxLength(100);
            entity.Property(e => e.DateFixedDoc)
                .HasPrecision(0)
                .HasColumnName("DateFixedDOC");
            entity.Property(e => e.DateFixedLtpt20)
                .HasPrecision(0)
                .HasColumnName("DateFixedLTPT20");
            entity.Property(e => e.DateFixedPtvt)
                .HasPrecision(0)
                .HasColumnName("DateFixedPTVT");
            entity.Property(e => e.DateFixedStp)
                .HasPrecision(0)
                .HasColumnName("DateFixedSTP");
            entity.Property(e => e.Dn).HasColumnName("DN");
            entity.Property(e => e.DocOk)
                .HasDefaultValue(false)
                .HasColumnName("DOc_OK");
            entity.Property(e => e.Docfile)
                .HasMaxLength(255)
                .HasColumnName("DOCfile");
            entity.Property(e => e.Docrpt)
                .HasDefaultValue(false)
                .HasColumnName("DOCrpt");
            entity.Property(e => e.EndeTypeH).HasMaxLength(10);
            entity.Property(e => e.EndeTypeV).HasMaxLength(10);
            entity.Property(e => e.FluidGrp).HasMaxLength(10);
            entity.Property(e => e.Kategori).HasMaxLength(50);
            entity.Property(e => e.LtOk)
                .HasDefaultValue(false)
                .HasColumnName("LT_OK");
            entity.Property(e => e.Ltfile)
                .HasMaxLength(255)
                .HasColumnName("LTfile");
            entity.Property(e => e.Ltrpt)
                .HasDefaultValue(false)
                .HasColumnName("LTrpt");
            entity.Property(e => e.Module).HasMaxLength(255);
            entity.Property(e => e.Ndtstd)
                .HasMaxLength(255)
                .HasColumnName("NDTStd");
            entity.Property(e => e.NoBo).HasMaxLength(255);
            entity.Property(e => e.ObjectDimension).HasMaxLength(100);
            entity.Property(e => e.ObjectTypeNo).HasMaxLength(100);
            entity.Property(e => e.Pd)
                .HasMaxLength(255)
                .HasColumnName("PD");
            entity.Property(e => e.Pdmin).HasColumnName("PDmin");
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.Pt20Ok)
                .HasDefaultValue(false)
                .HasColumnName("PT20_OK");
            entity.Property(e => e.Pt20extern)
                .HasDefaultValue(false)
                .HasColumnName("PT20Extern");
            entity.Property(e => e.Pt20file)
                .HasMaxLength(255)
                .HasColumnName("PT20file");
            entity.Property(e => e.Pt20rpt)
                .HasDefaultValue(false)
                .HasColumnName("PT20rpt");
            entity.Property(e => e.PtOk)
                .HasDefaultValue(false)
                .HasColumnName("PT_OK");
            entity.Property(e => e.Ptfile)
                .HasMaxLength(255)
                .HasColumnName("PTfile");
            entity.Property(e => e.Ptrpt)
                .HasDefaultValue(false)
                .HasColumnName("PTrpt");
            entity.Property(e => e.RtOk)
                .HasDefaultValue(false)
                .HasColumnName("RT_OK");
            entity.Property(e => e.Rtfile)
                .HasMaxLength(255)
                .HasColumnName("RTfile");
            entity.Property(e => e.Rtrpt)
                .HasDefaultValue(false)
                .HasColumnName("RTrpt");
            entity.Property(e => e.SagsNr).HasMaxLength(15);
            entity.Property(e => e.SerialNo).HasMaxLength(20);
            entity.Property(e => e.SignDoC).HasMaxLength(5);
            entity.Property(e => e.SignPtlt)
                .HasMaxLength(5)
                .HasColumnName("SignPTLT");
            entity.Property(e => e.SignStp)
                .HasMaxLength(5)
                .HasColumnName("SignSTP");
            entity.Property(e => e.SignVtpt)
                .HasMaxLength(5)
                .HasColumnName("SignVTPT");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.StpOk)
                .HasDefaultValue(false)
                .HasColumnName("STP_OK");
            entity.Property(e => e.Stpfile)
                .HasMaxLength(255)
                .HasColumnName("STPfile");
            entity.Property(e => e.Stprpt)
                .HasDefaultValue(false)
                .HasColumnName("STPrpt");
            entity.Property(e => e.TagNr).HasMaxLength(100);
            entity.Property(e => e.Td).HasColumnName("TD");
            entity.Property(e => e.Tdmin).HasColumnName("TDmin");
            entity.Property(e => e.VtOk)
                .HasDefaultValue(false)
                .HasColumnName("VT_OK");
            entity.Property(e => e.Vtfile)
                .HasMaxLength(255)
                .HasColumnName("VTfile");
            entity.Property(e => e.Vtrpt)
                .HasDefaultValue(false)
                .HasColumnName("VTrpt");
            entity.Property(e => e.YearOfBuild).HasMaxLength(5);
        });

        modelBuilder.Entity<TblEmneTyper>(entity =>
        {
            entity.HasKey(e => e.EmneId).HasName("tblEmneTyper$PrimaryKey");

            entity.ToTable("tblEmneTyper");

            entity.HasIndex(e => e.EnhedId, "tblEmneTyper$EnhedID");

            entity.Property(e => e.EmneId).HasColumnName("EmneID");
            entity.Property(e => e.EmneDesc).HasMaxLength(100);
            entity.Property(e => e.EmneKort).HasMaxLength(10);
            entity.Property(e => e.EnhedDesc).HasMaxLength(20);
            entity.Property(e => e.EnhedId).HasColumnName("EnhedID");
        });

        modelBuilder.Entity<TblExOmkost>(entity =>
        {
            entity.HasKey(e => e.ExId).HasName("tblExOmkost$PrimaryKey");

            entity.ToTable("tblExOmkost");

            entity.HasIndex(e => e.TilbudId, "tblExOmkost$PosRevID");

            entity.Property(e => e.ExId).HasColumnName("ExID");
            entity.Property(e => e.ExDesc).HasMaxLength(100);
            entity.Property(e => e.ExPris).HasColumnType("money");
            entity.Property(e => e.ExValuta).HasMaxLength(5);
            entity.Property(e => e.TilbudId).HasColumnName("TilbudID");
        });

        modelBuilder.Entity<TblFaktura>(entity =>
        {
            entity.HasKey(e => e.FakId).HasName("tblFaktura$PrimaryKey");

            entity.ToTable("tblFaktura");

            entity.HasIndex(e => e.RekvId, "tblFaktura$RekvID");

            entity.Property(e => e.FakId).HasColumnName("FakID");
            entity.Property(e => e.FilePath).HasMaxLength(255);
            entity.Property(e => e.RekvId).HasColumnName("RekvID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Rekv).WithMany(p => p.TblFakturas)
                .HasForeignKey(d => d.RekvId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblFaktura${03E93004-81E6-49E8-802B-C257CACE669D}");
        });

        modelBuilder.Entity<TblFasteFradrag>(entity =>
        {
            entity.HasKey(e => e.FfraId).HasName("tblFasteFradrag$PrimaryKey");

            entity.ToTable("tblFasteFradrag");

            entity.HasIndex(e => e.ArbId, "tblFasteFradrag$ArbID");

            entity.HasIndex(e => e.FraId, "tblFasteFradrag$FraID");

            entity.Property(e => e.FfraId).HasColumnName("FFraID");
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.FraId).HasColumnName("FraID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<TblFasteTillaeg>(entity =>
        {
            entity.HasKey(e => e.FtilId).HasName("tblFasteTillaeg$PrimaryKey");

            entity.ToTable("tblFasteTillaeg");

            entity.HasIndex(e => e.ArbId, "tblFasteTillaeg$ArbID");

            entity.HasIndex(e => e.TilId, "tblFasteTillaeg$TilID");

            entity.Property(e => e.FtilId).HasColumnName("FTilID");
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TilId).HasColumnName("TilID");
        });

        modelBuilder.Entity<TblFejlkoder>(entity =>
        {
            entity.HasKey(e => e.FejlId).HasName("tblFejlkoder$PrimaryKey");

            entity.ToTable("tblFejlkoder");

            entity.Property(e => e.FejlId).HasColumnName("FejlID");
            entity.Property(e => e.FejlType).HasMaxLength(255);
        });

        modelBuilder.Entity<TblFinish>(entity =>
        {
            entity.HasKey(e => e.Finish).HasName("tblFinish$PrimaryKey");

            entity.ToTable("tblFinish");

            entity.HasIndex(e => e.KatId, "tblFinish$EmneID");

            entity.Property(e => e.Finish).HasMaxLength(255);
            entity.Property(e => e.FinishDesc).HasMaxLength(255);
            entity.Property(e => e.HotOrCold).HasDefaultValue(0);
            entity.Property(e => e.KatId)
                .HasDefaultValue(0)
                .HasColumnName("KatID");
            entity.Property(e => e.OvId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OvID");
            entity.Property(e => e.Remark).HasMaxLength(255);
        });

        modelBuilder.Entity<TblForbrug>(entity =>
        {
            entity.HasKey(e => e.ForbrugId).HasName("tblForbrug$PrimaryKey");

            entity.ToTable("tblForbrug");

            entity.HasIndex(e => e.KildeId, "tblForbrug$KildeID");

            entity.HasIndex(e => e.MatId, "tblForbrug$MatID");

            entity.HasIndex(e => e.PosRevId, "tblForbrug$PosRevID");

            entity.Property(e => e.ForbrugId).HasColumnName("ForbrugID");
            entity.Property(e => e.Cert).HasMaxLength(255);
            entity.Property(e => e.ChargeNr).HasMaxLength(50);
            entity.Property(e => e.Desc).HasMaxLength(255);
            entity.Property(e => e.Dim).HasMaxLength(255);
            entity.Property(e => e.ItemNr).HasMaxLength(10);
            entity.Property(e => e.KildeId)
                .HasDefaultValue(0)
                .HasColumnName("KildeID");
            entity.Property(e => e.Mat).HasMaxLength(30);
            entity.Property(e => e.MatId).HasColumnName("MatID");
            entity.Property(e => e.Omstempling).HasMaxLength(50);
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Stnr)
                .HasMaxLength(10)
                .HasColumnName("STnr");

            entity.HasOne(d => d.MatNavigation).WithMany(p => p.TblForbrugs)
                .HasForeignKey(d => d.MatId)
                .HasConstraintName("tblForbrug$[D:\\første\\MaterialerBE.mdb].tblMaterialertblForbrug");
        });

        modelBuilder.Entity<TblFradrag>(entity =>
        {
            entity.HasKey(e => e.FraId).HasName("tblFradrag$PrimaryKey");

            entity.ToTable("tblFradrag");

            entity.Property(e => e.FraId).HasColumnName("FraID");
            entity.Property(e => e.FraNavn).HasMaxLength(255);
        });

        modelBuilder.Entity<TblFradragDatum>(entity =>
        {
            entity.HasKey(e => e.FradragId).HasName("tblFradragData$PrimaryKey");

            entity.ToTable("tblFradragData");

            entity.HasIndex(e => e.ArbId, "tblFradragData$ArbID");

            entity.HasIndex(e => e.FraId, "tblFradragData$FraID");

            entity.HasIndex(e => e.LonId, "tblFradragData$LonID");

            entity.Property(e => e.FradragId).HasColumnName("FradragID");
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.FraId).HasColumnName("FraID");
            entity.Property(e => e.LonId).HasColumnName("LonID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Arb).WithMany(p => p.TblFradragData)
                .HasForeignKey(d => d.ArbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblFradragData${28C683E7-0FB5-49ED-95D1-E2302E0E494A}");

            entity.HasOne(d => d.Fra).WithMany(p => p.TblFradragData)
                .HasForeignKey(d => d.FraId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblFradragData${B206FBFE-B112-4AC2-94C2-FC57659D7F39}");

            entity.HasOne(d => d.Lon).WithMany(p => p.TblFradragData)
                .HasForeignKey(d => d.LonId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblFradragData${01E404D1-7E83-4C76-B406-94AA800F0EFC}");
        });

        modelBuilder.Entity<TblFradragForespørgsel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tblFradrag Forespørgsel");

            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.FraNavn).HasMaxLength(255);
        });

        modelBuilder.Entity<TblFuskLinie>(entity =>
        {
            entity.HasKey(e => e.FuskId).HasName("tblFuskLinie$PrimaryKey");

            entity.ToTable("tblFuskLinie");

            entity.HasIndex(e => e.ArbId, "tblFuskLinie$ArbID");

            entity.HasIndex(e => e.LonId, "tblFuskLinie$LonID");

            entity.Property(e => e.FuskId).HasColumnName("FuskID");
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.LonId).HasColumnName("LonID");
        });

        modelBuilder.Entity<TblIpo>(entity =>
        {
            entity.HasKey(e => e.Ipoid).HasName("tblIPO$PrimaryKey");

            entity.ToTable("tblIPO");

            entity.Property(e => e.Ipoid).HasColumnName("IPOID");
            entity.Property(e => e.Ipotype)
                .HasMaxLength(255)
                .HasColumnName("IPOtype");
        });

        modelBuilder.Entity<TblJobliste>(entity =>
        {
            entity.HasKey(e => e.KlarId).HasName("tblJobliste$PrimaryKey");

            entity.ToTable("tblJobliste");

            entity.HasIndex(e => e.KildeId, "tblJobliste$AfdID");

            entity.HasIndex(e => e.PlanLinieId, "tblJobliste$PlanLinieID");

            entity.HasIndex(e => e.PosRevId, "tblJobliste$PosRevID");

            entity.HasIndex(e => e.RekvId, "tblJobliste$RekvID");

            entity.Property(e => e.KlarId).HasColumnName("KlarID");
            entity.Property(e => e.Afvigelse).HasDefaultValue(false);
            entity.Property(e => e.ForbrugEnhed).HasMaxLength(10);
            entity.Property(e => e.ItemPos).HasMaxLength(30);
            entity.Property(e => e.KildeId).HasColumnName("KildeID");
            entity.Property(e => e.KlarMelding).HasDefaultValue(false);
            entity.Property(e => e.KlarMeldingD).HasPrecision(0);
            entity.Property(e => e.Klippet).HasDefaultValue(false);
            entity.Property(e => e.LagerKontrol).HasMaxLength(30);
            entity.Property(e => e.NyLinje).HasDefaultValue(false);
            entity.Property(e => e.PlanLinieId)
                .HasDefaultValue(0)
                .HasColumnName("PlanLinieID");
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.RekvId).HasColumnName("RekvID");
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.SlutD).HasPrecision(0);
            entity.Property(e => e.SlutKw)
                .HasMaxLength(5)
                .HasColumnName("SlutKW");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.StartD).HasPrecision(0);
            entity.Property(e => e.StartKw)
                .HasMaxLength(5)
                .HasColumnName("StartKW");
            entity.Property(e => e.VasletSvejst).HasDefaultValue(false);

            entity.HasOne(d => d.Kilde).WithMany(p => p.TblJoblistes)
                .HasForeignKey(d => d.KildeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblJobliste$[D:\\første\\MaterialerBE.mdb].{7618CF76-0199-48A5-BFB4-AAAD71DDCDF7}");
        });

        modelBuilder.Entity<TblKalender>(entity =>
        {
            entity.HasKey(e => e.KalId).HasName("tblKalender$PrimaryKey");

            entity.ToTable("tblKalender");

            entity.HasIndex(e => e.AltId, "tblKalender$AltID");

            entity.HasIndex(e => e.ArbId, "tblKalender$ArbID");

            entity.HasIndex(e => e.DagId, "tblKalender$DagID");

            entity.HasIndex(e => e.ColKal, "tblKalender$DisTid");

            entity.Property(e => e.KalId).HasColumnName("KalID");
            entity.Property(e => e.AltId)
                .HasDefaultValue(0)
                .HasColumnName("AltID");
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.DagId).HasColumnName("DagID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Dag).WithMany(p => p.TblKalenders)
                .HasForeignKey(d => d.DagId)
                .HasConstraintName("tblKalender$tblDagetblDisponibel");
        });

        modelBuilder.Entity<TblKilde>(entity =>
        {
            entity.HasKey(e => e.KildeId).HasName("tblKilde$PrimaryKey");

            entity.ToTable("tblKilde");

            entity.Property(e => e.KildeId).HasColumnName("KildeID");
            entity.Property(e => e.KildeNavn).HasMaxLength(255);
        });

        modelBuilder.Entity<TblKontaktLev>(entity =>
        {
            entity.HasKey(e => e.KonId).HasName("tblKontaktLev$PrimaryKey");

            entity.ToTable("tblKontaktLev");

            entity.HasIndex(e => e.RekvKundeId, "tblKontaktLev$KundeID");

            entity.Property(e => e.KonId).HasColumnName("KonID");
            entity.Property(e => e.KonMail).HasMaxLength(255);
            entity.Property(e => e.KonNavn).HasMaxLength(255);
            entity.Property(e => e.KonTlf).HasMaxLength(255);
            entity.Property(e => e.RekvKundeId).HasColumnName("RekvKundeID");

            entity.HasOne(d => d.RekvKunde).WithMany(p => p.TblKontaktLevs)
                .HasForeignKey(d => d.RekvKundeId)
                .HasConstraintName("tblKontaktLev${85CA209C-16CF-47A0-B2E4-C6A531620AB2}");
        });

        modelBuilder.Entity<TblKontakter>(entity =>
        {
            entity.HasKey(e => e.KontaktId).HasName("tblKontakter$PrimaryKey");

            entity.ToTable("tblKontakter");

            entity.HasIndex(e => e.KundeId, "tblKontakter$KundeID");

            entity.Property(e => e.KontaktId).HasColumnName("KontaktID");
            entity.Property(e => e.Aktiv).HasDefaultValue(false);
            entity.Property(e => e.KundeId).HasColumnName("KundeID");
            entity.Property(e => e.Mail).HasMaxLength(60);
            entity.Property(e => e.Navn).HasMaxLength(60);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Tlf).HasMaxLength(20);

            entity.HasOne(d => d.Kunde).WithMany(p => p.TblKontakters)
                .HasForeignKey(d => d.KundeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblKontakter${9F82D9CC-795B-4B1A-9491-1490FF29458F}");
        });

        modelBuilder.Entity<TblKundeDatum>(entity =>
        {
            entity.HasKey(e => e.DataId).HasName("tblKundeData$PrimaryKey");

            entity.ToTable("tblKundeData");

            entity.HasIndex(e => e.BetalingsTid, "tblKundeData$BetalingsTid");

            entity.HasIndex(e => e.KundeId, "tblKundeData$KundeID");

            entity.HasIndex(e => e.LeveringsTid, "tblKundeData$LeveringsTid");

            entity.Property(e => e.DataId).HasColumnName("DataID");
            entity.Property(e => e.BetalingsTid)
                .HasMaxLength(255)
                .HasComment("Dage");
            entity.Property(e => e.IndstillingNavn).HasMaxLength(64);
            entity.Property(e => e.KundeId)
                .HasDefaultValue(0)
                .HasColumnName("KundeID");
            entity.Property(e => e.LeveringsBetingelser).HasMaxLength(32);
            entity.Property(e => e.LeveringsTid)
                .HasMaxLength(255)
                .HasComment("Dage");
            entity.Property(e => e.OfBehRustfri).HasMaxLength(64);
            entity.Property(e => e.OfBehRustfriFarve).HasMaxLength(255);
            entity.Property(e => e.OfBehSort).HasMaxLength(64);
            entity.Property(e => e.OfBehSortFarve).HasMaxLength(255);
            entity.Property(e => e.PrisGyldighed).HasMaxLength(255);
            entity.Property(e => e.Sprog).HasMaxLength(16);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Kunde).WithMany(p => p.TblKundeData)
                .HasForeignKey(d => d.KundeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblKundeData${C54322BC-FD46-4F3D-A6D8-64B9D0A8DDDC}");
        });

        modelBuilder.Entity<TblKunder>(entity =>
        {
            entity.HasKey(e => e.KundeId).HasName("tblKunder$PrimaryKey");

            entity.ToTable("tblKunder");

            entity.HasIndex(e => e.FirmaKode, "tblKunder$FirmaKode").IsUnique();

            entity.Property(e => e.KundeId).HasColumnName("KundeID");
            entity.Property(e => e.Adresse).HasMaxLength(60);
            entity.Property(e => e.Aktiv).HasDefaultValue(false);
            entity.Property(e => e.DokuMail).HasMaxLength(100);
            entity.Property(e => e.DokuMailCc)
                .HasMaxLength(100)
                .HasColumnName("DokuMailCC");
            entity.Property(e => e.Firma).HasMaxLength(60);
            entity.Property(e => e.FirmaKode).HasMaxLength(5);
            entity.Property(e => e.FirmaNavn).HasMaxLength(100);
            entity.Property(e => e.Landekode).HasMaxLength(5);
            entity.Property(e => e.LevAdresse).HasMaxLength(60);
            entity.Property(e => e.LevPostnr).HasMaxLength(30);
            entity.Property(e => e.MomsKode).HasMaxLength(32);
            entity.Property(e => e.Postnr).HasMaxLength(30);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<TblLager>(entity =>
        {
            entity.HasKey(e => e.LagerId).HasName("tblLager$PrimaryKey");

            entity.ToTable("tblLager");

            entity.HasIndex(e => e.MatId, "tblLager$MatID");

            entity.Property(e => e.LagerId).HasColumnName("LagerID");
            entity.Property(e => e.Forbrugt).HasDefaultValue(false);
            entity.Property(e => e.MatId).HasColumnName("MatID");
            entity.Property(e => e.Norm).HasMaxLength(100);
            entity.Property(e => e.Optalt).HasDefaultValue(false);
            entity.Property(e => e.OptaltD).HasPrecision(0);
            entity.Property(e => e.Placering).HasMaxLength(10);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Mat).WithMany(p => p.TblLagers)
                .HasForeignKey(d => d.MatId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblLager$[D:\\første\\MaterialerBE.mdb].tblMaterialertblLager1");
        });

        modelBuilder.Entity<TblLagerOpt>(entity =>
        {
            entity.HasKey(e => e.LagerId).HasName("tblLagerOpt$PrimaryKey");

            entity.ToTable("tblLagerOpt");

            entity.HasIndex(e => e.OptId, "tblLagerOpt$LagID");

            entity.HasIndex(e => e.MatId, "tblLagerOpt$MatID");

            entity.Property(e => e.LagerId).HasColumnName("LagerID");
            entity.Property(e => e.Forbrugt).HasDefaultValue(false);
            entity.Property(e => e.MatId).HasColumnName("MatID");
            entity.Property(e => e.Norm).HasMaxLength(255);
            entity.Property(e => e.OptId).HasColumnName("OptID");
            entity.Property(e => e.Optalt).HasDefaultValue(false);
            entity.Property(e => e.OptaltD).HasPrecision(0);
            entity.Property(e => e.Placering).HasMaxLength(255);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Opt).WithMany(p => p.TblLagerOpts)
                .HasForeignKey(d => d.OptId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblLagerOpt$[D:\\første\\MaterialerBE.mdb].tblOptaellingertblLagerOpt");
        });

        modelBuilder.Entity<TblLagerOptNy>(entity =>
        {
            entity.HasKey(e => e.OptNyId).HasName("tblLagerOptNy$PrimaryKey");

            entity.ToTable("tblLagerOptNy");

            entity.HasIndex(e => e.OptId, "tblLagerOptNy$LagID");

            entity.HasIndex(e => e.LagerId, "tblLagerOptNy$LagerID");

            entity.HasIndex(e => e.MatId, "tblLagerOptNy$MatID");

            entity.Property(e => e.OptNyId).HasColumnName("OptNyID");
            entity.Property(e => e.Forbrugt).HasDefaultValue(false);
            entity.Property(e => e.LagerId).HasColumnName("LagerID");
            entity.Property(e => e.MatId).HasColumnName("MatID");
            entity.Property(e => e.Norm).HasMaxLength(255);
            entity.Property(e => e.OptId).HasColumnName("OptID");
            entity.Property(e => e.Optalt).HasDefaultValue(false);
            entity.Property(e => e.OptaltD).HasPrecision(0);
            entity.Property(e => e.Placering).HasMaxLength(10);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Mat).WithMany(p => p.TblLagerOptNies)
                .HasForeignKey(d => d.MatId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblLagerOptNy$[D:\\første\\MaterialerBE.mdb].tblMaterialertblLagerOptNy");

            entity.HasOne(d => d.Opt).WithMany(p => p.TblLagerOptNies)
                .HasForeignKey(d => d.OptId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblLagerOptNy$[D:\\første\\MaterialerBE.mdb].tblOptaellingertblLagerOptNy");
        });

        modelBuilder.Entity<TblLagerQuery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tblLager Query");

            entity.Property(e => e.LagerId).HasColumnName("LagerID");
            entity.Property(e => e.MatId).HasColumnName("MatID");
            entity.Property(e => e.Norm).HasMaxLength(100);
            entity.Property(e => e.OptaltD).HasPrecision(0);
            entity.Property(e => e.Placering).HasMaxLength(10);
        });

        modelBuilder.Entity<TblLevFirma>(entity =>
        {
            entity.HasKey(e => e.LevId).HasName("tblLevFirma$PrimaryKey");

            entity.ToTable("tblLevFirma");

            entity.HasIndex(e => e.KundeId, "tblLevFirma$KundeId");

            entity.Property(e => e.LevId).HasColumnName("LevID");
            entity.Property(e => e.KundeId).HasColumnName("KundeID");
            entity.Property(e => e.LevAdr).HasMaxLength(120);
            entity.Property(e => e.LevFirma).HasMaxLength(50);
            entity.Property(e => e.LevPostnr).HasMaxLength(120);

            entity.HasOne(d => d.Kunde).WithMany(p => p.TblLevFirmas)
                .HasForeignKey(d => d.KundeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblLevFirma${F617EB10-645C-4236-9579-D05312FBBC14}");
        });

        modelBuilder.Entity<TblLevKontakt>(entity =>
        {
            entity.HasKey(e => e.LevKonId).HasName("tblLevKontakt$PrimaryKey");

            entity.ToTable("tblLevKontakt");

            entity.HasIndex(e => e.LevId, "tblLevKontakt$LevId");

            entity.Property(e => e.LevKonId).HasColumnName("LevKonID");
            entity.Property(e => e.LevId).HasColumnName("LevID");
            entity.Property(e => e.Navn).HasMaxLength(255);

            entity.HasOne(d => d.Lev).WithMany(p => p.TblLevKontakts)
                .HasForeignKey(d => d.LevId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblLevKontakt${358B7537-7B29-4D36-AE77-64D7676A3BDD}");
        });

        modelBuilder.Entity<TblLonDatum>(entity =>
        {
            entity.HasKey(e => e.GemtId).HasName("tblLonData$PrimaryKey");

            entity.ToTable("tblLonData");

            entity.HasIndex(e => e.ArbId, "tblLonData$ArbID");

            entity.HasIndex(e => e.LonId, "tblLonData$¨LonID");

            entity.Property(e => e.GemtId).HasColumnName("GemtID");
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.LonId).HasColumnName("LonID");
            entity.Property(e => e.Ntimer).HasColumnName("NTimer");
            entity.Property(e => e.Otimer).HasColumnName("OTimer");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Ttimer).HasColumnName("TTimer");
        });

        modelBuilder.Entity<TblLonperiode>(entity =>
        {
            entity.HasKey(e => e.LonId).HasName("tblLonperiode$PrimaryKey");

            entity.ToTable("tblLonperiode");

            entity.Property(e => e.LonId).HasColumnName("LonID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<TblMatDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblMatData");

            entity.HasIndex(e => e.EmneId, "tblMatData$EmneID");

            entity.HasIndex(e => e.LinieId, "tblMatData$LinieID");

            entity.HasIndex(e => e.MatId, "tblMatData$MatID");

            entity.HasIndex(e => e.RekvId, "tblMatData$RekvID");

            entity.Property(e => e.Adw)
                .HasMaxLength(2)
                .HasColumnName("ADw");
            entity.Property(e => e.Asme)
                .HasMaxLength(2)
                .HasColumnName("ASME");
            entity.Property(e => e.Coil).HasDefaultValue(false);
            entity.Property(e => e.Dim1).HasComment("L,        , PN");
            entity.Property(e => e.Dim2).HasComment("B, Øu, DN, M");
            entity.Property(e => e.Dim3).HasComment("T, T    , Norm");
            entity.Property(e => e.EmneId)
                .HasComment("Emnetype ID")
                .HasColumnName("EmneID");
            entity.Property(e => e.En1020431)
                .HasMaxLength(2)
                .HasColumnName("EN10204_31");
            entity.Property(e => e.En1020432)
                .HasMaxLength(2)
                .HasColumnName("EN10204_32");
            entity.Property(e => e.Finish).HasMaxLength(20);
            entity.Property(e => e.KinaLort).HasMaxLength(2);
            entity.Property(e => e.Length).HasComment("Længde på rør, rundstål og gevindstænger");
            entity.Property(e => e.LinieId).HasColumnName("LinieID");
            entity.Property(e => e.MatId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MatID");
            entity.Property(e => e.MatrNavn)
                .HasMaxLength(30)
                .HasComment("Alternativt materiale navn");
            entity.Property(e => e.MatrNr)
                .HasMaxLength(30)
                .HasComment("Werkstoff nummer efter EN");
            entity.Property(e => e.Nace)
                .HasMaxLength(2)
                .HasColumnName("NACE");
            entity.Property(e => e.Norm).HasMaxLength(100);
            entity.Property(e => e.Ped)
                .HasMaxLength(2)
                .HasColumnName("PED");
            entity.Property(e => e.Pris).HasComment("Pris");
            entity.Property(e => e.RekvId).HasColumnName("RekvID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .HasComment("Evt. bemærkninger");
            entity.Property(e => e.Seamless).HasDefaultValue(false);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<TblMatNavne>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tblMatNavne$PrimaryKey");

            entity.ToTable("tblMatNavne");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KgPris)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.MatrNavn).HasMaxLength(30);
            entity.Property(e => e.MatrNr).HasMaxLength(30);
        });

        modelBuilder.Entity<TblMatNorm>(entity =>
        {
            entity.HasKey(e => e.MatNormId).HasName("tblMatNorm$PrimaryKey");

            entity.ToTable("tblMatNorm");

            entity.HasIndex(e => e.MatTypeId, "tblMatNorm$MatTypeID");

            entity.Property(e => e.MatNormId).HasColumnName("MatNormID");
            entity.Property(e => e.MatNorm).HasMaxLength(32);
            entity.Property(e => e.MatTypeId)
                .HasDefaultValue(0)
                .HasColumnName("MatTypeID");
            entity.Property(e => e.MatrNr).HasMaxLength(16);
            entity.Property(e => e.Seamless).HasDefaultValue(false);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<TblMaterialer>(entity =>
        {
            entity.HasKey(e => e.MatId).HasName("tblMaterialer$PrimaryKey");

            entity.ToTable("tblMaterialer");

            entity.HasIndex(e => e.ChargeId, "tblMaterialer$ChargeID");

            entity.HasIndex(e => e.EmneId, "tblMaterialer$EmneID");

            entity.HasIndex(e => e.LinieId, "tblMaterialer$LinieID");

            entity.HasIndex(e => e.RekvId, "tblMaterialer$RekvID");

            entity.HasIndex(e => e.Stnr, "tblMaterialer$ST_ID");

            entity.Property(e => e.MatId).HasColumnName("MatID");
            entity.Property(e => e.Adw)
                .HasMaxLength(2)
                .HasColumnName("ADw");
            entity.Property(e => e.Asme)
                .HasMaxLength(2)
                .HasColumnName("ASME");
            entity.Property(e => e.CertLink)
                .HasMaxLength(255)
                .HasComment("Link til certifikaterne");
            entity.Property(e => e.ChargeId).HasColumnName("ChargeID");
            entity.Property(e => e.ChargeNr)
                .HasMaxLength(30)
                .HasComment("Certifikat chargenr");
            entity.Property(e => e.ChargeNrModtaget).HasMaxLength(30);
            entity.Property(e => e.Coil).HasDefaultValue(false);
            entity.Property(e => e.Dato)
                .HasPrecision(0)
                .HasComment("Materiale oprettet d.");
            entity.Property(e => e.Dim1).HasComment("L,        , PN");
            entity.Property(e => e.Dim2).HasComment("B, Øu, DN, M");
            entity.Property(e => e.Dim3).HasComment("T, T    , Norm");
            entity.Property(e => e.EmneId)
                .HasComment("Emnetype ID")
                .HasColumnName("EmneID");
            entity.Property(e => e.En1020431)
                .HasMaxLength(2)
                .HasColumnName("EN10204_31");
            entity.Property(e => e.En1020432)
                .HasMaxLength(2)
                .HasColumnName("EN10204_32");
            entity.Property(e => e.FolgeLink)
                .HasMaxLength(255)
                .HasComment("Link til følgesedler");
            entity.Property(e => e.KinaLort).HasMaxLength(2);
            entity.Property(e => e.Length).HasComment("Længde på rør, rundstål og gevindstænger");
            entity.Property(e => e.LinieId).HasColumnName("LinieID");
            entity.Property(e => e.MatStatus).HasComment("1, alt er forbrugt");
            entity.Property(e => e.MatrNavn)
                .HasMaxLength(30)
                .HasComment("Alternativt materiale navn");
            entity.Property(e => e.MatrNr)
                .HasMaxLength(30)
                .HasComment("Werkstoff nummer efter EN");
            entity.Property(e => e.Nace)
                .HasMaxLength(2)
                .HasColumnName("NACE");
            entity.Property(e => e.Norm).HasMaxLength(100);
            entity.Property(e => e.Ped)
                .HasMaxLength(2)
                .HasColumnName("PED");
            entity.Property(e => e.Placering).HasMaxLength(10);
            entity.Property(e => e.Pris).HasComment("Pris");
            entity.Property(e => e.RekvId).HasColumnName("RekvID");
            entity.Property(e => e.RekvNr)
                .HasMaxLength(20)
                .HasComment("Rekvisitionsnummer");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .HasComment("Evt. bemærkninger");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Stnr)
                .HasMaxLength(20)
                .HasComment("Intern chargenr")
                .HasColumnName("STnr");
            entity.Property(e => e.Stnum).HasColumnName("STnum");
        });

        modelBuilder.Entity<TblMatriceHoveder>(entity =>
        {
            entity.HasKey(e => e.HovedId).HasName("tblMatriceHoveder$PrimaryKey");

            entity.ToTable("tblMatriceHoveder");

            entity.Property(e => e.HovedId).HasColumnName("HovedID");
            entity.Property(e => e.Navn).HasMaxLength(30);
        });

        modelBuilder.Entity<TblMatricerTilPunch>(entity =>
        {
            entity.HasKey(e => e.MatriceId).HasName("tblMatricerTilPunch$PrimaryKey");

            entity.ToTable("tblMatricerTilPunch");

            entity.HasIndex(e => e.HovedId, "tblMatricerTilPunch$HovedID");

            entity.Property(e => e.MatriceId).HasColumnName("MatriceID");
            entity.Property(e => e.Dn).HasColumnName("DN");
            entity.Property(e => e.HovedId).HasColumnName("HovedID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Hoved).WithMany(p => p.TblMatricerTilPunches)
                .HasForeignKey(d => d.HovedId)
                .HasConstraintName("tblMatricerTilPunch$tblMatriceHovedertblMatricerTilPunch");
        });

        modelBuilder.Entity<TblNcr>(entity =>
        {
            entity.HasKey(e => e.Ncrid).HasName("tblNCR$PrimaryKey");

            entity.ToTable("tblNCR");

            entity.HasIndex(e => e.KundeId, "tblNCR$KundeID");

            entity.HasIndex(e => e.KundeNcrid, "tblNCR$KundeNCRID");

            entity.HasIndex(e => e.SupplierId, "tblNCR$SupplierID");

            entity.Property(e => e.Ncrid).HasColumnName("NCRID");
            entity.Property(e => e.Ansvarlig).HasMaxLength(255);
            entity.Property(e => e.CauseNc).HasColumnName("CauseNC");
            entity.Property(e => e.ClosedBy).HasMaxLength(255);
            entity.Property(e => e.Cost)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Dclosed)
                .HasPrecision(0)
                .HasColumnName("DClosed");
            entity.Property(e => e.Dcreated)
                .HasPrecision(0)
                .HasColumnName("DCreated");
            entity.Property(e => e.DescriptionNc).HasColumnName("DescriptionNC");
            entity.Property(e => e.EndUser).HasMaxLength(255);
            entity.Property(e => e.FailCode).HasMaxLength(255);
            entity.Property(e => e.FailCodeId)
                .HasDefaultValue(0)
                .HasColumnName("FailCodeID");
            entity.Property(e => e.HandCode).HasMaxLength(30);
            entity.Property(e => e.HandCodeDesc).HasMaxLength(255);
            entity.Property(e => e.HandCodeId)
                .HasDefaultValue(0)
                .HasColumnName("HandCodeID");
            entity.Property(e => e.HandlingNc).HasColumnName("HandlingNC");
            entity.Property(e => e.Hours).HasDefaultValue(0f);
            entity.Property(e => e.Intern).HasDefaultValue(false);
            entity.Property(e => e.Kunde).HasMaxLength(255);
            entity.Property(e => e.KundeContact).HasMaxLength(255);
            entity.Property(e => e.KundeId)
                .HasDefaultValue(0)
                .HasColumnName("KundeID");
            entity.Property(e => e.KundeKlage).HasDefaultValue(false);
            entity.Property(e => e.KundeMail).HasMaxLength(255);
            entity.Property(e => e.KundeNcrid)
                .HasMaxLength(255)
                .HasColumnName("KundeNCRID");
            entity.Property(e => e.KundePhone).HasMaxLength(255);
            entity.Property(e => e.KundePono)
                .HasMaxLength(255)
                .HasColumnName("KundePOno");
            entity.Property(e => e.Levering).HasDefaultValue(false);
            entity.Property(e => e.Ncrname)
                .HasMaxLength(255)
                .HasColumnName("NCRName");
            entity.Property(e => e.OurJopNumber).HasMaxLength(255);
            entity.Property(e => e.OurPonumber)
                .HasMaxLength(255)
                .HasColumnName("OurPONumber");
            entity.Property(e => e.Product).HasMaxLength(255);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Supplier).HasMaxLength(255);
            entity.Property(e => e.SupplierContact).HasMaxLength(255);
            entity.Property(e => e.SupplierId)
                .HasDefaultValue(0)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierMail).HasMaxLength(255);
        });

        modelBuilder.Entity<TblNcrfailCode>(entity =>
        {
            entity.HasKey(e => e.FailCodeId).HasName("tblNCRFailCode$PrimaryKey");

            entity.ToTable("tblNCRFailCode");

            entity.Property(e => e.FailCodeId).HasColumnName("FailCodeID");
            entity.Property(e => e.FailCode).HasMaxLength(255);
        });

        modelBuilder.Entity<TblNcrfailCode1>(entity =>
        {
            entity.HasKey(e => e.NcrfailCodeId).HasName("tblNCRFailCodes$PrimaryKey");

            entity.ToTable("tblNCRFailCodes");

            entity.HasIndex(e => e.FailCodeId, "tblNCRFailCodes$FailCodeId");

            entity.HasIndex(e => e.Ncrid, "tblNCRFailCodes$NacrID");

            entity.Property(e => e.NcrfailCodeId).HasColumnName("NCRFailCodeID");
            entity.Property(e => e.FailCode).HasMaxLength(255);
            entity.Property(e => e.FailCodeId).HasDefaultValue(0);
            entity.Property(e => e.Ncrid)
                .HasDefaultValue(0)
                .HasColumnName("NCRID");

            entity.HasOne(d => d.FailCodeNavigation).WithMany(p => p.TblNcrfailCode1s)
                .HasForeignKey(d => d.FailCodeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblNCRFailCodes$tblNCRFailCodetblNCRFailCodes");
        });

        modelBuilder.Entity<TblNcrhandCode>(entity =>
        {
            entity.HasKey(e => e.HandCodeId).HasName("tblNCRHandCode$PrimaryKey");

            entity.ToTable("tblNCRHandCode");

            entity.Property(e => e.HandCodeId).HasColumnName("HandCodeID");
            entity.Property(e => e.HandCode).HasMaxLength(255);
            entity.Property(e => e.HandCodeDesc).HasMaxLength(255);
        });

        modelBuilder.Entity<TblObgFradrag>(entity =>
        {
            entity.HasKey(e => e.OfraId).HasName("tblObgFradrag$PrimaryKey");

            entity.ToTable("tblObgFradrag");

            entity.Property(e => e.OfraId).HasColumnName("OFraID");
            entity.Property(e => e.OfraNavn)
                .HasMaxLength(255)
                .HasColumnName("OFraNavn");
            entity.Property(e => e.OfraVal).HasColumnName("OFraVal");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<TblObgTillaeg>(entity =>
        {
            entity.HasKey(e => e.OtilId).HasName("tblObgTillaeg$PrimaryKey");

            entity.ToTable("tblObgTillaeg");

            entity.Property(e => e.OtilId).HasColumnName("OTilID");
            entity.Property(e => e.OtilNavn)
                .HasMaxLength(255)
                .HasColumnName("OTilNavn");
            entity.Property(e => e.OtilVal).HasColumnName("OTilVal");
        });

        modelBuilder.Entity<TblOmstempling>(entity =>
        {
            entity.HasKey(e => e.StpId).HasName("tblOmstempling$PrimaryKey");

            entity.ToTable("tblOmstempling");

            entity.HasIndex(e => e.PosRevId, "tblOmstempling$PosRevID");

            entity.Property(e => e.StpId)
                .HasComment("StpID")
                .HasColumnName("StpID");
            entity.Property(e => e.FAntal)
                .HasMaxLength(255)
                .HasColumnName("fAntal");
            entity.Property(e => e.FDim1)
                .HasMaxLength(255)
                .HasColumnName("fDim1");
            entity.Property(e => e.NCharge)
                .HasMaxLength(255)
                .HasComment("Charge omstemplet")
                .HasColumnName("nCharge");
            entity.Property(e => e.NMatr)
                .HasMaxLength(255)
                .HasComment("Materiale omstemplet")
                .HasColumnName("nMatr");
            entity.Property(e => e.NStnr)
                .HasMaxLength(255)
                .HasComment("ST-nr omstemplet")
                .HasColumnName("nSTnr");
            entity.Property(e => e.NStp)
                .HasMaxLength(255)
                .HasComment("Omstemplingsmærke")
                .HasColumnName("nStp");
            entity.Property(e => e.PosRevId)
                .HasComment("PosRevID")
                .HasColumnName("PosRevID");
            entity.Property(e => e.UCharge)
                .HasMaxLength(255)
                .HasComment("Charge oprindeligt")
                .HasColumnName("uCharge");
            entity.Property(e => e.UDesc)
                .HasMaxLength(255)
                .HasComment("Beskrivelse af item")
                .HasColumnName("uDesc");
            entity.Property(e => e.UItem)
                .HasMaxLength(255)
                .HasComment("Stykliste item nummer")
                .HasColumnName("uItem");
            entity.Property(e => e.UMatr)
                .HasMaxLength(255)
                .HasComment("Materiale oprindeligt")
                .HasColumnName("uMatr");
        });

        modelBuilder.Entity<TblOmstpGenerelt>(entity =>
        {
            entity.HasKey(e => e.PosRevId).HasName("tblOmstpGenerelt$PrimaryKey");

            entity.ToTable("tblOmstpGenerelt");

            entity.Property(e => e.PosRevId)
                .ValueGeneratedNever()
                .HasComment("PosRevID")
                .HasColumnName("PosRevID");
            entity.Property(e => e.DateFixed).HasPrecision(0);
            entity.Property(e => e.Dn)
                .HasMaxLength(255)
                .HasComment("DN")
                .HasColumnName("DN");
            entity.Property(e => e.DokuVer)
                .HasMaxLength(255)
                .HasComment("Dokument version");
            entity.Property(e => e.Kunde)
                .HasMaxLength(255)
                .HasComment("Kunde firma");
            entity.Property(e => e.OrdreNr)
                .HasMaxLength(255)
                .HasComment("Kundens ordrenummer");
            entity.Property(e => e.PosNr)
                .HasMaxLength(255)
                .HasComment("Positionummer");
            entity.Property(e => e.RevNr)
                .HasMaxLength(255)
                .HasComment("Revisionsnummer");
            entity.Property(e => e.SerieNr)
                .HasMaxLength(255)
                .HasComment("Serie nummer");
            entity.Property(e => e.Sign)
                .HasMaxLength(255)
                .HasComment("Underskrift omstemplingsansvarlig");
            entity.Property(e => e.TegningNr)
                .HasMaxLength(255)
                .HasComment("Tegningsnummer");
            entity.Property(e => e.TilbudsNr)
                .HasMaxLength(255)
                .HasComment("Intern jobnummer");
            entity.Property(e => e.TypeNr)
                .HasMaxLength(255)
                .HasComment("Kompensator typenr");
        });

        modelBuilder.Entity<TblOmstpLinie>(entity =>
        {
            entity.HasKey(e => e.StpId).HasName("tblOmstpLinie$PrimaryKey");

            entity.ToTable("tblOmstpLinie");

            entity.HasIndex(e => e.PosRevId, "tblOmstpLinie$PosRevID");

            entity.Property(e => e.StpId)
                .HasComment("StpID")
                .HasColumnName("StpID");
            entity.Property(e => e.FAntal)
                .HasMaxLength(255)
                .HasColumnName("fAntal");
            entity.Property(e => e.FDim1)
                .HasMaxLength(255)
                .HasColumnName("fDim1");
            entity.Property(e => e.NCharge)
                .HasMaxLength(255)
                .HasComment("Charge omstemplet")
                .HasColumnName("nCharge");
            entity.Property(e => e.NMatr)
                .HasMaxLength(255)
                .HasComment("Materiale omstemplet")
                .HasColumnName("nMatr");
            entity.Property(e => e.NStnr)
                .HasMaxLength(255)
                .HasComment("ST-nr omstemplet")
                .HasColumnName("nSTnr");
            entity.Property(e => e.NStp)
                .HasMaxLength(255)
                .HasComment("Omstemplingsmærke")
                .HasColumnName("nStp");
            entity.Property(e => e.PosRevId)
                .HasComment("PosRevID")
                .HasColumnName("PosRevID");
            entity.Property(e => e.UCharge)
                .HasMaxLength(255)
                .HasComment("Charge oprindeligt")
                .HasColumnName("uCharge");
            entity.Property(e => e.UDesc)
                .HasMaxLength(255)
                .HasComment("Beskrivelse af item")
                .HasColumnName("uDesc");
            entity.Property(e => e.UItem)
                .HasMaxLength(255)
                .HasComment("Stykliste item nummer")
                .HasColumnName("uItem");
            entity.Property(e => e.UMatr)
                .HasMaxLength(255)
                .HasComment("Materiale oprindeligt")
                .HasColumnName("uMatr");

            entity.HasOne(d => d.PosRev).WithMany(p => p.TblOmstpLinies)
                .HasForeignKey(d => d.PosRevId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblOmstpLinie$tblOmstpGenerelttblOmstpLinie");
        });

        modelBuilder.Entity<TblOperation>(entity =>
        {
            entity.HasKey(e => e.OperationId).HasName("tblOperations$PrimaryKey");

            entity.ToTable("tblOperations");

            entity.Property(e => e.OperationId).HasColumnName("OperationID");
            entity.Property(e => e.OperationName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblOptaellinger>(entity =>
        {
            entity.HasKey(e => e.OptId).HasName("tblOptaellinger$PrimaryKey");

            entity.ToTable("tblOptaellinger");

            entity.Property(e => e.OptId).HasColumnName("OptID");
            entity.Property(e => e.OptDato).HasPrecision(0);
            entity.Property(e => e.OptNavn).HasMaxLength(30);
        });

        modelBuilder.Entity<TblOvertid>(entity =>
        {
            entity.HasKey(e => e.OvtId).HasName("tblOvertid$PrimaryKey");

            entity.ToTable("tblOvertid");

            entity.HasIndex(e => e.ArbId, "tblOvertid$ArbID");

            entity.HasIndex(e => e.LonId, "tblOvertid$LonID");

            entity.Property(e => e.OvtId).HasColumnName("OvtID");
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.LonId).HasColumnName("LonID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Arb).WithMany(p => p.TblOvertids)
                .HasForeignKey(d => d.ArbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblOvertid${E3DED719-7619-4CBD-AC41-F47E9853B26D}");

            entity.HasOne(d => d.Lon).WithMany(p => p.TblOvertids)
                .HasForeignKey(d => d.LonId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblOvertid${528F500B-43C8-42AD-B5D6-1015EFBB6936}");
        });

        modelBuilder.Entity<TblPakkeListe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPakkeListe");

            entity.Property(e => e.Dn).HasColumnName("DN");
            entity.Property(e => e.Ktype)
                .HasMaxLength(32)
                .HasColumnName("KType");
            entity.Property(e => e.PakkeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PakkeID");
            entity.Property(e => e.PosNr).HasMaxLength(8);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TilbudNr).HasMaxLength(32);
        });

        modelBuilder.Entity<TblPaller>(entity =>
        {
            entity.HasKey(e => e.PalleId).HasName("tblPaller$PrimaryKey");

            entity.ToTable("tblPaller");

            entity.HasIndex(e => e.RekvId, "tblPaller$RekvID");

            entity.Property(e => e.PalleId).HasColumnName("PalleID");
            entity.Property(e => e.PalleDesc).HasMaxLength(255);
            entity.Property(e => e.PalleKg).HasDefaultValue(0f);
            entity.Property(e => e.RekvId).HasColumnName("RekvID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Rekv).WithMany(p => p.TblPallers)
                .HasForeignKey(d => d.RekvId)
                .HasConstraintName("tblPaller${D94F89A8-FA09-489B-A2D6-81DACEF1CC02}");
        });

        modelBuilder.Entity<TblPenetrantVisuel>(entity =>
        {
            entity.HasKey(e => e.Ptvtid).HasName("tblPenetrantVisuel$PrimaryKey");

            entity.ToTable("tblPenetrantVisuel");

            entity.HasIndex(e => e.TechnicianIdVt, "tblPenetrantVisuel$TechnicianID");

            entity.Property(e => e.Ptvtid).HasColumnName("PTVTID");
            entity.Property(e => e.Cleaning).HasMaxLength(20);
            entity.Property(e => e.DateFixed).HasPrecision(0);
            entity.Property(e => e.ObjectTemperature).HasMaxLength(20);
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.PreCleaning).HasMaxLength(20);
            entity.Property(e => e.PtAccepted)
                .HasMaxLength(50)
                .HasColumnName("PT_Accepted");
            entity.Property(e => e.PtDeveloper)
                .HasMaxLength(20)
                .HasColumnName("PT_developer");
            entity.Property(e => e.PtDeveloptime)
                .HasMaxLength(20)
                .HasColumnName("PT_developtime");
            entity.Property(e => e.PtExtent1)
                .HasMaxLength(255)
                .HasColumnName("PT_Extent_1");
            entity.Property(e => e.PtExtent2)
                .HasMaxLength(255)
                .HasColumnName("PT_Extent_2");
            entity.Property(e => e.PtExtent3)
                .HasMaxLength(255)
                .HasColumnName("PT_Extent_3");
            entity.Property(e => e.PtProcedure)
                .HasMaxLength(30)
                .HasColumnName("PT_procedure");
            entity.Property(e => e.PtQreg)
                .HasMaxLength(30)
                .HasColumnName("PT_Qreg");
            entity.Property(e => e.PtRemover)
                .HasMaxLength(20)
                .HasColumnName("PT_remover");
            entity.Property(e => e.PtSystem)
                .HasMaxLength(20)
                .HasColumnName("PT_system");
            entity.Property(e => e.PtTime)
                .HasMaxLength(20)
                .HasColumnName("PT_time");
            entity.Property(e => e.PtType)
                .HasMaxLength(20)
                .HasColumnName("PT_type");
            entity.Property(e => e.Ptrpt)
                .HasDefaultValue(false)
                .HasColumnName("PTrpt");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.SurfaceCondition).HasMaxLength(20);
            entity.Property(e => e.TechnicianIdPt)
                .HasMaxLength(20)
                .HasColumnName("TechnicianID_PT");
            entity.Property(e => e.TechnicianIdVt)
                .HasMaxLength(20)
                .HasColumnName("TechnicianID_VT");
            entity.Property(e => e.TechnicianName).HasMaxLength(100);
            entity.Property(e => e.ViewingConditions).HasMaxLength(30);
            entity.Property(e => e.VtAccepted)
                .HasMaxLength(50)
                .HasColumnName("VT_Accepted");
            entity.Property(e => e.VtExtent1)
                .HasMaxLength(255)
                .HasColumnName("VT_Extent_1");
            entity.Property(e => e.VtProcedure)
                .HasMaxLength(30)
                .HasColumnName("VT_procedure");
            entity.Property(e => e.VtQlevel)
                .HasMaxLength(20)
                .HasColumnName("VT_Qlevel");
            entity.Property(e => e.VtQreg)
                .HasMaxLength(30)
                .HasColumnName("VT_Qreg");
            entity.Property(e => e.Vtrpt)
                .HasDefaultValue(false)
                .HasColumnName("VTrpt");
        });

        modelBuilder.Entity<TblPlanAktivitet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tblPlanAktivitet$PrimaryKey");

            entity.ToTable("tblPlanAktivitet");

            entity.HasIndex(e => e.PosRevId, "tblPlanAktivitet$PosRevID");

            entity.HasIndex(e => e.TilbudId, "tblPlanAktivitet$TilbudID");

            entity.Property(e => e.PosRevId)
                .HasDefaultValue(0)
                .HasColumnName("PosRevID");
            entity.Property(e => e.TilbudId)
                .HasDefaultValue(0)
                .HasColumnName("TilbudID");
        });

        modelBuilder.Entity<TblPlanPo>(entity =>
        {
            entity.HasKey(e => e.PlanPosId).HasName("tblPlanPos$PrimaryKey");

            entity.ToTable("tblPlanPos");

            entity.HasIndex(e => e.OperationId, "tblPlanPos$OperationID");

            entity.HasIndex(e => e.PosRevId, "tblPlanPos$PosRevID");

            entity.Property(e => e.PlanPosId).HasColumnName("PlanPosID");
            entity.Property(e => e.LeadDage).HasDefaultValue(0);
            entity.Property(e => e.LeadStart).HasDefaultValue(0);
            entity.Property(e => e.OperationId)
                .HasDefaultValue(0)
                .HasColumnName("OperationID");
            entity.Property(e => e.PlanTimer).HasDefaultValue(0f);
            entity.Property(e => e.PosRevId)
                .HasDefaultValue(0)
                .HasColumnName("PosRevID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.PosRev).WithMany(p => p.TblPlanPos)
                .HasForeignKey(d => d.PosRevId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblPlanPos$tblPositionertblPlanPos");
        });

        modelBuilder.Entity<TblPlanProd>(entity =>
        {
            entity.HasKey(e => e.PlanProdId).HasName("tblPlanProd$PrimaryKey");

            entity.ToTable("tblPlanProd");

            entity.HasIndex(e => e.RekvId, "tblPlanProd$RekvID");

            entity.HasIndex(e => e.TilbudId, "tblPlanProd$TilbudID");

            entity.Property(e => e.PlanProdId).HasColumnName("PlanProdID");
            entity.Property(e => e.Afsluttet).HasDefaultValue(false);
            entity.Property(e => e.AfsluttetD).HasPrecision(0);
            entity.Property(e => e.BalgKlar).HasDefaultValue(false);
            entity.Property(e => e.BalgSlutD).HasPrecision(0);
            entity.Property(e => e.BalgStartD).HasPrecision(0);
            entity.Property(e => e.BalgTimer).HasDefaultValue(0f);
            entity.Property(e => e.BalgTimerBrugt)
                .HasDefaultValue(0f)
                .HasColumnName("BalgTimerBRugt");
            entity.Property(e => e.BalgrumKlar).HasDefaultValue(false);
            entity.Property(e => e.BeregnetLeadTime).HasDefaultValue(0);
            entity.Property(e => e.FakturaAmount).HasDefaultValue(0.0);
            entity.Property(e => e.FakturaEndDate).HasPrecision(0);
            entity.Property(e => e.Faktureret).HasDefaultValue(false);
            entity.Property(e => e.Godkendt).HasDefaultValue(false);
            entity.Property(e => e.Hal1Klar).HasDefaultValue(false);
            entity.Property(e => e.Hal1SlutD).HasPrecision(0);
            entity.Property(e => e.Hal1StartD).HasPrecision(0);
            entity.Property(e => e.Hal1Timer).HasDefaultValue(0f);
            entity.Property(e => e.Hal1TimerBrugt).HasDefaultValue(0f);
            entity.Property(e => e.Hal2Klar).HasDefaultValue(false);
            entity.Property(e => e.Hal2SlutD).HasPrecision(0);
            entity.Property(e => e.Hal2StartD).HasPrecision(0);
            entity.Property(e => e.Hal2Timer).HasDefaultValue(0f);
            entity.Property(e => e.Hal2TimerBrugt).HasDefaultValue(0f);
            entity.Property(e => e.HalvFabKlar).HasDefaultValue(false);
            entity.Property(e => e.HalvFabStartD).HasPrecision(0);
            entity.Property(e => e.HalvFabTimer).HasDefaultValue(0f);
            entity.Property(e => e.HalvFabTimerBrugt).HasDefaultValue(0f);
            entity.Property(e => e.HalvfabSlutD).HasPrecision(0);
            entity.Property(e => e.HydroKlar).HasDefaultValue(false);
            entity.Property(e => e.HydroSlutD).HasPrecision(0);
            entity.Property(e => e.HydroStartD).HasPrecision(0);
            entity.Property(e => e.HydroTimer).HasDefaultValue(0f);
            entity.Property(e => e.HydroTimerBrugt).HasDefaultValue(0f);
            entity.Property(e => e.JoblisterOk)
                .HasDefaultValue(false)
                .HasColumnName("JoblisterOK");
            entity.Property(e => e.LevDato).HasPrecision(0);
            entity.Property(e => e.LevNo).HasDefaultValue(0);
            entity.Property(e => e.LevUgeDag).HasMaxLength(8);
            entity.Property(e => e.PlanProdStatus).HasDefaultValue(0);
            entity.Property(e => e.ProdStartDato).HasPrecision(0);
            entity.Property(e => e.RekvId)
                .HasDefaultValue(0)
                .HasColumnName("RekvID");
            entity.Property(e => e.RustTimerSum).HasDefaultValue(0f);
            entity.Property(e => e.SortKlar).HasDefaultValue(false);
            entity.Property(e => e.SortTimerSum).HasDefaultValue(0f);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TilbudId)
                .HasDefaultValue(0)
                .HasColumnName("TilbudID");
        });

        modelBuilder.Entity<TblPlanProdLinie>(entity =>
        {
            entity.HasKey(e => e.PlanLinieId).HasName("tblPlanProdLinie$PrimaryKey");

            entity.ToTable("tblPlanProdLinie");

            entity.HasIndex(e => e.PlanProdId, "tblPlanProdLinie$PlanProdID");

            entity.HasIndex(e => e.PosRevId, "tblPlanProdLinie$PosRevID");

            entity.Property(e => e.PlanLinieId).HasColumnName("PlanLinieID");
            entity.Property(e => e.AntalProd).HasDefaultValue(0);
            entity.Property(e => e.PlanProdId).HasColumnName("PlanProdID");
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");

            entity.HasOne(d => d.PlanProd).WithMany(p => p.TblPlanProdLinies)
                .HasForeignKey(d => d.PlanProdId)
                .HasConstraintName("tblPlanProdLinie$[D:\\første\\MaterialerBE.mdb].{965E620F-9693-4296-84E5-A5FDE0B38433}");
        });

        modelBuilder.Entity<TblPositioner>(entity =>
        {
            entity.HasKey(e => e.PosRevId).HasName("tblPositioner$PrimaryKey");

            entity.ToTable("tblPositioner");

            entity.HasIndex(e => e.ProdId, "tblPositioner$ProdID");

            entity.HasIndex(e => new { e.TilbudId, e.PosNr, e.RevNr }, "tblPositioner$TilbudPosRev").IsUnique();

            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.AfsluttetD).HasPrecision(0);
            entity.Property(e => e.AfsluttetDato).HasPrecision(0);
            entity.Property(e => e.AntalDelLev).HasDefaultValue(0);
            entity.Property(e => e.CurrentRev).HasDefaultValue(0);
            entity.Property(e => e.Dn).HasColumnName("DN");
            entity.Property(e => e.Faktureret).HasDefaultValue(0.0);
            entity.Property(e => e.Iprod).HasColumnName("IProd");
            entity.Property(e => e.IsCurrent).HasDefaultValue(0);
            entity.Property(e => e.ItemNr).HasMaxLength(100);
            entity.Property(e => e.Ktype)
                .HasMaxLength(60)
                .HasColumnName("KType");
            entity.Property(e => e.NFaktura).HasColumnName("nFaktura");
            entity.Property(e => e.NProduktion).HasColumnName("nProduktion");
            entity.Property(e => e.NTransport).HasColumnName("nTransport");
            entity.Property(e => e.OrdreDato).HasPrecision(0);
            entity.Property(e => e.PlanTidHalvfab).HasDefaultValue(0f);
            entity.Property(e => e.PlanTidRust).HasDefaultValue(0f);
            entity.Property(e => e.PlanTidSort).HasDefaultValue(0f);
            entity.Property(e => e.Planlagt).HasDefaultValue(false);
            entity.Property(e => e.Pris).HasColumnType("money");
            entity.Property(e => e.PrisIvaluta)
                .HasColumnType("money")
                .HasColumnName("PrisIValuta");
            entity.Property(e => e.PrisTotal).HasColumnType("money");
            entity.Property(e => e.ProdId)
                .HasDefaultValue(0)
                .HasColumnName("ProdID");
            entity.Property(e => e.RevDato).HasPrecision(0);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TilbudId).HasColumnName("TilbudID");
            entity.Property(e => e.Transportdag).HasMaxLength(10);
            entity.Property(e => e.Valuta).HasMaxLength(5);

            entity.HasOne(d => d.Tilbud).WithMany(p => p.TblPositioners)
                .HasForeignKey(d => d.TilbudId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblPositioner$[D:\\første\\ShapeTech.mdb].{B6E0D3FE-CB71-4F33-ACC7-C3E82742AF17}");
        });

        modelBuilder.Entity<TblPressuretest>(entity =>
        {
            entity.HasKey(e => e.Pt20id).HasName("tblPressuretest$PrimaryKey");

            entity.ToTable("tblPressuretest");

            entity.HasIndex(e => e.HoldeTid, "tblPressuretest$HoldeTid");

            entity.HasIndex(e => e.PosRevId, "tblPressuretest$PosRevId");

            entity.Property(e => e.Pt20id).HasColumnName("PT20ID");
            entity.Property(e => e.Accepted).HasMaxLength(255);
            entity.Property(e => e.AcceptedLt)
                .HasMaxLength(255)
                .HasColumnName("Accepted_LT");
            entity.Property(e => e.DateFixed).HasPrecision(0);
            entity.Property(e => e.HoldeTid).HasMaxLength(255);
            entity.Property(e => e.HoldeTidLt)
                .HasMaxLength(255)
                .HasColumnName("HoldeTid_LT");
            entity.Property(e => e.Lt20)
                .HasDefaultValue(false)
                .HasColumnName("LT20");
            entity.Property(e => e.ManoMeter).HasMaxLength(255);
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.Pt20)
                .HasDefaultValue(false)
                .HasColumnName("PT20");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TestMedia).HasMaxLength(255);
            entity.Property(e => e.TestPressure).HasMaxLength(255);
            entity.Property(e => e.TestPressureLt)
                .HasMaxLength(255)
                .HasColumnName("TestPressure_LT");
        });

        modelBuilder.Entity<TblRekvTransport>(entity =>
        {
            entity.HasKey(e => e.RekvTranId).HasName("tblRekvTransport$PrimaryKey");

            entity.ToTable("tblRekvTransport");

            entity.HasIndex(e => e.PosRevId, "tblRekvTransport$PosRevID");

            entity.HasIndex(e => e.RekvId, "tblRekvTransport$RekvID");

            entity.Property(e => e.RekvTranId).HasColumnName("RekvTranID");
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.RekvId).HasColumnName("RekvID");

            entity.HasOne(d => d.PosRev).WithMany(p => p.TblRekvTransports)
                .HasForeignKey(d => d.PosRevId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblRekvTransport$[D:\\første\\ShapeTech.mdb].{9AA91A2E-8DAC-4BF2-90D7-86F29BBA814F}");
        });

        modelBuilder.Entity<TblRingeTilBalge>(entity =>
        {
            entity.HasKey(e => e.RingId).HasName("tblRingeTilBalge$PrimaryKey");

            entity.ToTable("tblRingeTilBalge");

            entity.Property(e => e.RingId).HasColumnName("RingID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<TblRingeTilLederor>(entity =>
        {
            entity.HasKey(e => e.RingId).HasName("tblRingeTilLederor$PrimaryKey");

            entity.ToTable("tblRingeTilLederor");

            entity.Property(e => e.RingId).HasColumnName("RingID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<TblStykliste>(entity =>
        {
            entity.HasKey(e => e.StkId).HasName("tblStykliste$PrimaryKey");

            entity.ToTable("tblStykliste");

            entity.HasIndex(e => e.KildeId, "tblStykliste$KildeID");

            entity.HasIndex(e => e.PosRevId, "tblStykliste$PosRevID");

            entity.Property(e => e.StkId).HasColumnName("StkID");
            entity.Property(e => e.Cert).HasMaxLength(100);
            entity.Property(e => e.ChargeNr).HasMaxLength(20);
            entity.Property(e => e.Desc).HasMaxLength(50);
            entity.Property(e => e.Dimension).HasMaxLength(50);
            entity.Property(e => e.ItemPos).HasMaxLength(5);
            entity.Property(e => e.KildeId).HasColumnName("KildeID");
            entity.Property(e => e.Matr).HasMaxLength(20);
            entity.Property(e => e.NdtE)
                .HasMaxLength(5)
                .HasColumnName("NDT_E");
            entity.Property(e => e.NdtI)
                .HasMaxLength(5)
                .HasColumnName("NDT_I");
            entity.Property(e => e.NdtQ)
                .HasMaxLength(5)
                .HasColumnName("NDT_Q");
            entity.Property(e => e.OfBeh).HasMaxLength(100);
            entity.Property(e => e.Omstempling).HasMaxLength(5);
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.PosRev).WithMany(p => p.TblStyklistes)
                .HasForeignKey(d => d.PosRevId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblStykliste$[D:\\første\\ShapeTech.mdb].{970294DF-09FE-4586-8754-64292B4590E4}");
        });

        modelBuilder.Entity<TblTiderEnkelt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tblTiderEnkelt");

            entity.Property(e => e.Iprod).HasColumnName("IProd");
            entity.Property(e => e.TilbudId).HasColumnName("TilbudID");
            entity.Property(e => e.TilbudNr).HasMaxLength(20);
        });

        modelBuilder.Entity<TblTiderSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tblTiderSum");

            entity.Property(e => e.SumOfTidBalg).HasColumnName("Sum Of TidBalg");
            entity.Property(e => e.SumOfTidSort).HasColumnName("Sum Of TidSort");
            entity.Property(e => e.TilbudId).HasColumnName("TilbudID");
            entity.Property(e => e.TilbudNr).HasMaxLength(20);
        });

        modelBuilder.Entity<TblTidsreg>(entity =>
        {
            entity.HasKey(e => e.RegId).HasName("tblTidsreg$PrimaryKey");

            entity.ToTable("tblTidsreg");

            entity.HasIndex(e => e.AfdId, "tblTidsreg$AfdID");

            entity.HasIndex(e => e.AfdNyId, "tblTidsreg$AfdNyID");

            entity.HasIndex(e => e.AltId, "tblTidsreg$AltID");

            entity.HasIndex(e => e.ArbId, "tblTidsreg$ArbID");

            entity.HasIndex(e => e.FejlId, "tblTidsreg$FejlID");

            entity.HasIndex(e => e.Ipoid, "tblTidsreg$IPOID");

            entity.HasIndex(e => e.MasId, "tblTidsreg$MasID");

            entity.HasIndex(e => e.OrdreId, "tblTidsreg$OrdreID");

            entity.Property(e => e.RegId).HasColumnName("RegID");
            entity.Property(e => e.AfdId).HasColumnName("AfdID");
            entity.Property(e => e.AfdNyId)
                .HasDefaultValue(0)
                .HasColumnName("AfdNyID");
            entity.Property(e => e.AltId).HasColumnName("AltID");
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.FejlId).HasColumnName("FejlID");
            entity.Property(e => e.Ipoid).HasColumnName("IPOID");
            entity.Property(e => e.MasId).HasColumnName("MasID");
            entity.Property(e => e.OrdreId).HasColumnName("OrdreID");
            entity.Property(e => e.OrdreNavn).HasMaxLength(255);
            entity.Property(e => e.TidInd).HasPrecision(0);
            entity.Property(e => e.TidUd).HasPrecision(0);

            entity.HasOne(d => d.Afd).WithMany(p => p.TblTidsregs)
                .HasForeignKey(d => d.AfdId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblTidsreg$[D:\\første\\TidsRegDB.mdb].{1725E740-DCA6-4233-BBDE-16BC5E09E881}");

            entity.HasOne(d => d.Alt).WithMany(p => p.TblTidsregs)
                .HasForeignKey(d => d.AltId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblTidsreg$[D:\\første\\TidsRegDB.mdb].{FF34615D-202F-445A-9047-2AFC4E8282A5}");

            entity.HasOne(d => d.Arb).WithMany(p => p.TblTidsregs)
                .HasForeignKey(d => d.ArbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblTidsreg$[D:\\første\\TidsRegDB.mdb].{651227BA-9A2B-4394-B1E6-9A09F59219F6}");

            entity.HasOne(d => d.Fejl).WithMany(p => p.TblTidsregs)
                .HasForeignKey(d => d.FejlId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblTidsreg$[D:\\første\\TidsRegDB.mdb].{3FF5E97B-9CFD-42A1-9CAD-72411E386377}");

            entity.HasOne(d => d.Ipo).WithMany(p => p.TblTidsregs)
                .HasForeignKey(d => d.Ipoid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblTidsreg$[D:\\første\\TidsRegDB.mdb].{7E0636EA-3B47-44C2-9EBC-5674DB38FB9A}");
        });

        modelBuilder.Entity<TblTilbud>(entity =>
        {
            entity.HasKey(e => e.TilbudId).HasName("tblTilbud$PrimaryKey");

            entity.ToTable("tblTilbud");

            entity.HasIndex(e => e.DesignerId, "tblTilbud$DesignerID");

            entity.HasIndex(e => e.KontaktId, "tblTilbud$KontaktID");

            entity.HasIndex(e => e.KundeId, "tblTilbud$KundeID");

            entity.HasIndex(e => e.LevId, "tblTilbud$LevID");

            entity.HasIndex(e => e.LevKonId, "tblTilbud$LevKonID");

            entity.HasIndex(e => e.SmartTid, "tblTilbud$SmartTid");

            entity.HasIndex(e => e.TilbudNr, "tblTilbud$TilbudNr").IsUnique();

            entity.HasIndex(e => e.TranId, "tblTilbud$TranID");

            entity.Property(e => e.TilbudId).HasColumnName("TilbudID");
            entity.Property(e => e.AntalPos).HasDefaultValue(0);
            entity.Property(e => e.BalgKlar).HasDefaultValue(false);
            entity.Property(e => e.BellowReady).HasMaxLength(5);
            entity.Property(e => e.BellowReadyD).HasPrecision(0);
            entity.Property(e => e.BellowStart).HasMaxLength(5);
            entity.Property(e => e.BellowStartD).HasPrecision(0);
            entity.Property(e => e.DatoOprettet).HasPrecision(0);
            entity.Property(e => e.Delevering).HasDefaultValue(false);
            entity.Property(e => e.DesignerId).HasColumnName("DesignerID");
            entity.Property(e => e.DnoteFromExternal).HasColumnName("DNoteFromExternal");
            entity.Property(e => e.EkstrasReady).HasMaxLength(5);
            entity.Property(e => e.EkstrasReadyD).HasPrecision(0);
            entity.Property(e => e.EkstrasStart).HasMaxLength(5);
            entity.Property(e => e.EkstrasStartD).HasPrecision(0);
            entity.Property(e => e.ForspNr).HasMaxLength(30);
            entity.Property(e => e.HalvfabKlar).HasDefaultValue(false);
            entity.Property(e => e.KontaktId).HasColumnName("KontaktID");
            entity.Property(e => e.KundeFakturaNr)
                .HasMaxLength(30)
                .HasComment("Ved IKKE blank betaler kunden for transporten");
            entity.Property(e => e.KundeId).HasColumnName("KundeID");
            entity.Property(e => e.LevId).HasColumnName("LevID");
            entity.Property(e => e.LevKonId).HasColumnName("LevKonID");
            entity.Property(e => e.LinkSag).HasMaxLength(255);
            entity.Property(e => e.LockedPlan).HasDefaultValue(false);
            entity.Property(e => e.OrdreNr).HasMaxLength(30);
            entity.Property(e => e.PlanKlar).HasDefaultValue(false);
            entity.Property(e => e.Planlagt).HasDefaultValue(false);
            entity.Property(e => e.PrisEkslTransport).HasComment("1 Ja");
            entity.Property(e => e.Remark).HasMaxLength(128);
            entity.Property(e => e.SagFarve).HasDefaultValue(0);
            entity.Property(e => e.SmartTid).HasDefaultValue(false);
            entity.Property(e => e.SortKlar).HasDefaultValue(false);
            entity.Property(e => e.SortTilUnderLev).HasDefaultValue(false);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TilbudNr).HasMaxLength(20);
            entity.Property(e => e.TimerForbrugBalg).HasDefaultValue(0f);
            entity.Property(e => e.TimerForbrugSort).HasDefaultValue(0f);
            entity.Property(e => e.TimerForbrugTotal).HasDefaultValue(0f);
            entity.Property(e => e.TimerRestBalg).HasDefaultValue(0f);
            entity.Property(e => e.TimerRestSort).HasDefaultValue(0f);
            entity.Property(e => e.TimerRestTotal).HasDefaultValue(0f);
            entity.Property(e => e.TranId).HasColumnName("TranID");
            entity.Property(e => e.TranRealDateRyk).HasPrecision(0);
            entity.Property(e => e.TransDato).HasMaxLength(10);
            entity.Property(e => e.TransDatoRykket).HasMaxLength(10);
            entity.Property(e => e.UnderLevNavn).HasMaxLength(32);
            entity.Property(e => e.UnderLevRekvNr).HasDefaultValue(0);
            entity.Property(e => e.Vigtig).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblTillaeg>(entity =>
        {
            entity.HasKey(e => e.TilId).HasName("tblTillaeg$PrimaryKey");

            entity.ToTable("tblTillaeg");

            entity.Property(e => e.TilId).HasColumnName("TilID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TilNavn).HasMaxLength(255);
        });

        modelBuilder.Entity<TblTillaegDatum>(entity =>
        {
            entity.HasKey(e => e.TillaegId).HasName("tblTillaegData$PrimaryKey");

            entity.ToTable("tblTillaegData");

            entity.HasIndex(e => e.ArbId, "tblTillaegData$ArbID");

            entity.HasIndex(e => e.LonId, "tblTillaegData$LonID");

            entity.HasIndex(e => e.TilId, "tblTillaegData$TilID");

            entity.Property(e => e.TillaegId).HasColumnName("TillaegID");
            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.LonId).HasColumnName("LonID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TilId).HasColumnName("TilID");

            entity.HasOne(d => d.Arb).WithMany(p => p.TblTillaegData)
                .HasForeignKey(d => d.ArbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblTillaegData${5C78B417-3512-40D1-96DC-95F1B3DE7597}");

            entity.HasOne(d => d.Lon).WithMany(p => p.TblTillaegData)
                .HasForeignKey(d => d.LonId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblTillaegData${F6A50CD7-77FD-45C9-A2DE-A9DE87D045E9}");

            entity.HasOne(d => d.Til).WithMany(p => p.TblTillaegData)
                .HasForeignKey(d => d.TilId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblTillaegData${02676D98-0CBE-48D4-8336-53C9E2EB4F09}");
        });

        modelBuilder.Entity<TblTillaegForespørgsel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tblTillaeg Forespørgsel");

            entity.Property(e => e.ArbId).HasColumnName("ArbID");
            entity.Property(e => e.TilNavn).HasMaxLength(255);
        });

        modelBuilder.Entity<TblValutum>(entity =>
        {
            entity.HasKey(e => e.ValutaId).HasName("tblValuta$PrimaryKey");

            entity.ToTable("tblValuta");

            entity.Property(e => e.ValutaId).HasColumnName("ValutaID");
            entity.Property(e => e.Valuta).HasMaxLength(255);
        });

        modelBuilder.Entity<TblVare>(entity =>
        {
            entity.HasKey(e => e.VareId).HasName("tblVare$PrimaryKey");

            entity.ToTable("tblVare");

            entity.Property(e => e.VareId).HasColumnName("VareID");
            entity.Property(e => e.Beskrivelse).HasMaxLength(255);
            entity.Property(e => e.Dn)
                .HasDefaultValue(0)
                .HasColumnName("DN");
            entity.Property(e => e.FixedFl)
                .HasDefaultValue(0f)
                .HasColumnName("FixedFL");
            entity.Property(e => e.IndreDiameter).HasDefaultValue(0f);
            entity.Property(e => e.LooseFl)
                .HasDefaultValue(0f)
                .HasColumnName("LooseFL");
            entity.Property(e => e.Pn)
                .HasDefaultValue(0)
                .HasColumnName("PN");
            entity.Property(e => e.Pris)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.YdreDiameter).HasDefaultValue(0f);
        });

        modelBuilder.Entity<TblVareEnheder>(entity =>
        {
            entity.HasKey(e => e.EnhedId).HasName("tblVareEnheder$PrimaryKey");

            entity.ToTable("tblVareEnheder");

            entity.Property(e => e.EnhedId).HasColumnName("EnhedID");
            entity.Property(e => e.EnhedKort).HasMaxLength(255);
            entity.Property(e => e.EnhedLang).HasMaxLength(255);
        });

        modelBuilder.Entity<TblVareGrupper>(entity =>
        {
            entity.HasKey(e => e.VareGrpId).HasName("tblVareGrupper$PrimaryKey");

            entity.ToTable("tblVareGrupper");

            entity.Property(e => e.VareGrpId).HasColumnName("VareGrpID");
            entity.Property(e => e.VareGrpNavn).HasMaxLength(255);
        });

        modelBuilder.Entity<TblVareKategori>(entity =>
        {
            entity.HasKey(e => e.VareKatId).HasName("tblVareKategori$PrimaryKey");

            entity.ToTable("tblVareKategori");

            entity.Property(e => e.VareKatId).HasColumnName("VareKatID");
            entity.Property(e => e.VareKatNavn).HasMaxLength(255);
        });

        modelBuilder.Entity<TblVareNumre>(entity =>
        {
            entity.HasKey(e => e.VareId).HasName("tblVareNumre$PrimaryKey");

            entity.ToTable("tblVareNumre");

            entity.HasIndex(e => e.VareKatId, "tblVareNumre$EmneID");

            entity.HasIndex(e => e.EnhedId, "tblVareNumre$EnhedID");

            entity.HasIndex(e => e.VareGrpId, "tblVareNumre$VareGrpID");

            entity.Property(e => e.VareId).HasColumnName("VareID");
            entity.Property(e => e.EnhedId).HasColumnName("EnhedID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.VareGrpId)
                .HasMaxLength(255)
                .HasColumnName("VareGrpID");
            entity.Property(e => e.VareKatId).HasColumnName("VareKatID");
            entity.Property(e => e.VareNavn).HasMaxLength(255);
            entity.Property(e => e.VareNr).HasMaxLength(255);
        });

        modelBuilder.Entity<Tblcertifikater>(entity =>
        {
            entity.HasKey(e => e.CertId).HasName("tblcertifikater$PrimaryKey");

            entity.ToTable("tblcertifikater");

            entity.HasIndex(e => e.RekvId, "tblcertifikater$LinieID");

            entity.Property(e => e.CertId).HasColumnName("CertID");
            entity.Property(e => e.Adw)
                .HasMaxLength(2)
                .HasColumnName("ADw");
            entity.Property(e => e.Asme)
                .HasMaxLength(2)
                .HasColumnName("ASME");
            entity.Property(e => e.CertPath).HasMaxLength(255);
            entity.Property(e => e.En1020431)
                .HasMaxLength(2)
                .HasColumnName("EN10204_31");
            entity.Property(e => e.En1020432)
                .HasMaxLength(2)
                .HasColumnName("EN10204_32");
            entity.Property(e => e.FromChina).HasMaxLength(2);
            entity.Property(e => e.Nace)
                .HasMaxLength(2)
                .HasColumnName("NACE");
            entity.Property(e => e.Ped)
                .HasMaxLength(2)
                .HasColumnName("PED");
            entity.Property(e => e.RekvId).HasColumnName("RekvID");

            entity.HasOne(d => d.Rekv).WithMany(p => p.Tblcertifikaters)
                .HasForeignKey(d => d.RekvId)
                .HasConstraintName("tblcertifikater$[D:\\første\\RekvTables.mdb].{64D24697-BB55-4AFD-A1BA-4E0996CC2418}");
        });

        modelBuilder.Entity<Tblforsp>(entity =>
        {
            entity.HasKey(e => e.ForspId).HasName("tblforsp$PrimaryKey");

            entity.ToTable("tblforsp");

            entity.HasIndex(e => e.KonId, "tblforsp$KonID");

            entity.HasIndex(e => e.RekvId, "tblforsp$RekvID");

            entity.HasIndex(e => e.RekvKundeId, "tblforsp$RekvKundeID");

            entity.Property(e => e.ForspId).HasColumnName("ForspID");
            entity.Property(e => e.ForspDato).HasPrecision(0);
            entity.Property(e => e.ForspNr).HasMaxLength(255);
            entity.Property(e => e.Iordre)
                .HasDefaultValue(false)
                .HasColumnName("IOrdre");
            entity.Property(e => e.KonId).HasColumnName("KonID");
            entity.Property(e => e.RekvId).HasColumnName("RekvID");
            entity.Property(e => e.RekvKundeId).HasColumnName("RekvKundeID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Rekv).WithMany(p => p.Tblforsps)
                .HasForeignKey(d => d.RekvId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblforsp${CC8C65A2-52B7-4FDF-98B7-BD6D34137C14}");
        });

        modelBuilder.Entity<Tblhoved>(entity =>
        {
            entity.HasKey(e => e.RekvId).HasName("tblhoved$PrimaryKey");

            entity.ToTable("tblhoved");

            entity.HasIndex(e => e.AfhentTid, "tblhoved$AfhentTid");

            entity.HasIndex(e => e.KonId, "tblhoved$KonID");

            entity.HasIndex(e => e.LevKundeId, "tblhoved$LevKundeID");

            entity.HasIndex(e => e.LevTid, "tblhoved$LevTid");

            entity.HasIndex(e => e.RekvKundeId, "tblhoved$RekvKundeID");

            entity.HasIndex(e => e.RekvId, "tblhoved$id");

            entity.Property(e => e.RekvId)
                .HasComment("a")
                .HasColumnName("RekvID");
            entity.Property(e => e.AfhentAdr).HasMaxLength(100);
            entity.Property(e => e.AfhentDato).HasPrecision(0);
            entity.Property(e => e.AfhentFirma).HasMaxLength(100);
            entity.Property(e => e.AfhentPostnr).HasMaxLength(100);
            entity.Property(e => e.AfhentTid).HasPrecision(0);
            entity.Property(e => e.Efterbehandling).HasDefaultValue(false);
            entity.Property(e => e.FakturaTransportModtaget).HasDefaultValue(false);
            entity.Property(e => e.KonId).HasColumnName("KonID");
            entity.Property(e => e.LevAdr).HasMaxLength(100);
            entity.Property(e => e.LevDato).HasPrecision(0);
            entity.Property(e => e.LevDatoRykket).HasPrecision(0);
            entity.Property(e => e.LevFirma).HasMaxLength(100);
            entity.Property(e => e.LevKundeId).HasColumnName("LevKundeID");
            entity.Property(e => e.LevPostnr).HasMaxLength(100);
            entity.Property(e => e.LevTid).HasPrecision(0);
            entity.Property(e => e.Modtager).HasMaxLength(50);
            entity.Property(e => e.OpretDato).HasPrecision(0);
            entity.Property(e => e.Ops)
                .HasDefaultValue(false)
                .HasColumnName("OPS");
            entity.Property(e => e.OrdreBekDato).HasPrecision(0);
            entity.Property(e => e.RekvIordre).HasColumnName("RekvIOrdre");
            entity.Property(e => e.RekvKat).HasMaxLength(20);
            entity.Property(e => e.RekvKundeId).HasColumnName("RekvKundeID");
            entity.Property(e => e.Rekvirent)
                .HasMaxLength(50)
                .HasColumnName("rekvirent");
            entity.Property(e => e.Sag).HasMaxLength(20);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Valuta).HasMaxLength(10);

            entity.HasOne(d => d.RekvKunde).WithMany(p => p.Tblhoveds)
                .HasForeignKey(d => d.RekvKundeId)
                .HasConstraintName("tblhoved$[D:\\første\\RekvTables.mdb].{BCE98B96-7D59-48CD-8461-0A16BE59576A}");
        });

        modelBuilder.Entity<Tblkunde>(entity =>
        {
            entity.HasKey(e => e.RekvKundeId).HasName("tblkunde$PrimaryKey");

            entity.ToTable("tblkunde");

            entity.HasIndex(e => e.HovedNummer, "tblkunde$HovedNummer");

            entity.HasIndex(e => e.LevTypeId, "tblkunde$TypeID");

            entity.HasIndex(e => e.RekvKundeId, "tblkunde$id");

            entity.Property(e => e.RekvKundeId).HasColumnName("RekvKundeID");
            entity.Property(e => e.AdrUndLev).HasMaxLength(255);
            entity.Property(e => e.Gruppe).HasMaxLength(2);
            entity.Property(e => e.HovedNummer).HasMaxLength(255);
            entity.Property(e => e.Kunde)
                .HasMaxLength(255)
                .HasColumnName("kunde");
            entity.Property(e => e.LevTypeId).HasColumnName("LevTypeID");
            entity.Property(e => e.PostNrUndLev).HasMaxLength(255);
            entity.Property(e => e.Valuta).HasMaxLength(10);
        });

        modelBuilder.Entity<Tbllinie>(entity =>
        {
            entity.HasKey(e => e.LinieId).HasName("tbllinie$PrimaryKey");

            entity.ToTable("tbllinie");

            entity.HasIndex(e => e.ChargeId, "tbllinie$ChargeID");

            entity.HasIndex(e => e.FakId, "tbllinie$FakID");

            entity.HasIndex(e => e.PosRevId, "tbllinie$PosRevID");

            entity.HasIndex(e => e.VareId, "tbllinie$VareID");

            entity.HasIndex(e => e.LinieId, "tbllinie$id");

            entity.HasIndex(e => e.RekvId, "tbllinie$rekid");

            entity.Property(e => e.LinieId).HasColumnName("LinieID");
            entity.Property(e => e.Antal)
                .HasMaxLength(50)
                .HasColumnName("antal");
            entity.Property(e => e.Beskrivelse).HasColumnName("beskrivelse");
            entity.Property(e => e.Certifikat).HasDefaultValue(false);
            entity.Property(e => e.ChargeId).HasColumnName("ChargeID");
            entity.Property(e => e.FakId).HasColumnName("FakID");
            entity.Property(e => e.Faktura)
                .HasDefaultValue(false)
                .HasColumnName("faktura");
            entity.Property(e => e.Godkendt).HasDefaultValue(false);
            entity.Property(e => e.GodkendtD).HasPrecision(0);
            entity.Property(e => e.ItemPos).HasMaxLength(30);
            entity.Property(e => e.Materiale).HasDefaultValue(false);
            entity.Property(e => e.MedCert).HasDefaultValue(false);
            entity.Property(e => e.Modtaget)
                .HasDefaultValue(false)
                .HasColumnName("modtaget");
            entity.Property(e => e.ModtagetD).HasPrecision(0);
            entity.Property(e => e.Port).HasMaxLength(15);
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.RekvId)
                .HasDefaultValue(0)
                .HasComment("ref. til tblhoved ID")
                .HasColumnName("RekvID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Stnr)
                .HasMaxLength(10)
                .HasColumnName("STnr");
            entity.Property(e => e.Tegning).HasDefaultValue(false);
            entity.Property(e => e.Valuta).HasMaxLength(10);
            entity.Property(e => e.VareEnhed).HasMaxLength(10);
            entity.Property(e => e.VareId).HasColumnName("VareID");

            entity.HasOne(d => d.Charge).WithMany(p => p.Tbllinies)
                .HasForeignKey(d => d.ChargeId)
                .HasConstraintName("tbllinie$[D:\\første\\RekvTables.mdb].tblChargeNrtbllinie");
        });

        modelBuilder.Entity<TbllinieCorrupted>(entity =>
        {
            entity.HasKey(e => e.LinieId).HasName("tbllinieCorrupted$PrimaryKey");

            entity.ToTable("tbllinieCorrupted");

            entity.HasIndex(e => e.ChargeId, "tbllinieCorrupted$ChargeID");

            entity.HasIndex(e => e.FakId, "tbllinieCorrupted$FakID");

            entity.HasIndex(e => e.PosRevId, "tbllinieCorrupted$PosRevID");

            entity.HasIndex(e => e.VareId, "tbllinieCorrupted$VareID");

            entity.HasIndex(e => e.LinieId, "tbllinieCorrupted$id");

            entity.HasIndex(e => e.RekvId, "tbllinieCorrupted$rekid");

            entity.Property(e => e.LinieId).HasColumnName("LinieID");
            entity.Property(e => e.Antal)
                .HasMaxLength(50)
                .HasColumnName("antal");
            entity.Property(e => e.Beskrivelse).HasColumnName("beskrivelse");
            entity.Property(e => e.Certifikat).HasDefaultValue(false);
            entity.Property(e => e.ChargeId).HasColumnName("ChargeID");
            entity.Property(e => e.FakId).HasColumnName("FakID");
            entity.Property(e => e.Faktura)
                .HasDefaultValue(false)
                .HasColumnName("faktura");
            entity.Property(e => e.Godkendt).HasDefaultValue(false);
            entity.Property(e => e.GodkendtD).HasPrecision(0);
            entity.Property(e => e.ItemPos).HasMaxLength(30);
            entity.Property(e => e.Materiale).HasDefaultValue(false);
            entity.Property(e => e.MedCert).HasDefaultValue(false);
            entity.Property(e => e.Modtaget)
                .HasDefaultValue(false)
                .HasColumnName("modtaget");
            entity.Property(e => e.ModtagetD).HasPrecision(0);
            entity.Property(e => e.Port).HasMaxLength(15);
            entity.Property(e => e.PosRevId).HasColumnName("PosRevID");
            entity.Property(e => e.RekvId)
                .HasDefaultValue(0)
                .HasComment("ref. til tblhoved ID")
                .HasColumnName("RekvID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Stnr)
                .HasMaxLength(10)
                .HasColumnName("STnr");
            entity.Property(e => e.Tegning).HasDefaultValue(false);
            entity.Property(e => e.Valuta).HasMaxLength(10);
            entity.Property(e => e.VareEnhed).HasMaxLength(10);
            entity.Property(e => e.VareId).HasColumnName("VareID");
        });

        modelBuilder.Entity<Tbltegninger>(entity =>
        {
            entity.HasKey(e => e.TegId).HasName("tbltegninger$PrimaryKey");

            entity.ToTable("tbltegninger");

            entity.HasIndex(e => e.LinieId, "tbltegninger$LinieID");

            entity.Property(e => e.TegId).HasColumnName("TegID");
            entity.Property(e => e.LinieId).HasColumnName("LinieID");
            entity.Property(e => e.TegPath).HasMaxLength(255);

            entity.HasOne(d => d.Linie).WithMany(p => p.Tbltegningers)
                .HasForeignKey(d => d.LinieId)
                .HasConstraintName("tbltegninger$[D:\\første\\RekvTables.mdb].tbllinietbltegninger");
        });

        modelBuilder.Entity<Vedligeholdelse>(entity =>
        {
            entity.HasKey(e => e.VedligehNr).HasName("Vedligeholdelse$PrimaryKey");

            entity.ToTable("Vedligeholdelse");

            entity.Property(e => e.VedligehNr).HasColumnName("vedligeh_nr");
            entity.Property(e => e.DatoStart)
                .HasPrecision(0)
                .HasColumnName("Dato_start");
            entity.Property(e => e.DatoUdført)
                .HasPrecision(0)
                .HasColumnName("Dato_udført");
            entity.Property(e => e.Interval).HasDefaultValue(0);
            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<VedligeholdelseForespørgsel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vedligeholdelse forespørgsel");

            entity.Property(e => e.DatoStart)
                .HasPrecision(0)
                .HasColumnName("Dato_start");
            entity.Property(e => e.DatoUdført)
                .HasPrecision(0)
                .HasColumnName("Dato_udført");
            entity.Property(e => e.LinieNr)
                .HasMaxLength(10)
                .HasColumnName("Linie_nr");
            entity.Property(e => e.LinieNrTekst)
                .HasMaxLength(255)
                .HasColumnName("Linie_nr_Tekst");
            entity.Property(e => e.VedligehNr).HasColumnName("vedligeh_nr");
            entity.Property(e => e.VedligeholdelseTekst).HasColumnName("Vedligeholdelse_Tekst");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
