
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
    Race ENUM('BUldog', 'Golden retriver', 'Doberman', 'pastor aleman', 'Husky', 'chow chow', 'Chihuahua', 'Border collie', 'Persa', 'Siames', 'siberiano', 'abisinio', 'Roborowski', 'Ruso', 'Campbell', 'Dorado'),
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


INSERT INTO Owners (Names, LastNames, Email, Address, Phone, Status) VALUES ('Juan','Zapata', 'juanzapata@gmail.com', '12345', '12345', 'Active')

INSERT INTO Vets(Name, Phone, Address, Email, Status) VALUES ('VetFriend', '123455', '12455', 'VetFriend@gmail.com', 'Active'), ('PetsLove', '1234555', '124355', 'Petslove@gmail.com', 'Active')

INSERT INTO Pets (Name, Specie, Race, DateBirth, Photo, Status, OwnerId) VALUES ('Teo', 'Dog', 'Doberman', '2021-06-01', 'https://petstable.mx/cdn/shop/articles/Cachorro-husky-siberiano-1_33e7bc9a-7a17-4ea5-82a5-1cabcb8ceb40-141078.jpg?v=1701178089', 'Active', 2), ('Curie', 'Cat', 'Siames', '2018-05-08', 'https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSAOnLXSaPbc4K0IId0dSTI050OfwusYAyfQzMiCF6mrwNPVdmN', 'Active', 3), ('Luna', 'Dog', 'Doberman', '2016-03-02', 'https://imagenes.eltiempo.com/files/image_1200_600/uploads/2023/04/05/642daa1edf8de.png', 'Active', 1)

INSERT INTO Quotes (Date, PetId, VetId, Descripcion, Status) VALUES ('2024-06-04', 2, 1, 'Quote for a dog', 'Active'), ('2024-06-03', 2, 2, 'Quote for a cat', 'Active')
