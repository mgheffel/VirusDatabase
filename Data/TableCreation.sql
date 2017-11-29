DROP TABLE IF EXISTS Strain_Publication;
DROP TABLE IF EXISTS Publisher_Publication;
DROP TABLE IF EXISTS Publishers;
DROP TABLE IF EXISTS Publication_Researcher;
DROP TABLE IF EXISTS Researchers;
DROP TABLE IF EXISTS Publications;
DROP TABLE IF EXISTS OpenReadingFrames;
DROP TABLE IF EXISTS Strains;
DROP TABLE IF EXISTS Species;
DROP TABLE IF EXISTS NonStructuralProteins;
DROP TABLE IF EXISTS StructuralProteins;
DROP TABLE IF EXISTS Proteins;


create table Proteins(
	pID int AUTO_INCREMENT primary key,
	pName varchar(50) not null
);
create table StructuralProteins(
	pID int primary key,
	struct varchar(50) not null,
	foreign key (pID) references Proteins(pID) ON DELETE CASCADE
);
create table NonStructuralProteins(
	pID int primary key,
	funct varchar(50) not null,
	foreign key (pID) references Proteins(pID) ON DELETE CASCADE
);

create table Species(
	specID int AUTO_INCREMENT primary key,
	sName varchar(150) not null,
	sAbbreviation varchar(20),
	sGenus varchar(40) not null,
	sFamily varchar(40) not null,
	sOrder varchar(40) not null
);

create table Strains(
	strainID varchar(10) primary key,
	basePairs int,
	specID int,
	genome varchar(50000) not null,
	foreign key (specID) references Species(specID) ON DELETE CASCADE
);
create table OpenReadingFrames(
	strainID varchar(10) not null,
	orfID varchar(10) not null,
	pID int,
	startIndex int not null,
	CHECK (startIndex>=0),
	stopIndex int not null,
	CHECK (stopIndex>startIndex),
	foreign key (strainID) references Strains(strainID) ON DELETE CASCADE,
	foreign key (pID) references Proteins(pID) ON DELETE CASCADE,
	PRIMARY KEY (strainID, orfID)
);

create table Publications(
	pubID int AUTO_INCREMENT primary key,
	pYear int,
	title varchar(50)
);
create table Researchers(
	rID int AUTO_INCREMENT primary key,
	rName varchar(50) not null,
	rEmail varchar(50),
	rOrg varchar(50)
);

create table Publication_Researcher(
	pubID int,
	rID int,
	foreign key (rID) references Researchers(rID) ON DELETE CASCADE,
	foreign key (pubID) references Publications(pubID) ON DELETE CASCADE,
	primary key  (pubID, rID)
);
create table Publishers(
	publisherID int AUTO_INCREMENT primary key,
	name varchar(100) not null
);

create table Publisher_Publication(
	publisherID int,
	pubID int,
	foreign key (publisherID) references Publishers(publisherID) ON DELETE CASCADE,
	foreign key (pubID) references Publications(pubID) ON DELETE CASCADE,
	primary key (publisherID, pubID)
);

create table Strain_Publication(
	strainID varchar(30),
	pubID int,
	foreign key (strainID) references Strains(strainID) ON DELETE CASCADE,
	foreign key (pubID) references Publications(pubID) ON DELETE CASCADE,
	primary key (strainID, pubID)
);