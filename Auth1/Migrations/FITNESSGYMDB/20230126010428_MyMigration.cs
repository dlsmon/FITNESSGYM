using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FITNESSGYM.Migrations.FITNESSGYMDB
{
    /// <inheritdoc />
    public partial class MyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phonenumber = table.Column<int>(type: "int", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diseases = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Newsletter = table.Column<int>(type: "int", nullable: true),
                    Freetrial = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Calories = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formula",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormulaRank = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Commitement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formula", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: true),
                    MaxParticipants = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intensity = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Calories = table.Column<int>(type: "int", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GoalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Frequency = table.Column<int>(type: "int", nullable: false),
                    CaloriesBurnt = table.Column<int>(type: "int", nullable: true),
                    IdClient = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goal_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteExercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdExercise = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteExercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteExercise_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteExercise_Exercise_IdExercise",
                        column: x => x.IdExercise,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Entrydate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sortdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdFormula = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscription_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscription_Formula_IdFormula",
                        column: x => x.IdFormula,
                        principalTable: "Formula",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdLocation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteLocation_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteLocation_Location_IdLocation",
                        column: x => x.IdLocation,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineLocation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMachine = table.Column<int>(type: "int", nullable: false),
                    IdLocation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineLocation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MachineLocation_Location_IdLocation",
                        column: x => x.IdLocation,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineLocation_Machine_IdMachine",
                        column: x => x.IdMachine,
                        principalTable: "Machine",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSpeciality = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Coach_Speciality_IdSpeciality",
                        column: x => x.IdSpeciality,
                        principalTable: "Speciality",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FavoriteTrainingProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdTrainingProgram = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteTrainingProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteTrainingProgram_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteTrainingProgram_TrainingProgram_IdTrainingProgram",
                        column: x => x.IdTrainingProgram,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndividualProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTrainingProgram = table.Column<int>(type: "int", nullable: false),
                    IdExercise = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualProgram_Exercise_IdExercise",
                        column: x => x.IdExercise,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndividualProgram_TrainingProgram_IdTrainingProgram",
                        column: x => x.IdTrainingProgram,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteCoach",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdCoach = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteCoach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteCoach_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteCoach_Coach_IdCoach",
                        column: x => x.IdCoach,
                        principalTable: "Coach",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SessionHour = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaxParticipants = table.Column<int>(type: "int", nullable: true),
                    FormulaRank = table.Column<int>(type: "int", nullable: true),
                    IdCoach = table.Column<int>(type: "int", nullable: true),
                    IdLocation = table.Column<int>(type: "int", nullable: true),
                    IdTrainingProgram = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Session_Coach_IdCoach",
                        column: x => x.IdCoach,
                        principalTable: "Coach",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Session_Location_IdLocation",
                        column: x => x.IdLocation,
                        principalTable: "Location",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Session_TrainingProgram_IdTrainingProgram",
                        column: x => x.IdTrainingProgram,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cancelled = table.Column<int>(type: "int", nullable: true),
                    IdSession = table.Column<int>(type: "int", nullable: true),
                    IdClient = table.Column<int>(type: "int", nullable: true),
                    TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Reservation_Session_IdSession",
                        column: x => x.IdSession,
                        principalTable: "Session",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ID", "Adresse", "Birthdate", "Diseases", "FirstName", "Freetrial", "Height", "Hobbies", "IdUser", "LastName", "Newsletter", "Phonenumber", "Sex", "Weight" },
                values: new object[,]
                {
                    { 1, "Rue du Chateau, 95110 Paris", new DateTime(1996, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", "David", 0, 170, "Danse, volley-ball", "david0moniz@hotmail.com", "Moniz", 0, 620285591, 1, 75 },
                    { 2, "Boulevard Central, 95110 Paris", new DateTime(1996, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "diabetes", "Richy", 1, 170, "Sport", "Richy@gmail.com", "Wiliam", 1, 633504482, 1, 85 }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "Calories", "Description", "Duration", "Name" },
                values: new object[,]
                {
                    { 1, 50, "Au sol sur le do, les genoux formant un angle un angle droit avec vos hanches. Ramenez votre buste vers le ciel tout en plaçant les mains au niveau de la nuque.", 5, "Crunch" },
                    { 2, 100, "En position de planche frontale : sur la pointe des pieds, les mains bien à plat sur le sol, le dos droit et la tête dans le prolongement de votre colonne vertébrale. Ramenez ensuite les genoux à votre poitrine de façon alternée.", 5, "Montain Climber" },
                    { 3, 100, "Debout, l'espace entre votre deux pieds correspond à la largeur de vos épaules. Sautez en poussant les genoux vers l'extérieur. Lever les bras en même temps que vous sautez. Puis revenir en position initiale : debout, les bras le long du corps.", 5, "Jumping jack" },
                    { 4, 100, "En position de planche frontale, c'est-à-dire sur la pointe des pieds et mains à plat sur le sol, le dos droit et la tête dans le prolongement de votre colonne vertébrale. Ramenez la poitrine vers le sol en pliant les coudes puis tendez les bras. Restez bien gainé tout au long de l'exercice.", 5, "Pompes Hiit" },
                    { 5, 100, "Commencez en position debout, puis lever rapidement les genoux un après l'autre.", 5, "Leg lift" }
                });

            migrationBuilder.InsertData(
                table: "Formula",
                columns: new[] { "ID", "Commitement", "Description", "FormulaRank", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 0, "Abonnement mensuel de 9€/mois sans engagement, sans période d'essai, seule la période en cours est due. Accès en illimités aux cours et programmes en ligne.", 1, "No Gym No Problem Month", 9 },
                    { 2, 0, "Abonnement annuel de 29€/mois sans engagement, sans période d'essai, seule la période en cours est due. Accès en illimités aux cours et programmes en ligne.", 1, "No Gym No Problem Year", 59 },
                    { 3, 1, "L'abonnement mensuel CLASSIQUE FIT à 29€/mois vous donne accès à tous les clubs FITNESS GYM pour profiter de tous les appareils de musculations et cardio ainsi que de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est AVEC engagement sur une période de 12 mois et est valable de date à date.", 2, "Classique fit 1", 29 },
                    { 4, 0, "L'abonnement mensuel CLASSIQUE FIT à 34€/mois vous donne accès à tous les clubs FITNESS GYM pour profiter de tous les appareils de musculations et cardio ainsi que de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est SANS engagement et valable de date à date. Seule la période en cours est due.", 2, "Classique fit 2", 34 },
                    { 5, 1, "L'abonnement mensuel PREMIUM FIT à 36€/mois vous donne accès à tous les clubs FITNESS GYM pour y pratiquer les activités de sports de fitness et musculation, participer à une multitude de cours ainsi profiter de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est AVEC engagement sur une période de 12 mois et est valable de date à date.", 3, "Premium fit 1", 39 },
                    { 6, 0, "L'abonnement mensuel PREMIUM FIT à 40€/mois vous donne accès à tous les clubs FITNESS GYM pour y pratiquer les activités de sports de fitness et musculation, participer à une multitude de cours ainsi profiter de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est SANS engagement et valable de date à date. Seule la période en cours est due.", 3, "Premium fit 2", 44 }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "ID", "Address", "City", "MaxParticipants", "Name", "PostalCode" },
                values: new object[,]
                {
                    { 1, "22 bis boulevard Saint Marcel", "Paris", 500, "Fitness Gym Austerlitz", 75005 },
                    { 2, "4/6 Passage Louis Philippe", "Paris", 450, "Fitness Gym Bastille", 75011 },
                    { 3, "123 Avenue de France ", "Paris", 350, "Fitness Gym BNF", 75013 },
                    { 4, "21 rue de la banque", "Paris", 350, "Fitness Gym Opera", 75002 },
                    { 5, "6 allée de la 2ème Division Blindée", "Paris", 500, "Fitness Gym Montparnasse", 75014 },
                    { 6, "81 rue de Lagny ", "Paris", 500, "Fitness Gym Nation", 75020 },
                    { 7, "44 rue de Clichy ", "Paris", 450, "Fitness Gym Saint-Lazarre", 75009 },
                    { 8, "19, avenue de la Liberté", "Nanterre", 600, "Fitness Gym La défense", 92000 },
                    { 9, "18-20, rue Auguste Perret", "Villejuif", 550, "Fitness Gym Villejuif", 94800 },
                    { 10, "11, Rue Exelmans", "Versailles", 600, "Fitness Gym Versailles", 78000 }
                });

            migrationBuilder.InsertData(
                table: "Machine",
                columns: new[] { "ID", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { 1, "Améliorez votre endurance avec ce tapis de course qui absorbe le choc des impacts par rapport à la course en extérieur. Marcher, trottiner, courir, sprinter : vous pourrez choisir votre allure en fonction de votre forme ou de votre entraînement. Vous pouvez également augmenter la pente pour intensifier le travail.", "Tapis de course", null },
                    { 2, "Le vélo elliptique, cet incontournable des salles de sport, associe travail cardiovasculaire doux et travail musculaire sans impacts ni douleurs pour les articulations. La particularité de ce vélo ? Ses bras sont mobiles, ce qui vous permettra de solliciter 90% des muscles du corps en reproduisant les mouvements du ski de fond.", "Vélo elliptique", null },
                    { 3, "Ce vélo d’intérieur particulièrement ergonomique vous permet de réaliser des entraînements intenses, de développer vos capacités-cardio-vasculaires et de renforcer vos cuisses. Il possède toutes les fonctions d’un vélo de course : selle ajustable et fine permettant le pédalage en danseuse, guidon anatomique, pédales automatiques, système de freinage et cadre robuste.", "Vélo semi-allongé", null },
                    { 4, "Contrairement à ce que l'on pense, le rameur ne permet pas uniquement de travailler le haut du corps. Les jambes sont aussi très sollicitées et plus vous maîtrisez la technique, plus vous le ressentez ! Bras, épaules, jambes, abdominaux, lombaires… : en réalité, tous les muscles du corps sont mobilisés et renforcés, faisant du rameur un appareil très complet.", "Rameur", null },
                    { 5, "Idéale pour muscler les fessiers, cette machine vous laisse atteindre une extension maximale. Cela dit, aucun risque pour le bas de votre dos car la hanche n'effectue aucune rotation.", "Glute Drive", null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name", "Photo", "Price" },
                values: new object[] { 1, "Un tapis spécialement conçu pour s’adapter à vos exercices au sol. Vous pourrez faire vos abdominaux ou réaliser vos étirements confortablement.", "Tapis de fitness", null, 15 });

            migrationBuilder.InsertData(
                table: "Speciality",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Yoga Expert" },
                    { 2, "Bodybuilder" },
                    { 3, "Hiit Expert" },
                    { 4, "Cardio" }
                });

            migrationBuilder.InsertData(
                table: "TrainingProgram",
                columns: new[] { "Id", "Calories", "Description", "Duration", "Intensity", "Name", "Photo" },
                values: new object[,]
                {
                    { 1, 400, "De la chorégraphie, toujours et encore pour vous faire bouger sur des rythmes endiablés. De la salsa au merengue, en passant par la cumbia, le reggaeton, le kuduro… De la variété plus qu’il n’en faut au sein d’un Group training aussi efficace qu’amusant.\r\n\r\n", 45, 1, "Zumba", "/Assets/Images/TrainingProgram/ZUMBA.jpg" },
                    { 2, 400, "Fruit de la rencontre entre le step et le Body Pump, le Body Sculpt vous aide à redessiner votre silhouette. Elastiques, haltères et bâtons sont les accessoires-clés pour parvenir à cet objectif, dans le cadre d’un Group training complet et accessible à tous.", 45, 2, "Body Sculpt", "/Assets/Images/TrainingProgram/BODY-SCULPT.jpg" },
                    { 3, 750, "Fentes, squats, jumping jacks : plongez au cœur du Body Attack ! La dynamique de groupe vous donnera une énergie incroyable pour réaliser un entraînement de haute intensité. On y retrouve des mouvements athlétiques comme la course, les flexions ou les sauts, qui sont combinés à des exercices de renforcement comme les pompes. Chorégraphies et musiques donneront du rythme à vos fractionnés, pour une endurance décuplée..", 45, 4, "Body Attack", "/Assets/Images/TrainingProgram/BODY-ATTACK.jpg" },
                    { 4, 500, "Bienvenue au  Body Pump ! Ce Group training LesMills tonifie et renforce le corps tout entier en permettant à vos muscles de se sculpter sans prendre de volume. Les mouvements sont simples et le nombre de répétitions est élevé : le secret des muscles fins et athlétiques.", 45, 3, "Body Pump", "/Assets/Images/TrainingProgram/BODY-PUMP.jpg" },
                    { 5, 300, "Cours traditionnel de cuisses abdos fessiers permettant de renforcer ses muscles afin de consolider les articulations et de limiter les douleurs dorsales.", 30, 3, "CAF", "/Assets/Images/TrainingProgram/CAF.jpg" },
                    { 6, 700, "Le Hiit ou High Intensity Interval Training est un type d'entrainement bien connu pour son efficacité. C'est un cours où vous travaillerez principalement vos capacités cardio-vasculaires en association avec des mouvements de musculation. Le HIIT est un cours full body intense et complet qui permet aussi bien de travailler le renforcement musculaire que l'endurance, tout en se défoulant.", 30, 4, "Hiit", "/Assets/Images/TrainingProgram/HIIT.jpg" },
                    { 7, 300, "Prendre conscience de son corps en le musclant, c’est ce que propose le Pilates. Le pilate s’inspire de la danse, de la gymnastique et du yoga. Toute la séance est rythmée par des musiques zen et relaxantes. Tour à tour, vous alternez entre exercices d’équilibre afin de muscler la ceinture abdominale et exercices d’assouplissement, debout ou au sol, afin d’étirer les tendons et les muscles.", 45, 2, "Pilates", "/Assets/Images/TrainingProgram/PILATES.jpg" },
                    { 8, 550, "Initiez-vous à l’art du Step en enchaînant des chorégraphies sur et autour d’une marche à hauteur réglable, sur fond de musique rythmée. Montez, descendez, tournez : de la coordination, vous en aurez besoin à coups sûr ! Vous brûlerez aussi beaucoup de calories, quasiment sans vous en rendre compte tellement vous serez concentré sur vos mouvements !", 45, 1, "Step", "/Assets/Images/TrainingProgram/STEP.jpg" },
                    { 9, 500, "Ce cours est un mix entre le Yoga et le Pilates. Il permet, grâce à des étirements, de travailler sa posture, en particulier celle du dos, en étirant la colonne vertébrale et en évitant le tassement des vertèbres. Les exercices effectués pendant la séance aident à augmenter la souplesse générale du corps en assouplissant et en renforçant l'élasticité des tendons et des muscles. Cela permet également de retrouver une silhouette affinée et plus harmonieuse.", 60, 1, "Stretch", "/Assets/Images/TrainingProgram/STRETCH.jpg" },
                    { 10, 400, "Entre dynamisme et calme, ce cours permet de gagner en force et en souplesse tout en respirant. Allez un peu plus loin chaque jour tout en respectant votre corps, en laissant frustration et égo de côté. Ressentez les postures du flow plutôt que d'essayer de dépasser vos limites. En apprenant à écouter son corps, on se connecte plus à son mental, pour plus de maîtrise de soi.", 60, 2, "Yoga", "/Assets/Images/TrainingProgram/YOGA.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Coach",
                columns: new[] { "ID", "FirstName", "IdSpeciality", "LastName", "Photo" },
                values: new object[,]
                {
                    { 1, "CEDERIC", 1, "O", "/Assets/Images/Coach/CEDRIC_O.jpg" },
                    { 2, "DELPHINE", 2, "G", "/Assets/Images/Coach/DELPHINE G.jpg" },
                    { 3, "FLORIAN", 3, "G", "/Assets/Images/Coach/FLORIAN_G.jpg" },
                    { 4, "GUILLAUME", 1, "P", "/Assets/Images/Coach/GUILLAUME P.jpg" },
                    { 5, "JESSUN", 1, "C", "/Assets/Images/Coach/JESSUN C.jpg" },
                    { 6, "NABIL", 4, "C", "/Assets/Images/Coach/NABIL C.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Goal",
                columns: new[] { "Id", "CaloriesBurnt", "Frequency", "GoalDate", "IdClient", "UpdateDate", "Weight" },
                values: new object[] { 1, 1000, 3, null, 1, null, 75 });

            migrationBuilder.InsertData(
                table: "IndividualProgram",
                columns: new[] { "Id", "IdExercise", "IdTrainingProgram" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 4, 2 },
                    { 3, 1, 3 },
                    { 4, 5, 4 },
                    { 5, 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "Subscription",
                columns: new[] { "Id", "Discount", "Entrydate", "IdClient", "IdFormula", "Price", "Sortdate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "Id", "FormulaRank", "IdCoach", "IdLocation", "IdTrainingProgram", "MaxParticipants", "SessionDate", "SessionHour" },
                values: new object[,]
                {
                    { 1, 3, 1, 2, 1, 15, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7105), new DateTime(2023, 1, 26, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7173) },
                    { 2, 3, 5, 7, 2, 20, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7185), new DateTime(2023, 1, 26, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7188) },
                    { 3, 3, 5, 9, 3, 30, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7198), new DateTime(2023, 1, 26, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7200) },
                    { 4, 3, 3, 8, 4, 22, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7210), new DateTime(2023, 1, 26, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7212) },
                    { 5, 3, 1, 3, 2, 18, null, null },
                    { 21, 3, 4, 4, 1, 13, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7279), new DateTime(2023, 1, 30, 19, 2, 28, 585, DateTimeKind.Local).AddTicks(7285) },
                    { 22, 2, 2, 9, 1, 14, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 2, 1, 5, 3, 28, 585, DateTimeKind.Local).AddTicks(7299) },
                    { 23, 1, 4, 9, 1, 7, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7307), new DateTime(2023, 2, 2, 0, 8, 28, 585, DateTimeKind.Local).AddTicks(7309) },
                    { 24, 2, 3, 6, 1, 18, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7318), new DateTime(2023, 1, 31, 15, 44, 28, 585, DateTimeKind.Local).AddTicks(7319) },
                    { 25, 2, 5, 1, 1, 11, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7329), new DateTime(2023, 1, 31, 19, 50, 28, 585, DateTimeKind.Local).AddTicks(7331) },
                    { 26, 1, 3, 6, 1, 15, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7339), new DateTime(2023, 1, 27, 0, 4, 28, 585, DateTimeKind.Local).AddTicks(7341) },
                    { 27, 1, 1, 1, 1, 13, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 1, 27, 21, 22, 28, 585, DateTimeKind.Local).AddTicks(7351) },
                    { 28, 3, 3, 1, 1, 12, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7359), new DateTime(2023, 1, 30, 18, 6, 28, 585, DateTimeKind.Local).AddTicks(7361) },
                    { 29, 3, 2, 2, 1, 10, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 1, 27, 3, 54, 28, 585, DateTimeKind.Local).AddTicks(7370) },
                    { 36, 3, 3, 9, 2, 7, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7378), new DateTime(2023, 1, 31, 5, 12, 28, 585, DateTimeKind.Local).AddTicks(7380) },
                    { 37, 2, 3, 2, 2, 5, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 1, 26, 16, 49, 28, 585, DateTimeKind.Local).AddTicks(7390) },
                    { 38, 2, 1, 5, 2, 12, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7398), new DateTime(2023, 1, 30, 20, 28, 28, 585, DateTimeKind.Local).AddTicks(7400) },
                    { 39, 3, 4, 8, 2, 15, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7410), new DateTime(2023, 1, 29, 4, 47, 28, 585, DateTimeKind.Local).AddTicks(7412) },
                    { 40, 2, 5, 7, 2, 10, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7448), new DateTime(2023, 1, 29, 10, 12, 28, 585, DateTimeKind.Local).AddTicks(7449) },
                    { 41, 2, 5, 7, 2, 16, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7458), new DateTime(2023, 1, 27, 10, 23, 28, 585, DateTimeKind.Local).AddTicks(7459) },
                    { 42, 2, 2, 1, 2, 15, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7468), new DateTime(2023, 1, 26, 3, 49, 28, 585, DateTimeKind.Local).AddTicks(7470) },
                    { 43, 1, 3, 8, 2, 8, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7479), new DateTime(2023, 1, 27, 7, 45, 28, 585, DateTimeKind.Local).AddTicks(7481) },
                    { 44, 3, 2, 9, 2, 19, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7489), new DateTime(2023, 2, 1, 10, 17, 28, 585, DateTimeKind.Local).AddTicks(7491) },
                    { 51, 2, 5, 1, 3, 5, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7499), new DateTime(2023, 1, 28, 18, 41, 28, 585, DateTimeKind.Local).AddTicks(7501) },
                    { 52, 2, 5, 3, 3, 6, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7510), new DateTime(2023, 1, 29, 17, 19, 28, 585, DateTimeKind.Local).AddTicks(7512) },
                    { 53, 3, 2, 2, 3, 16, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 1, 30, 23, 5, 28, 585, DateTimeKind.Local).AddTicks(7522) },
                    { 54, 3, 4, 5, 3, 6, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7531), new DateTime(2023, 1, 31, 17, 23, 28, 585, DateTimeKind.Local).AddTicks(7533) },
                    { 55, 2, 5, 1, 3, 18, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7542), new DateTime(2023, 1, 31, 18, 36, 28, 585, DateTimeKind.Local).AddTicks(7544) },
                    { 56, 3, 1, 5, 3, 17, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7553), new DateTime(2023, 2, 1, 0, 11, 28, 585, DateTimeKind.Local).AddTicks(7555) },
                    { 57, 2, 5, 8, 3, 7, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7564), new DateTime(2023, 1, 26, 3, 21, 28, 585, DateTimeKind.Local).AddTicks(7566) },
                    { 58, 1, 5, 8, 3, 9, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7574), new DateTime(2023, 1, 31, 1, 9, 28, 585, DateTimeKind.Local).AddTicks(7576) },
                    { 59, 3, 1, 6, 3, 15, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7584), new DateTime(2023, 1, 31, 20, 8, 28, 585, DateTimeKind.Local).AddTicks(7586) },
                    { 66, 2, 4, 1, 4, 15, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7594), new DateTime(2023, 1, 31, 11, 58, 28, 585, DateTimeKind.Local).AddTicks(7596) },
                    { 67, 1, 4, 1, 4, 15, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7605), new DateTime(2023, 1, 26, 5, 6, 28, 585, DateTimeKind.Local).AddTicks(7607) },
                    { 68, 1, 5, 2, 4, 14, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7617), new DateTime(2023, 1, 30, 6, 44, 28, 585, DateTimeKind.Local).AddTicks(7619) },
                    { 69, 1, 5, 9, 4, 17, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7627), new DateTime(2023, 1, 27, 17, 12, 28, 585, DateTimeKind.Local).AddTicks(7629) },
                    { 70, 1, 3, 9, 4, 19, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7637), new DateTime(2023, 1, 29, 20, 3, 28, 585, DateTimeKind.Local).AddTicks(7639) },
                    { 71, 1, 1, 3, 4, 17, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7647), new DateTime(2023, 1, 31, 20, 53, 28, 585, DateTimeKind.Local).AddTicks(7649) },
                    { 72, 1, 3, 9, 4, 8, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 1, 28, 2, 5, 28, 585, DateTimeKind.Local).AddTicks(7659) },
                    { 73, 1, 4, 3, 4, 5, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7692), new DateTime(2023, 1, 31, 16, 25, 28, 585, DateTimeKind.Local).AddTicks(7694) },
                    { 74, 2, 5, 8, 4, 17, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7704), new DateTime(2023, 1, 30, 20, 16, 28, 585, DateTimeKind.Local).AddTicks(7706) },
                    { 81, 3, 1, 3, 5, 19, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 1, 29, 23, 48, 28, 585, DateTimeKind.Local).AddTicks(7716) },
                    { 82, 3, 4, 8, 5, 11, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7725), new DateTime(2023, 1, 27, 0, 39, 28, 585, DateTimeKind.Local).AddTicks(7727) },
                    { 83, 2, 3, 7, 5, 13, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7735), new DateTime(2023, 1, 26, 22, 53, 28, 585, DateTimeKind.Local).AddTicks(7737) },
                    { 84, 3, 1, 1, 5, 17, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 1, 31, 13, 14, 28, 585, DateTimeKind.Local).AddTicks(7746) },
                    { 85, 3, 5, 9, 5, 18, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 1, 26, 13, 40, 28, 585, DateTimeKind.Local).AddTicks(7756) },
                    { 86, 1, 3, 5, 5, 19, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 2, 1, 6, 19, 28, 585, DateTimeKind.Local).AddTicks(7767) },
                    { 87, 3, 1, 3, 5, 6, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 1, 26, 22, 22, 28, 585, DateTimeKind.Local).AddTicks(7777) },
                    { 88, 1, 5, 5, 5, 6, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7785), new DateTime(2023, 1, 29, 2, 20, 28, 585, DateTimeKind.Local).AddTicks(7787) },
                    { 89, 1, 3, 1, 5, 8, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7795), new DateTime(2023, 1, 31, 14, 33, 28, 585, DateTimeKind.Local).AddTicks(7796) },
                    { 96, 3, 4, 1, 6, 11, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7805), new DateTime(2023, 2, 1, 2, 20, 28, 585, DateTimeKind.Local).AddTicks(7807) },
                    { 97, 2, 3, 8, 6, 9, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7815), new DateTime(2023, 1, 28, 5, 49, 28, 585, DateTimeKind.Local).AddTicks(7817) },
                    { 98, 1, 1, 4, 6, 13, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7825), new DateTime(2023, 1, 27, 5, 5, 28, 585, DateTimeKind.Local).AddTicks(7827) },
                    { 99, 2, 2, 7, 6, 14, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7834), new DateTime(2023, 1, 26, 8, 51, 28, 585, DateTimeKind.Local).AddTicks(7836) },
                    { 100, 2, 1, 1, 6, 6, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7844), new DateTime(2023, 1, 30, 23, 24, 28, 585, DateTimeKind.Local).AddTicks(7846) },
                    { 101, 3, 1, 7, 6, 11, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 2, 1, 18, 58, 28, 585, DateTimeKind.Local).AddTicks(7856) },
                    { 102, 3, 4, 8, 6, 10, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 1, 28, 9, 18, 28, 585, DateTimeKind.Local).AddTicks(7866) },
                    { 103, 1, 2, 8, 6, 18, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7873), new DateTime(2023, 2, 2, 0, 32, 28, 585, DateTimeKind.Local).AddTicks(7875) },
                    { 104, 3, 4, 4, 6, 15, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7884), new DateTime(2023, 1, 29, 14, 10, 28, 585, DateTimeKind.Local).AddTicks(7886) },
                    { 111, 3, 1, 1, 7, 12, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 1, 28, 14, 56, 28, 585, DateTimeKind.Local).AddTicks(7896) },
                    { 112, 1, 5, 6, 7, 8, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 2, 1, 12, 59, 28, 585, DateTimeKind.Local).AddTicks(7906) },
                    { 113, 3, 1, 8, 7, 5, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7914), new DateTime(2023, 1, 26, 10, 18, 28, 585, DateTimeKind.Local).AddTicks(7916) },
                    { 114, 3, 4, 4, 7, 11, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7924), new DateTime(2023, 1, 30, 1, 35, 28, 585, DateTimeKind.Local).AddTicks(7926) },
                    { 115, 1, 3, 6, 7, 10, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 1, 30, 11, 25, 28, 585, DateTimeKind.Local).AddTicks(7966) },
                    { 116, 3, 2, 7, 7, 10, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 1, 31, 23, 37, 28, 585, DateTimeKind.Local).AddTicks(7976) },
                    { 117, 1, 5, 7, 7, 9, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 1, 27, 23, 17, 28, 585, DateTimeKind.Local).AddTicks(7988) },
                    { 118, 1, 5, 3, 7, 7, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(7996), new DateTime(2023, 1, 31, 1, 36, 28, 585, DateTimeKind.Local).AddTicks(7998) },
                    { 119, 3, 5, 1, 7, 10, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8006), new DateTime(2023, 2, 1, 23, 50, 28, 585, DateTimeKind.Local).AddTicks(8008) },
                    { 126, 1, 5, 4, 8, 16, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8017), new DateTime(2023, 1, 30, 8, 20, 28, 585, DateTimeKind.Local).AddTicks(8019) },
                    { 127, 3, 5, 9, 8, 11, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8027), new DateTime(2023, 1, 31, 6, 17, 28, 585, DateTimeKind.Local).AddTicks(8029) },
                    { 128, 1, 4, 8, 8, 15, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 1, 28, 22, 55, 28, 585, DateTimeKind.Local).AddTicks(8039) },
                    { 129, 3, 2, 9, 8, 13, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8047), new DateTime(2023, 1, 30, 17, 10, 28, 585, DateTimeKind.Local).AddTicks(8049) },
                    { 130, 1, 3, 5, 8, 16, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8057), new DateTime(2023, 1, 29, 17, 7, 28, 585, DateTimeKind.Local).AddTicks(8059) },
                    { 131, 2, 5, 7, 8, 19, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8066), new DateTime(2023, 1, 29, 7, 4, 28, 585, DateTimeKind.Local).AddTicks(8068) },
                    { 132, 3, 4, 3, 8, 10, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8076), new DateTime(2023, 2, 1, 15, 24, 28, 585, DateTimeKind.Local).AddTicks(8078) },
                    { 133, 1, 1, 5, 8, 17, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8086), new DateTime(2023, 2, 1, 10, 22, 28, 585, DateTimeKind.Local).AddTicks(8088) },
                    { 134, 2, 3, 2, 8, 8, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8096), new DateTime(2023, 1, 29, 7, 36, 28, 585, DateTimeKind.Local).AddTicks(8097) },
                    { 141, 3, 1, 4, 9, 10, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8105), new DateTime(2023, 1, 27, 18, 53, 28, 585, DateTimeKind.Local).AddTicks(8107) },
                    { 142, 3, 3, 4, 9, 8, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8115), new DateTime(2023, 1, 30, 8, 51, 28, 585, DateTimeKind.Local).AddTicks(8117) },
                    { 143, 3, 2, 8, 9, 11, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8124), new DateTime(2023, 2, 1, 7, 8, 28, 585, DateTimeKind.Local).AddTicks(8126) },
                    { 144, 2, 3, 4, 9, 5, new DateTime(2023, 1, 29, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8134), new DateTime(2023, 1, 30, 9, 22, 28, 585, DateTimeKind.Local).AddTicks(8136) },
                    { 145, 1, 3, 1, 9, 11, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8145), new DateTime(2023, 2, 1, 22, 36, 28, 585, DateTimeKind.Local).AddTicks(8146) },
                    { 146, 3, 5, 7, 9, 5, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8154), new DateTime(2023, 1, 30, 17, 44, 28, 585, DateTimeKind.Local).AddTicks(8156) },
                    { 147, 3, 2, 1, 9, 18, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8194), new DateTime(2023, 1, 26, 21, 0, 28, 585, DateTimeKind.Local).AddTicks(8196) },
                    { 148, 2, 1, 2, 9, 11, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8205), new DateTime(2023, 1, 28, 9, 53, 28, 585, DateTimeKind.Local).AddTicks(8207) },
                    { 149, 2, 1, 8, 9, 7, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8215), new DateTime(2023, 1, 31, 1, 10, 28, 585, DateTimeKind.Local).AddTicks(8217) },
                    { 156, 1, 5, 1, 10, 16, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8226), new DateTime(2023, 1, 26, 12, 54, 28, 585, DateTimeKind.Local).AddTicks(8227) },
                    { 157, 1, 4, 8, 10, 7, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8235), new DateTime(2023, 1, 28, 12, 17, 28, 585, DateTimeKind.Local).AddTicks(8237) },
                    { 158, 3, 3, 2, 10, 19, new DateTime(2023, 1, 28, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8245), new DateTime(2023, 1, 27, 10, 27, 28, 585, DateTimeKind.Local).AddTicks(8247) },
                    { 159, 1, 2, 2, 10, 11, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8255), new DateTime(2023, 1, 29, 23, 15, 28, 585, DateTimeKind.Local).AddTicks(8257) },
                    { 160, 1, 2, 7, 10, 16, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8265), new DateTime(2023, 1, 30, 11, 43, 28, 585, DateTimeKind.Local).AddTicks(8267) },
                    { 161, 1, 4, 8, 10, 14, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8275), new DateTime(2023, 2, 1, 7, 56, 28, 585, DateTimeKind.Local).AddTicks(8277) },
                    { 162, 3, 1, 8, 10, 9, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8285), new DateTime(2023, 1, 28, 17, 37, 28, 585, DateTimeKind.Local).AddTicks(8287) },
                    { 163, 2, 1, 9, 10, 15, new DateTime(2023, 1, 30, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8295), new DateTime(2023, 1, 31, 13, 6, 28, 585, DateTimeKind.Local).AddTicks(8297) },
                    { 164, 3, 3, 5, 10, 8, new DateTime(2023, 1, 27, 2, 4, 28, 585, DateTimeKind.Local).AddTicks(8305), new DateTime(2023, 1, 28, 12, 17, 28, 585, DateTimeKind.Local).AddTicks(8307) }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "Cancelled", "IdClient", "IdSession" },
                values: new object[,]
                {
                    { 1, 0, 1, 1 },
                    { 2, 0, 1, 2 },
                    { 3, 0, 1, 3 },
                    { 4, 0, 1, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coach_IdSpeciality",
                table: "Coach",
                column: "IdSpeciality");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteCoach_IdClient",
                table: "FavoriteCoach",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteCoach_IdCoach",
                table: "FavoriteCoach",
                column: "IdCoach");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteExercise_IdClient",
                table: "FavoriteExercise",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteExercise_IdExercise",
                table: "FavoriteExercise",
                column: "IdExercise");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteLocation_IdClient",
                table: "FavoriteLocation",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteLocation_IdLocation",
                table: "FavoriteLocation",
                column: "IdLocation");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteTrainingProgram_IdClient",
                table: "FavoriteTrainingProgram",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteTrainingProgram_IdTrainingProgram",
                table: "FavoriteTrainingProgram",
                column: "IdTrainingProgram");

            migrationBuilder.CreateIndex(
                name: "IX_Goal_IdClient",
                table: "Goal",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualProgram_IdExercise",
                table: "IndividualProgram",
                column: "IdExercise");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualProgram_IdTrainingProgram",
                table: "IndividualProgram",
                column: "IdTrainingProgram");

            migrationBuilder.CreateIndex(
                name: "IX_MachineLocation_IdLocation",
                table: "MachineLocation",
                column: "IdLocation");

            migrationBuilder.CreateIndex(
                name: "IX_MachineLocation_IdMachine",
                table: "MachineLocation",
                column: "IdMachine");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_IdClient",
                table: "Reservation",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_IdSession",
                table: "Reservation",
                column: "IdSession");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdCoach",
                table: "Session",
                column: "IdCoach");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdLocation",
                table: "Session",
                column: "IdLocation");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdTrainingProgram",
                table: "Session",
                column: "IdTrainingProgram");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_IdClient",
                table: "Subscription",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_IdFormula",
                table: "Subscription",
                column: "IdFormula");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteCoach");

            migrationBuilder.DropTable(
                name: "FavoriteExercise");

            migrationBuilder.DropTable(
                name: "FavoriteLocation");

            migrationBuilder.DropTable(
                name: "FavoriteTrainingProgram");

            migrationBuilder.DropTable(
                name: "Goal");

            migrationBuilder.DropTable(
                name: "IndividualProgram");

            migrationBuilder.DropTable(
                name: "MachineLocation");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Formula");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "TrainingProgram");

            migrationBuilder.DropTable(
                name: "Speciality");
        }
    }
}
