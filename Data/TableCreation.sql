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
	pID int primary key,
	pType varchar(15) not null
);
create table StructuralProteins(
	pID int primary key,
	pName varchar(50) not null,
	struct varchar(50) not null
);
create table NonStructuralProteins(
	pID int primary key,
	pName varchar(50) not null,
	funct varchar(50) not null
);

create table Species(
	specID int primary key,
	sName varchar(150) not null,
	sAbbreviation varchar(20),
	sGenus varchar(30),
	sFamily varchar(30),
	sOrder varchar(30)
);

create table Strains(
	strainID varchar(10) primary key,
	basePairs int,
	specID int,
	genome varchar(16000) not null,
	foreign key (specID) references Species(specID)
);
create table OpenReadingFrames(
	strainID varchar(10) not null,
	orfID varchar(10) not null,
	pID int,
	startIndex int not null,
	stopIndex int not null,
	foreign key (pID) references Proteins(pID),
	PRIMARY KEY (strainID, orfID)
);

create table Publications(
	pubID int primary key,
	pYear int,
	title varchar(50)
);
create table Researchers(
	rID int primary key,
	rName varchar(50) not null,
	rEmail varchar(50),
	rOrg varchar(50)
);

create table Publication_Researcher(
	rID int,
	pubID int,
	foreign key (rID) references Researchers(rID),
	foreign key (pubID) references Publications(pubID),
	primary key  (pubID, rID)
);
create table Publishers(
	publisherID int primary key,
	name varchar(100) not null
);

create table Publisher_Publication(
	publisherID int,
	pubID int,
	foreign key (publisherID) references Publishers(publisherID),
	foreign key (pubID) references Publications(pubID),
	primary key (publisherID, pubID)
);

create table Strain_Publication(
	strainID varchar(30),
	pubID int,
	foreign key (strainID) references Strains(strainID),
	foreign key (pubID) references Publications(pubID),
	primary key (strainID, pubID)
);