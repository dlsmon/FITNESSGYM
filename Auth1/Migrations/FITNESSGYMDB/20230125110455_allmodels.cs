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
                columns: new[] { "Id", "CaloriesBurnt", "Frequency", "IdClient", "Weight" },
                values: new object[] { 1, 1000, 3, 1, 75 });

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
                    { 1, 3, 1, 2, 1, 15, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8626), new DateTime(2023, 1, 25, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8694) },
                    { 2, 3, 5, 7, 2, 20, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8709), new DateTime(2023, 1, 25, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8711) },
                    { 3, 3, 5, 9, 3, 30, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8722), new DateTime(2023, 1, 25, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8724) },
                    { 4, 3, 3, 8, 4, 22, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8734), new DateTime(2023, 1, 25, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8736) },
                    { 5, 3, 1, 3, 2, 18, null, null },
                    { 21, 3, 4, 4, 1, 13, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 1, 30, 5, 2, 55, 100, DateTimeKind.Local).AddTicks(8803) },
                    { 22, 2, 2, 9, 1, 14, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 1, 31, 15, 3, 55, 100, DateTimeKind.Local).AddTicks(8820) },
                    { 23, 1, 4, 9, 1, 7, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 2, 1, 10, 8, 55, 100, DateTimeKind.Local).AddTicks(8838) },
                    { 24, 2, 3, 6, 1, 18, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 1, 31, 1, 44, 55, 100, DateTimeKind.Local).AddTicks(8866) },
                    { 25, 2, 5, 1, 1, 11, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 1, 31, 5, 50, 55, 100, DateTimeKind.Local).AddTicks(8891) },
                    { 26, 1, 3, 6, 1, 15, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8907), new DateTime(2023, 1, 26, 10, 4, 55, 100, DateTimeKind.Local).AddTicks(8908) },
                    { 27, 1, 1, 1, 1, 13, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8918), new DateTime(2023, 1, 27, 7, 22, 55, 100, DateTimeKind.Local).AddTicks(8919) },
                    { 28, 3, 3, 1, 1, 12, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8928), new DateTime(2023, 1, 30, 4, 6, 55, 100, DateTimeKind.Local).AddTicks(8929) },
                    { 29, 3, 2, 2, 1, 10, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 1, 26, 13, 54, 55, 100, DateTimeKind.Local).AddTicks(8941) },
                    { 36, 3, 3, 9, 2, 7, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 1, 30, 15, 12, 55, 100, DateTimeKind.Local).AddTicks(8951) },
                    { 37, 2, 3, 2, 2, 5, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 1, 26, 2, 49, 55, 100, DateTimeKind.Local).AddTicks(8962) },
                    { 38, 2, 1, 5, 2, 12, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 1, 30, 6, 28, 55, 100, DateTimeKind.Local).AddTicks(8973) },
                    { 39, 3, 4, 8, 2, 15, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8983), new DateTime(2023, 1, 28, 14, 47, 55, 100, DateTimeKind.Local).AddTicks(8984) },
                    { 40, 2, 5, 7, 2, 10, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 1, 28, 20, 12, 55, 100, DateTimeKind.Local).AddTicks(8995) },
                    { 41, 2, 5, 7, 2, 16, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9004), new DateTime(2023, 1, 26, 20, 23, 55, 100, DateTimeKind.Local).AddTicks(9005) },
                    { 42, 2, 2, 1, 2, 15, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9014), new DateTime(2023, 1, 25, 13, 49, 55, 100, DateTimeKind.Local).AddTicks(9016) },
                    { 43, 1, 3, 8, 2, 8, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9024), new DateTime(2023, 1, 26, 17, 45, 55, 100, DateTimeKind.Local).AddTicks(9026) },
                    { 44, 3, 2, 9, 2, 19, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9034), new DateTime(2023, 1, 31, 20, 17, 55, 100, DateTimeKind.Local).AddTicks(9036) },
                    { 51, 2, 5, 1, 3, 5, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9044), new DateTime(2023, 1, 28, 4, 41, 55, 100, DateTimeKind.Local).AddTicks(9046) },
                    { 52, 2, 5, 3, 3, 6, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9055), new DateTime(2023, 1, 29, 3, 19, 55, 100, DateTimeKind.Local).AddTicks(9057) },
                    { 53, 3, 2, 2, 3, 16, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9064), new DateTime(2023, 1, 30, 9, 5, 55, 100, DateTimeKind.Local).AddTicks(9066) },
                    { 54, 3, 4, 5, 3, 6, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9074), new DateTime(2023, 1, 31, 3, 23, 55, 100, DateTimeKind.Local).AddTicks(9076) },
                    { 55, 2, 5, 1, 3, 18, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9085), new DateTime(2023, 1, 31, 4, 36, 55, 100, DateTimeKind.Local).AddTicks(9087) },
                    { 56, 3, 1, 5, 3, 17, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9095), new DateTime(2023, 1, 31, 10, 11, 55, 100, DateTimeKind.Local).AddTicks(9097) },
                    { 57, 2, 5, 8, 3, 7, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9105), new DateTime(2023, 1, 25, 13, 21, 55, 100, DateTimeKind.Local).AddTicks(9107) },
                    { 58, 1, 5, 8, 3, 9, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9115), new DateTime(2023, 1, 30, 11, 9, 55, 100, DateTimeKind.Local).AddTicks(9116) },
                    { 59, 3, 1, 6, 3, 15, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9125), new DateTime(2023, 1, 31, 6, 8, 55, 100, DateTimeKind.Local).AddTicks(9127) },
                    { 66, 2, 4, 1, 4, 15, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9142), new DateTime(2023, 1, 30, 21, 58, 55, 100, DateTimeKind.Local).AddTicks(9143) },
                    { 67, 1, 4, 1, 4, 15, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9153), new DateTime(2023, 1, 25, 15, 6, 55, 100, DateTimeKind.Local).AddTicks(9155) },
                    { 68, 1, 5, 2, 4, 14, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9164), new DateTime(2023, 1, 29, 16, 44, 55, 100, DateTimeKind.Local).AddTicks(9166) },
                    { 69, 1, 5, 9, 4, 17, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9175), new DateTime(2023, 1, 27, 3, 12, 55, 100, DateTimeKind.Local).AddTicks(9177) },
                    { 70, 1, 3, 9, 4, 19, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9185), new DateTime(2023, 1, 29, 6, 3, 55, 100, DateTimeKind.Local).AddTicks(9187) },
                    { 71, 1, 1, 3, 4, 17, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9195), new DateTime(2023, 1, 31, 6, 53, 55, 100, DateTimeKind.Local).AddTicks(9196) },
                    { 72, 1, 3, 9, 4, 8, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9205), new DateTime(2023, 1, 27, 12, 5, 55, 100, DateTimeKind.Local).AddTicks(9207) },
                    { 73, 1, 4, 3, 4, 5, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9215), new DateTime(2023, 1, 31, 2, 25, 55, 100, DateTimeKind.Local).AddTicks(9217) },
                    { 74, 2, 5, 8, 4, 17, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9224), new DateTime(2023, 1, 30, 6, 16, 55, 100, DateTimeKind.Local).AddTicks(9226) },
                    { 81, 3, 1, 3, 5, 19, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9235), new DateTime(2023, 1, 29, 9, 48, 55, 100, DateTimeKind.Local).AddTicks(9236) },
                    { 82, 3, 4, 8, 5, 11, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9245), new DateTime(2023, 1, 26, 10, 39, 55, 100, DateTimeKind.Local).AddTicks(9247) },
                    { 83, 2, 3, 7, 5, 13, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9255), new DateTime(2023, 1, 26, 8, 53, 55, 100, DateTimeKind.Local).AddTicks(9257) },
                    { 84, 3, 1, 1, 5, 17, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 1, 30, 23, 14, 55, 100, DateTimeKind.Local).AddTicks(9267) },
                    { 85, 3, 5, 9, 5, 18, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9274), new DateTime(2023, 1, 25, 23, 40, 55, 100, DateTimeKind.Local).AddTicks(9276) },
                    { 86, 1, 3, 5, 5, 19, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9284), new DateTime(2023, 1, 31, 16, 19, 55, 100, DateTimeKind.Local).AddTicks(9286) },
                    { 87, 3, 1, 3, 5, 6, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9294), new DateTime(2023, 1, 26, 8, 22, 55, 100, DateTimeKind.Local).AddTicks(9296) },
                    { 88, 1, 5, 5, 5, 6, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9304), new DateTime(2023, 1, 28, 12, 20, 55, 100, DateTimeKind.Local).AddTicks(9305) },
                    { 89, 1, 3, 1, 5, 8, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 1, 31, 0, 33, 55, 100, DateTimeKind.Local).AddTicks(9316) },
                    { 96, 3, 4, 1, 6, 11, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9324), new DateTime(2023, 1, 31, 12, 20, 55, 100, DateTimeKind.Local).AddTicks(9326) },
                    { 97, 2, 3, 8, 6, 9, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9335), new DateTime(2023, 1, 27, 15, 49, 55, 100, DateTimeKind.Local).AddTicks(9337) },
                    { 98, 1, 1, 4, 6, 13, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9345), new DateTime(2023, 1, 26, 15, 5, 55, 100, DateTimeKind.Local).AddTicks(9347) },
                    { 99, 2, 2, 7, 6, 14, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9355), new DateTime(2023, 1, 25, 18, 51, 55, 100, DateTimeKind.Local).AddTicks(9357) },
                    { 100, 2, 1, 1, 6, 6, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9371), new DateTime(2023, 1, 30, 9, 24, 55, 100, DateTimeKind.Local).AddTicks(9372) },
                    { 101, 3, 1, 7, 6, 11, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9381), new DateTime(2023, 2, 1, 4, 58, 55, 100, DateTimeKind.Local).AddTicks(9383) },
                    { 102, 3, 4, 8, 6, 10, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9391), new DateTime(2023, 1, 27, 19, 18, 55, 100, DateTimeKind.Local).AddTicks(9393) },
                    { 103, 1, 2, 8, 6, 18, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 2, 1, 10, 32, 55, 100, DateTimeKind.Local).AddTicks(9403) },
                    { 104, 3, 4, 4, 6, 15, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9411), new DateTime(2023, 1, 29, 0, 10, 55, 100, DateTimeKind.Local).AddTicks(9413) },
                    { 111, 3, 1, 1, 7, 12, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9421), new DateTime(2023, 1, 28, 0, 56, 55, 100, DateTimeKind.Local).AddTicks(9423) },
                    { 112, 1, 5, 6, 7, 8, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9431), new DateTime(2023, 1, 31, 22, 59, 55, 100, DateTimeKind.Local).AddTicks(9433) },
                    { 113, 3, 1, 8, 7, 5, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9442), new DateTime(2023, 1, 25, 20, 18, 55, 100, DateTimeKind.Local).AddTicks(9444) },
                    { 114, 3, 4, 4, 7, 11, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9452), new DateTime(2023, 1, 29, 11, 35, 55, 100, DateTimeKind.Local).AddTicks(9454) },
                    { 115, 1, 3, 6, 7, 10, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9462), new DateTime(2023, 1, 29, 21, 25, 55, 100, DateTimeKind.Local).AddTicks(9464) },
                    { 116, 3, 2, 7, 7, 10, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9472), new DateTime(2023, 1, 31, 9, 37, 55, 100, DateTimeKind.Local).AddTicks(9474) },
                    { 117, 1, 5, 7, 7, 9, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9484), new DateTime(2023, 1, 27, 9, 17, 55, 100, DateTimeKind.Local).AddTicks(9486) },
                    { 118, 1, 5, 3, 7, 7, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9494), new DateTime(2023, 1, 30, 11, 36, 55, 100, DateTimeKind.Local).AddTicks(9496) },
                    { 119, 3, 5, 1, 7, 10, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9504), new DateTime(2023, 2, 1, 9, 50, 55, 100, DateTimeKind.Local).AddTicks(9506) },
                    { 126, 1, 5, 4, 8, 16, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9514), new DateTime(2023, 1, 29, 18, 20, 55, 100, DateTimeKind.Local).AddTicks(9516) },
                    { 127, 3, 5, 9, 8, 11, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9524), new DateTime(2023, 1, 30, 16, 17, 55, 100, DateTimeKind.Local).AddTicks(9526) },
                    { 128, 1, 4, 8, 8, 15, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9534), new DateTime(2023, 1, 28, 8, 55, 55, 100, DateTimeKind.Local).AddTicks(9535) },
                    { 129, 3, 2, 9, 8, 13, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9544), new DateTime(2023, 1, 30, 3, 10, 55, 100, DateTimeKind.Local).AddTicks(9545) },
                    { 130, 1, 3, 5, 8, 16, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9554), new DateTime(2023, 1, 29, 3, 7, 55, 100, DateTimeKind.Local).AddTicks(9555) },
                    { 131, 2, 5, 7, 8, 19, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9564), new DateTime(2023, 1, 28, 17, 4, 55, 100, DateTimeKind.Local).AddTicks(9566) },
                    { 132, 3, 4, 3, 8, 10, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9579), new DateTime(2023, 2, 1, 1, 24, 55, 100, DateTimeKind.Local).AddTicks(9581) },
                    { 133, 1, 1, 5, 8, 17, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9590), new DateTime(2023, 1, 31, 20, 22, 55, 100, DateTimeKind.Local).AddTicks(9591) },
                    { 134, 2, 3, 2, 8, 8, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9599), new DateTime(2023, 1, 28, 17, 36, 55, 100, DateTimeKind.Local).AddTicks(9601) },
                    { 141, 3, 1, 4, 9, 10, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9610), new DateTime(2023, 1, 27, 4, 53, 55, 100, DateTimeKind.Local).AddTicks(9612) },
                    { 142, 3, 3, 4, 9, 8, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9620), new DateTime(2023, 1, 29, 18, 51, 55, 100, DateTimeKind.Local).AddTicks(9621) },
                    { 143, 3, 2, 8, 9, 11, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9630), new DateTime(2023, 1, 31, 17, 8, 55, 100, DateTimeKind.Local).AddTicks(9632) },
                    { 144, 2, 3, 4, 9, 5, new DateTime(2023, 1, 28, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9640), new DateTime(2023, 1, 29, 19, 22, 55, 100, DateTimeKind.Local).AddTicks(9642) },
                    { 145, 1, 3, 1, 9, 11, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9650), new DateTime(2023, 2, 1, 8, 36, 55, 100, DateTimeKind.Local).AddTicks(9652) },
                    { 146, 3, 5, 7, 9, 5, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 1, 30, 3, 44, 55, 100, DateTimeKind.Local).AddTicks(9662) },
                    { 147, 3, 2, 1, 9, 18, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 1, 26, 7, 0, 55, 100, DateTimeKind.Local).AddTicks(9672) },
                    { 148, 2, 1, 2, 9, 11, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 1, 27, 19, 53, 55, 100, DateTimeKind.Local).AddTicks(9681) },
                    { 149, 2, 1, 8, 9, 7, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 1, 30, 11, 10, 55, 100, DateTimeKind.Local).AddTicks(9691) },
                    { 156, 1, 5, 1, 10, 16, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 1, 25, 22, 54, 55, 100, DateTimeKind.Local).AddTicks(9702) },
                    { 157, 1, 4, 8, 10, 7, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9711), new DateTime(2023, 1, 27, 22, 17, 55, 100, DateTimeKind.Local).AddTicks(9713) },
                    { 158, 3, 3, 2, 10, 19, new DateTime(2023, 1, 27, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9720), new DateTime(2023, 1, 26, 20, 27, 55, 100, DateTimeKind.Local).AddTicks(9722) },
                    { 159, 1, 2, 2, 10, 11, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9730), new DateTime(2023, 1, 29, 9, 15, 55, 100, DateTimeKind.Local).AddTicks(9732) },
                    { 160, 1, 2, 7, 10, 16, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9740), new DateTime(2023, 1, 29, 21, 43, 55, 100, DateTimeKind.Local).AddTicks(9742) },
                    { 161, 1, 4, 8, 10, 14, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 1, 31, 17, 56, 55, 100, DateTimeKind.Local).AddTicks(9752) },
                    { 162, 3, 1, 8, 10, 9, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9760), new DateTime(2023, 1, 28, 3, 37, 55, 100, DateTimeKind.Local).AddTicks(9762) },
                    { 163, 2, 1, 9, 10, 15, new DateTime(2023, 1, 29, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9770), new DateTime(2023, 1, 30, 23, 6, 55, 100, DateTimeKind.Local).AddTicks(9772) },
                    { 164, 3, 3, 5, 10, 8, new DateTime(2023, 1, 26, 12, 4, 55, 100, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 1, 27, 22, 17, 55, 100, DateTimeKind.Local).AddTicks(9782) }
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
