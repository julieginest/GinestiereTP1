CREATE DATABASE gestionBourget;
USE gestionBourget;

CREATE TABLE emplacement(
    id integer not null,
    hall varchar(2) not null,
    parcelle varchar(3) not null,
    CONSTRAINT pk_emplacement PRIMARY KEY emplacement (id)
);

CREATE TABLE entreprise(
    id integer not null,
    raisonSociale varchar(250) not null,
    siret varchar(100),
    idEmplacement integer not null,
    CONSTRAINT pk_entreprise PRIMARY KEY entreprise(id),
    CONSTRAINT fk_entreprise_emplacement FOREIGN KEY entreprise(idEmplacement) REFERENCES emplacement(id)
);

CREATE TABLE contact(
    id integer not null,
    nom varchar(25) not null,
    prenom varchar(25) not null,
    tel varchar(25),
    mail varchar(50),
    idEntreprise integer not null,
    CONSTRAINT pk_contact PRIMARY KEY contact(id),
    CONSTRAINT fk_contact_entreprise FOREIGN KEY contact(idEntreprise) REFERENCES entreprise(id)
)