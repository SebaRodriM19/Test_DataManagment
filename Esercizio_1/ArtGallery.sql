create database ArtGallery
use ArtGallery

create table Museum(
	Id_Museum smallint primary key not null,
	MuseumName varchar(50) not null,
	City varchar(50) not null
)

create table Artist(
	Id_Artist smallint primary key,
	NameArtist varchar(50) not null,
	Country varchar(50) not null
)

create table Character(
	Id_Character smallint primary key,
	NameCharacter varchar(50) not null
)

create table Artwork(
	Id_Artwork smallint primary key not null,
	NameArtwork varchar(50) not null,
	Id_Museum smallint foreign key references Museum(Id_Museum) not null,
	Id_Artist smallint foreign key references Artist(Id_Artist) not null,
	Id_Charachter smallint foreign key references Character(Id_Character)
)

insert into Museum values (1,'Santa Maria Gloriosa dei Frari','Venezia'),(2,'Louvre','Parigi'),(3,'Galleria Borghese','Roma'),(4,'Art Institute of Chicago','Chicago')
insert into Artist values (1,'Tiziano Vecellio', 'Italia'), (2, 'Caravaggio', 'Italia'),(3, 'Picasso', 'Spagna')
insert into Character values (1, 'Flora'), (2, 'Davide'), (3, 'Chitarrista')
insert into Artwork values (1,'Flora', 1, 1, 1),(2, 'Concerto campestre',2 ,1, NULL), (3, 'Davide con la testa di Golia',3,2,2),(4, 'Il vecchio chitarrista cieco',4,3,3)

-- First query
select m.MuseumName, a.Id_Artwork,a.NameArtwork,ar.NameArtist
from Artwork a join Artist ar on a.Id_Artist = ar.Id_Artist join Museum m on m.Id_Museum = a.Id_Museum
where ar.Country = 'Italia'

-- Second query
select ar.NameArtist
from Artwork a join Artist ar on a.Id_Artist = ar.Id_Artist join Museum m on m.Id_Museum = a.Id_Museum
where m.City = 'Parigi'

-- third query
select m.City
from Artwork a left join Character c on c.Id_Character = a.Id_Charachter join Museum m on m.Id_Museum = a.Id_Museum
where c.NameCharacter = 'Flora'