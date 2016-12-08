-- ########### Actors ###########
INSERT INTO [dbo].[Actors](Name)VALUES('Felicity Jones');
INSERT INTO [dbo].[Actors](Name)VALUES('Mads Mikkleson');
INSERT INTO [dbo].[Actors](Name)VALUES('Benedict Cumberbach');
INSERT INTO [dbo].[Actors](Name)VALUES('Rachel McAdams');


-- ########### Movies ###########
INSERT INTO [dbo].[Movies](Title,Year,Director)VALUES('Rogue One: A star Wars Story', '20160101 12:00:00 AM', 'Gareth Edwards');
INSERT INTO [dbo].[Movies](Title,Year,Director)VALUES('Doctor Strange', '20160101 12:00:00 AM', 'Scott Derrickson');
INSERT INTO [dbo].[Movies](Title,Year,Director)VALUES('The Imitation Game', '20140101 12:00:00 AM', 'Morten Tyldum');
INSERT INTO [dbo].[Movies](Title,Year,Director)VALUES('The Theory of Everything', '20140101 12:00:00 AM', 'James Marsh');

-- ########### Directors ###########
INSERT INTO [dbo].[Directors](Name)VALUES('Gareth Edwards');
INSERT INTO [dbo].[Directors](Name)VALUES('Scott Derrickson');
INSERT INTO [dbo].[Directors](Name)VALUES('Morten Tyldum');
INSERT INTO [dbo].[Directors](Name)VALUES('James Marsh');

-- ########### Casts ###########
INSERT INTO [dbo].[Casts](Actor, Movie, ActorID, MovieID)VALUES('Felicity Jones', 'Rogue One: A star Wars Story', 1,1);
INSERT INTO [dbo].[Casts](Actor, Movie, ActorID, MovieID)VALUES('Mads Mikkleson', 'Rogue One: A star Wars Story', 2,1);
INSERT INTO [dbo].[Casts](Actor, Movie, ActorID, MovieID)VALUES('Benedict Cumberbach', 'Doctor Strange', 3,2);
INSERT INTO [dbo].[Casts](Actor, Movie, ActorID, MovieID)VALUES('Rachel McAdams', 'Doctor Strange', 4,2);
INSERT INTO [dbo].[Casts](Actor, Movie, ActorID, MovieID)VALUES('Benedict Cumberbach', 'The Imitation Game', 3,3);
INSERT INTO [dbo].[Casts](Actor, Movie, ActorID, MovieID)VALUES('Felicity Jones', 'The Theory of Everything', 1,4);
INSERT INTO [dbo].[Casts](Actor, Movie, ActorID, MovieID)VALUES('Mads Mikkleson', 'Doctor Strange', 2,3);