
CREATE TABLE Owners(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Names VARCHAR(50),
    LastNames VARCHAR(50),
    Email VARCHAR(100),
    Address VARCHAR(100),
    Phone VARCHAR(25),
    Status ENUM('Active', 'Desactive')
);

CREATE TABLE Vets(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(120),
    Phone VARCHAR(25),
    Address VARCHAR(30),
    Email VARCHAR(100),
    Status ENUM('Active', 'Desactive')
);

CREATE TABLE Pets (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(125),
    Specie ENUM('Dog', 'Cat', 'Hamster'),
    Race ENUM('BUldog', 'Golden retriver', 'Doberman', 'pastor aleman', 'Husky', 'chow chow', 'Chihuahua', 'Border collie'),
    DateBirth DATE,
    Photo TEXT,
    Status ENUM('Active', 'Desactive'),
    OwnerId INT,
    FOREIGN KEY (OwnerId) REFERENCES Owners(Id)
);

CREATE TABLE Quotes(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Date DATE,
    PetId INT,
    VetId INT,
    Descripcion TEXT,
    Status ENUM('Active', 'Desactive'),
    FOREIGN KEY (PetId) REFERENCES Pets(Id),
    FOREIGN KEY (VetId) REFERENCES Vets(Id)
)

DROP TABLE Pets;