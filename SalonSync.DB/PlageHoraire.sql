CREATE TABLE [dbo].[PlageHoraire]
(
	 [Id_PlageHoraire] INT PRIMARY KEY IDENTITY NOT NULL,
     [PlageHoraireDate] DATE NULL,
     [HeureDebut] TIME NOT NULL,
     [Repete] BIT NULL,
     [Id_Coiffeur] INT NOT NULL,
     CONSTRAINT [FK_Coiffeur] FOREIGN KEY ([Id_Coiffeur])
     REFERENCES [dbo].[Coiffeur]([Id_Coiffeur])
)
