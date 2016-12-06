-- ########### PiratesS ###########
INSERT INTO [dbo].[Pirates](Name,Conscript)VALUES('Blackbeard', CURRENT_TIMESTAMP);
INSERT INTO [dbo].[Pirates](Name,Conscript)VALUES('Davey Jones', CURRENT_TIMESTAMP);
INSERT INTO [dbo].[Pirates](Name,Conscript)VALUES('Jack Sparrow', CURRENT_TIMESTAMP);
INSERT INTO [dbo].[Pirates](Name,Conscript)VALUES('One-Eyed Will', CURRENT_TIMESTAMP);
INSERT INTO [dbo].[Pirates](Name,Conscript)VALUES('Bootstrap Bill', CURRENT_TIMESTAMP);

-- ########### SHIPS ###########
INSERT INTO [dbo].[Ships](Name,Type,Tonnage)VALUES('Queen Marys Revenge', 'Frigate', 200);
INSERT INTO [dbo].[Ships](Name,Type,Tonnage)VALUES('King Georges Return', 'Frigate', 150);
INSERT INTO [dbo].[Ships](Name,Type,Tonnage)VALUES('The Kraken', 'Battleship', 350);
INSERT INTO [dbo].[Ships](Name,Type,Tonnage)VALUES('The Flying Dutchman', 'Battleship', 500);
INSERT INTO [dbo].[Ships](Name,Type,Tonnage)VALUES('The Black Pearl', 'Frigate', 400);

-- ########### Crewss ###########
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(1,1,100);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(1,2,250);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(1,3,0);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(1,4,500);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(1,5,75);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(2,4,120);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(2,2,200);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(2,5,300);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(3,1,500);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(3,5,75);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(4,1,200);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(4,2,85);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(4,3,90);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(4,4,350);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(4,5,50);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(2,1,250);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(3,2,175);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(5,3,100);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(5,4,375);
INSERT INTO [dbo].[Crews](PirateID,ShipID,Booty)VALUES(5,5,180);