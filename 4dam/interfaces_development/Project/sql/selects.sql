SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial FROM Libro, Categoria, Autor, Editorial WHERE Libro.CA#=Categoria.CA# AND Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# ORDER BY LI#;

SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial FROM Libro, Categoria, Autor, Editorial WHERE Libro.CA#=Categoria.CA# AND Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# AND Libro.CA#='CA01' ORDER BY LI#;

SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial FROM Libro, Categoria, Autor, Editorial WHERE Libro.CA#=Categoria.CA# AND Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# AND Libro.CA#='CA02' ORDER BY LI#;

SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial FROM Libro, Categoria, Autor, Editorial WHERE Libro.CA#=Categoria.CA# AND Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# AND Libro.CA#='CA03' ORDER BY LI#;

SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial FROM Libro, Categoria, Autor, Editorial WHERE Libro.CA#=Categoria.CA# AND Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# AND Libro.CA#='CA04' ORDER BY LI#;

SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial FROM Libro, Categoria, Autor, Editorial WHERE Libro.CA#=Categoria.CA# AND Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# AND Libro.CA#='CA05' ORDER BY LI#;

SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial FROM Libro, Categoria, Autor, Editorial WHERE Libro.CA#=Categoria.CA# AND Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# AND Libro.CA#='CA06' ORDER BY LI#;

SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial FROM Libro, Categoria, Autor, Editorial WHERE Libro.CA#=Categoria.CA# AND Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# AND Libro.CA#='CA07' ORDER BY LI#;

SELECT Categoria.NombreCategoria, COUNT(*) FROM Libro, Categoria WHERE Libro.CA#=Categoria.CA# GROUP BY Categoria.NombreCategoria;



SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Autor.AU#, Editorial.NombreEditorial FROM Libro, Autor, Editorial WHERE Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# ORDER BY LI#;


SELECT Prestamo.PE#, Prestamo.FechaRecogida, Prestamo.FechaEntrega, Libro.NombreLibro, Usuario.NombreUsuario, Empleado.nNombreEmpleado FROM Prestamo, Libro, Usuario, Empleado WHERE Libro.LI#=Prestamo.LI# AND Usuario.US#=PRESTAMO.US# AND 