Create Database RandomAtamaDB
Use RandomAtamaDB
Create Table TblRandom
(
TckNo int Not Null,
Ad varchar(30) Null,
Soyad varchar(30) NUll,
Sehir varchar(30) Null,
DogumTarihi varchar(30) NUll,
)
INSERT INTO TblRandom(TckNo, Ad, Soyad, Sehir, DogumTarihi)
Values(6, 'Tu��e', '�etintav ',  'Bart�n ',  '2003')

SELECT * FROM TblRandom