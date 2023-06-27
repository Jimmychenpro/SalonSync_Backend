CREATE TABLE [dbo].[Coiffeur]
(
	Id_Coiffeur INT IDENTITY (1,1) NOT NULL,
	nom VARCHAR(50) NOT NULL,
	prenom VARCHAR(50) NOT NULL,
	rue VARCHAR(50),
	ville VARCHAR(50),
	cp VARCHAR(50),
	telephone INT,
	email VARCHAR(50) NOT NULL,
	mdp VARCHAR(50) NOT NULL,
	PRIMARY KEY(Id_Coiffeur)

)
