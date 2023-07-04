CREATE PROCEDURE [dbo].[CreateCoiffeur]
      @nom VARCHAR(50),
      @prenom VARCHAR(50),
      @rue VARCHAR(50),
      @ville VARCHAR(50),
      @cp VARCHAR(50),
      @telephone INT,
      @email VARCHAR(50),
      @mdp VARCHAR(50)
AS
	BEGIN
        INSERT INTO Coiffeur(nom, prenom, rue, ville, cp, telephone, email, mdp)
        VALUES (@nom, @prenom, @rue, @ville, @cp, @telephone, @email, @mdp)
        
        DECLARE @Id_Ref int
        SET @Id_Ref = SCOPE_IDENTITY();

        INSERT INTO PlageHoraire(Id_Coiffeur)
        VALUES (@Id_Ref)

        SELECT * FROM Coiffeur
        WHERE Id_Coiffeur = @Id_Ref;
    END 

