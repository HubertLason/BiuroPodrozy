Aby uruchomić aplikację należy skonfigurować połączenie z bazą danych. W tym celu należy utworzyć 
bazę danych według diagramu zawartego w dokumentacji.

Polecenia tworzące tabele bazy danych:

Create table BookedTours ( 
Id int primary key identity, 
ClientId id, 
TourName varchar(50) 
) 

Create table Clients ( 
Id int primary key identity, 
Username varchar(50) 
Password varchar(60) 
) 

Wymagana jest długość pola hasło przynajmniej 60 z powodu metody haszowania. Następnie w pliku 
appsetings.json podajemy connection string do bazy.
