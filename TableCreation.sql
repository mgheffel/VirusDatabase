DROP TABLE IF EXISTS Publisher_Publication;
DROP TABLE IF EXISTS Publishers;
DROP TABLE IF EXISTS Publication_Researcher;
DROP TABLE IF EXISTS Researchers;
DROP TABLE IF EXISTS Publications;
DROP TABLE IF EXISTS Strain_Protein;
DROP TABLE IF EXISTS Strain_ORF;
DROP TABLE IF EXISTS OpenReadingFrames;
DROP TABLE IF EXISTS Strains;
DROP TABLE IF EXISTS Species;
DROP TABLE IF EXISTS NonStructuralProteins;
DROP TABLE IF EXISTS StructuralProteins;
DROP TABLE IF EXISTS Proteins;


create table Proteins(
	pID int primary key,
	pName varchar(50) not null
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
	description varchar(100)
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
	orfNumber varchar(10) not null,
	pID int,
	startIndex int not null,
	stopIndex int not null,
	foreign key (pID) references Proteins(pID),
	PRIMARY KEY (strainID, orfNumber)
);

create table Strain_Protein(
	strainID varchar(10),
	pID int,
	foreign key (strainID) references Strains(strainID),
	foreign key (pID) references Proteins(pID)
);

create table Strain_ORF(
	strainID varchar(10),
	seqID int,
	foreign key (strainID) references Strains(strainID),
	foreign key (seqID) references OpenReadingFrame(seqID)
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
	foreign key (pubID) references Publications(pubID)
);
create table Publishers(
	publisherID int primary key,
	name varchar(50) not null
);

create table Pubublisher_Publication(
	publisherID int,
	pubID int,
	foreign key (publisherID) references Publishers(publisherID),
	foreign key (pubID) references Publications(pubID)
)
