SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial FROM Libro, Categoria, Autor, Editorial WHERE Libro.CA#=Categoria.CA# AND Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# AND Libro.CA#='CA01' ORDER BY LI#;

SELECT count(LI#) FROM Libro WHERE CA#='CA01';
SELECT count(LI#) FROM Libro WHERE CA#='CA02';
SELECT count(LI#) FROM Libro WHERE CA#='CA03';
SELECT count(LI#) FROM Libro WHERE CA#='CA04';
SELECT count(LI#) FROM Libro WHERE CA#='CA05';
SELECT count(LI#) FROM Libro WHERE CA#='CA06';
SELECT count(LI#) FROM Libro WHERE CA#='CA07';

SELECT Categoria.NombreCategoria, COUNT(*) FROM Libro, Categoria WHERE Libro.CA#=Categoria.CA# GROUP BY Categoria.NombreCategoria;