using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FITNESSGYM.Migrations.FITNESSGYMDB
{
    /// <inheritdoc />
    public partial class allmodels : Migration
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
                    { 1, 3, 1, 2, 1, 15, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 1, 26, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1297) },
                    { 2, 3, 5, 7, 2, 20, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1314), new DateTime(2023, 1, 26, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1315) },
                    { 3, 3, 5, 9, 3, 30, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1326), new DateTime(2023, 1, 26, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1328) },
                    { 4, 3, 3, 8, 4, 22, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1339), new DateTime(2023, 1, 26, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1340) },
                    { 5, 3, 1, 3, 2, 18, null, null },
                    { 21, 3, 4, 4, 1, 13, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 1, 30, 21, 23, 7, 907, DateTimeKind.Local).AddTicks(1412) },
                    { 22, 2, 2, 9, 1, 14, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1425), new DateTime(2023, 2, 1, 7, 24, 7, 907, DateTimeKind.Local).AddTicks(1427) },
                    { 23, 1, 4, 9, 1, 7, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1437), new DateTime(2023, 2, 2, 2, 29, 7, 907, DateTimeKind.Local).AddTicks(1439) },
                    { 24, 2, 3, 6, 1, 18, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1449), new DateTime(2023, 1, 31, 18, 5, 7, 907, DateTimeKind.Local).AddTicks(1451) },
                    { 25, 2, 5, 1, 1, 11, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1461), new DateTime(2023, 1, 31, 22, 11, 7, 907, DateTimeKind.Local).AddTicks(1463) },
                    { 26, 1, 3, 6, 1, 15, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1473), new DateTime(2023, 1, 27, 2, 25, 7, 907, DateTimeKind.Local).AddTicks(1475) },
                    { 27, 1, 1, 1, 1, 13, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1485), new DateTime(2023, 1, 27, 23, 43, 7, 907, DateTimeKind.Local).AddTicks(1487) },
                    { 28, 3, 3, 1, 1, 12, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1496), new DateTime(2023, 1, 30, 20, 27, 7, 907, DateTimeKind.Local).AddTicks(1498) },
                    { 29, 3, 2, 2, 1, 10, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1507), new DateTime(2023, 1, 27, 6, 15, 7, 907, DateTimeKind.Local).AddTicks(1509) },
                    { 36, 3, 3, 9, 2, 7, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1519), new DateTime(2023, 1, 31, 7, 33, 7, 907, DateTimeKind.Local).AddTicks(1520) },
                    { 37, 2, 3, 2, 2, 5, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1530), new DateTime(2023, 1, 26, 19, 10, 7, 907, DateTimeKind.Local).AddTicks(1531) },
                    { 38, 2, 1, 5, 2, 12, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1541), new DateTime(2023, 1, 30, 22, 49, 7, 907, DateTimeKind.Local).AddTicks(1543) },
                    { 39, 3, 4, 8, 2, 15, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1553), new DateTime(2023, 1, 29, 7, 8, 7, 907, DateTimeKind.Local).AddTicks(1555) },
                    { 40, 2, 5, 7, 2, 10, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1564), new DateTime(2023, 1, 29, 12, 33, 7, 907, DateTimeKind.Local).AddTicks(1566) },
                    { 41, 2, 5, 7, 2, 16, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 1, 27, 12, 44, 7, 907, DateTimeKind.Local).AddTicks(1577) },
                    { 42, 2, 2, 1, 2, 15, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1587), new DateTime(2023, 1, 26, 6, 10, 7, 907, DateTimeKind.Local).AddTicks(1588) },
                    { 43, 1, 3, 8, 2, 8, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1617), new DateTime(2023, 1, 27, 10, 6, 7, 907, DateTimeKind.Local).AddTicks(1619) },
                    { 44, 3, 2, 9, 2, 19, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1630), new DateTime(2023, 2, 1, 12, 38, 7, 907, DateTimeKind.Local).AddTicks(1632) },
                    { 51, 2, 5, 1, 3, 5, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1642), new DateTime(2023, 1, 28, 21, 2, 7, 907, DateTimeKind.Local).AddTicks(1644) },
                    { 52, 2, 5, 3, 3, 6, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1653), new DateTime(2023, 1, 29, 19, 40, 7, 907, DateTimeKind.Local).AddTicks(1655) },
                    { 53, 3, 2, 2, 3, 16, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1664), new DateTime(2023, 1, 31, 1, 26, 7, 907, DateTimeKind.Local).AddTicks(1666) },
                    { 54, 3, 4, 5, 3, 6, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 1, 31, 19, 44, 7, 907, DateTimeKind.Local).AddTicks(1677) },
                    { 55, 2, 5, 1, 3, 18, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1687), new DateTime(2023, 1, 31, 20, 57, 7, 907, DateTimeKind.Local).AddTicks(1689) },
                    { 56, 3, 1, 5, 3, 17, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1699), new DateTime(2023, 2, 1, 2, 32, 7, 907, DateTimeKind.Local).AddTicks(1701) },
                    { 57, 2, 5, 8, 3, 7, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1710), new DateTime(2023, 1, 26, 5, 42, 7, 907, DateTimeKind.Local).AddTicks(1711) },
                    { 58, 1, 5, 8, 3, 9, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1721), new DateTime(2023, 1, 31, 3, 30, 7, 907, DateTimeKind.Local).AddTicks(1722) },
                    { 59, 3, 1, 6, 3, 15, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1732), new DateTime(2023, 1, 31, 22, 29, 7, 907, DateTimeKind.Local).AddTicks(1734) },
                    { 66, 2, 4, 1, 4, 15, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1744), new DateTime(2023, 1, 31, 14, 19, 7, 907, DateTimeKind.Local).AddTicks(1746) },
                    { 67, 1, 4, 1, 4, 15, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1756), new DateTime(2023, 1, 26, 7, 27, 7, 907, DateTimeKind.Local).AddTicks(1758) },
                    { 68, 1, 5, 2, 4, 14, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1768), new DateTime(2023, 1, 30, 9, 5, 7, 907, DateTimeKind.Local).AddTicks(1770) },
                    { 69, 1, 5, 9, 4, 17, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1779), new DateTime(2023, 1, 27, 19, 33, 7, 907, DateTimeKind.Local).AddTicks(1781) },
                    { 70, 1, 3, 9, 4, 19, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1790), new DateTime(2023, 1, 29, 22, 24, 7, 907, DateTimeKind.Local).AddTicks(1792) },
                    { 71, 1, 1, 3, 4, 17, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1801), new DateTime(2023, 1, 31, 23, 14, 7, 907, DateTimeKind.Local).AddTicks(1802) },
                    { 72, 1, 3, 9, 4, 8, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 1, 28, 4, 26, 7, 907, DateTimeKind.Local).AddTicks(1814) },
                    { 73, 1, 4, 3, 4, 5, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1823), new DateTime(2023, 1, 31, 18, 46, 7, 907, DateTimeKind.Local).AddTicks(1825) },
                    { 74, 2, 5, 8, 4, 17, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1835), new DateTime(2023, 1, 30, 22, 37, 7, 907, DateTimeKind.Local).AddTicks(1836) },
                    { 81, 3, 1, 3, 5, 19, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1846), new DateTime(2023, 1, 30, 2, 9, 7, 907, DateTimeKind.Local).AddTicks(1848) },
                    { 82, 3, 4, 8, 5, 11, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1858), new DateTime(2023, 1, 27, 3, 0, 7, 907, DateTimeKind.Local).AddTicks(1859) },
                    { 83, 2, 3, 7, 5, 13, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1891), new DateTime(2023, 1, 27, 1, 14, 7, 907, DateTimeKind.Local).AddTicks(1893) },
                    { 84, 3, 1, 1, 5, 17, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1904), new DateTime(2023, 1, 31, 15, 35, 7, 907, DateTimeKind.Local).AddTicks(1906) },
                    { 85, 3, 5, 9, 5, 18, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1916), new DateTime(2023, 1, 26, 16, 1, 7, 907, DateTimeKind.Local).AddTicks(1918) },
                    { 86, 1, 3, 5, 5, 19, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1927), new DateTime(2023, 2, 1, 8, 40, 7, 907, DateTimeKind.Local).AddTicks(1929) },
                    { 87, 3, 1, 3, 5, 6, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1939), new DateTime(2023, 1, 27, 0, 43, 7, 907, DateTimeKind.Local).AddTicks(1941) },
                    { 88, 1, 5, 5, 5, 6, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1951), new DateTime(2023, 1, 29, 4, 41, 7, 907, DateTimeKind.Local).AddTicks(1953) },
                    { 89, 1, 3, 1, 5, 8, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1962), new DateTime(2023, 1, 31, 16, 54, 7, 907, DateTimeKind.Local).AddTicks(1964) },
                    { 96, 3, 4, 1, 6, 11, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1973), new DateTime(2023, 2, 1, 4, 41, 7, 907, DateTimeKind.Local).AddTicks(1974) },
                    { 97, 2, 3, 8, 6, 9, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1984), new DateTime(2023, 1, 28, 8, 10, 7, 907, DateTimeKind.Local).AddTicks(1985) },
                    { 98, 1, 1, 4, 6, 13, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(1996), new DateTime(2023, 1, 27, 7, 26, 7, 907, DateTimeKind.Local).AddTicks(1997) },
                    { 99, 2, 2, 7, 6, 14, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2008), new DateTime(2023, 1, 26, 11, 12, 7, 907, DateTimeKind.Local).AddTicks(2009) },
                    { 100, 2, 1, 1, 6, 6, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2020), new DateTime(2023, 1, 31, 1, 45, 7, 907, DateTimeKind.Local).AddTicks(2021) },
                    { 101, 3, 1, 7, 6, 11, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2030), new DateTime(2023, 2, 1, 21, 19, 7, 907, DateTimeKind.Local).AddTicks(2032) },
                    { 102, 3, 4, 8, 6, 10, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2042), new DateTime(2023, 1, 28, 11, 39, 7, 907, DateTimeKind.Local).AddTicks(2044) },
                    { 103, 1, 2, 8, 6, 18, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2054), new DateTime(2023, 2, 2, 2, 53, 7, 907, DateTimeKind.Local).AddTicks(2056) },
                    { 104, 3, 4, 4, 6, 15, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2067), new DateTime(2023, 1, 29, 16, 31, 7, 907, DateTimeKind.Local).AddTicks(2068) },
                    { 111, 3, 1, 1, 7, 12, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2078), new DateTime(2023, 1, 28, 17, 17, 7, 907, DateTimeKind.Local).AddTicks(2080) },
                    { 112, 1, 5, 6, 7, 8, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2090), new DateTime(2023, 2, 1, 15, 20, 7, 907, DateTimeKind.Local).AddTicks(2092) },
                    { 113, 3, 1, 8, 7, 5, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2102), new DateTime(2023, 1, 26, 12, 39, 7, 907, DateTimeKind.Local).AddTicks(2103) },
                    { 114, 3, 4, 4, 7, 11, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2114), new DateTime(2023, 1, 30, 3, 56, 7, 907, DateTimeKind.Local).AddTicks(2116) },
                    { 115, 1, 3, 6, 7, 10, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2126), new DateTime(2023, 1, 30, 13, 46, 7, 907, DateTimeKind.Local).AddTicks(2128) },
                    { 116, 3, 2, 7, 7, 10, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2138), new DateTime(2023, 2, 1, 1, 58, 7, 907, DateTimeKind.Local).AddTicks(2140) },
                    { 117, 1, 5, 7, 7, 9, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2173), new DateTime(2023, 1, 28, 1, 38, 7, 907, DateTimeKind.Local).AddTicks(2175) },
                    { 118, 1, 5, 3, 7, 7, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 1, 31, 3, 57, 7, 907, DateTimeKind.Local).AddTicks(2187) },
                    { 119, 3, 5, 1, 7, 10, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 2, 2, 2, 11, 7, 907, DateTimeKind.Local).AddTicks(2198) },
                    { 126, 1, 5, 4, 8, 16, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2207), new DateTime(2023, 1, 30, 10, 41, 7, 907, DateTimeKind.Local).AddTicks(2209) },
                    { 127, 3, 5, 9, 8, 11, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2219), new DateTime(2023, 1, 31, 8, 38, 7, 907, DateTimeKind.Local).AddTicks(2221) },
                    { 128, 1, 4, 8, 8, 15, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2231), new DateTime(2023, 1, 29, 1, 16, 7, 907, DateTimeKind.Local).AddTicks(2232) },
                    { 129, 3, 2, 9, 8, 13, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2242), new DateTime(2023, 1, 30, 19, 31, 7, 907, DateTimeKind.Local).AddTicks(2244) },
                    { 130, 1, 3, 5, 8, 16, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2255), new DateTime(2023, 1, 29, 19, 28, 7, 907, DateTimeKind.Local).AddTicks(2256) },
                    { 131, 2, 5, 7, 8, 19, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2267), new DateTime(2023, 1, 29, 9, 25, 7, 907, DateTimeKind.Local).AddTicks(2268) },
                    { 132, 3, 4, 3, 8, 10, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2278), new DateTime(2023, 2, 1, 17, 45, 7, 907, DateTimeKind.Local).AddTicks(2280) },
                    { 133, 1, 1, 5, 8, 17, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2289), new DateTime(2023, 2, 1, 12, 43, 7, 907, DateTimeKind.Local).AddTicks(2291) },
                    { 134, 2, 3, 2, 8, 8, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2301), new DateTime(2023, 1, 29, 9, 57, 7, 907, DateTimeKind.Local).AddTicks(2302) },
                    { 141, 3, 1, 4, 9, 10, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 1, 27, 21, 14, 7, 907, DateTimeKind.Local).AddTicks(2313) },
                    { 142, 3, 3, 4, 9, 8, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 1, 30, 11, 12, 7, 907, DateTimeKind.Local).AddTicks(2324) },
                    { 143, 3, 2, 8, 9, 11, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2333), new DateTime(2023, 2, 1, 9, 29, 7, 907, DateTimeKind.Local).AddTicks(2335) },
                    { 144, 2, 3, 4, 9, 5, new DateTime(2023, 1, 29, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2344), new DateTime(2023, 1, 30, 11, 43, 7, 907, DateTimeKind.Local).AddTicks(2346) },
                    { 145, 1, 3, 1, 9, 11, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2356), new DateTime(2023, 2, 2, 0, 57, 7, 907, DateTimeKind.Local).AddTicks(2358) },
                    { 146, 3, 5, 7, 9, 5, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2367), new DateTime(2023, 1, 30, 20, 5, 7, 907, DateTimeKind.Local).AddTicks(2369) },
                    { 147, 3, 2, 1, 9, 18, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2378), new DateTime(2023, 1, 26, 23, 21, 7, 907, DateTimeKind.Local).AddTicks(2380) },
                    { 148, 2, 1, 2, 9, 11, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2390), new DateTime(2023, 1, 28, 12, 14, 7, 907, DateTimeKind.Local).AddTicks(2391) },
                    { 149, 2, 1, 8, 9, 7, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2402), new DateTime(2023, 1, 31, 3, 31, 7, 907, DateTimeKind.Local).AddTicks(2403) },
                    { 156, 1, 5, 1, 10, 16, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2452), new DateTime(2023, 1, 26, 15, 15, 7, 907, DateTimeKind.Local).AddTicks(2454) },
                    { 157, 1, 4, 8, 10, 7, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2467), new DateTime(2023, 1, 28, 14, 38, 7, 907, DateTimeKind.Local).AddTicks(2468) },
                    { 158, 3, 3, 2, 10, 19, new DateTime(2023, 1, 28, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2477), new DateTime(2023, 1, 27, 12, 48, 7, 907, DateTimeKind.Local).AddTicks(2479) },
                    { 159, 1, 2, 2, 10, 11, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 1, 30, 1, 36, 7, 907, DateTimeKind.Local).AddTicks(2490) },
                    { 160, 1, 2, 7, 10, 16, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 1, 30, 14, 4, 7, 907, DateTimeKind.Local).AddTicks(2501) },
                    { 161, 1, 4, 8, 10, 14, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2511), new DateTime(2023, 2, 1, 10, 17, 7, 907, DateTimeKind.Local).AddTicks(2513) },
                    { 162, 3, 1, 8, 10, 9, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2523), new DateTime(2023, 1, 28, 19, 58, 7, 907, DateTimeKind.Local).AddTicks(2524) },
                    { 163, 2, 1, 9, 10, 15, new DateTime(2023, 1, 30, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2534), new DateTime(2023, 1, 31, 15, 27, 7, 907, DateTimeKind.Local).AddTicks(2536) },
                    { 164, 3, 3, 5, 10, 8, new DateTime(2023, 1, 27, 4, 25, 7, 907, DateTimeKind.Local).AddTicks(2545), new DateTime(2023, 1, 28, 14, 38, 7, 907, DateTimeKind.Local).AddTicks(2547) }
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
