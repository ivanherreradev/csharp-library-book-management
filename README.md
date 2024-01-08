# Ejercicio de Gestión de Libros en una Biblioteca

Implementa un sistema de gestión de libros en una biblioteca utilizando programación orientada a objetos en C#. Deberás crear las siguientes clases:

## `Book` (Libro)

### Atributos:

- `Id` (int): Identificador único del libro.
- `Title` (string): Título del libro.
- `Author` (string): Autor del libro.
- `Year` (int): Año de publicación del libro.

### Métodos:
- `GetBook()`: Devuelve un string con la información del libro.

## `Library` (Biblioteca)

### Atributos:

- `bookList` (List<Book>): Lista que almacenará objetos de tipo Book.

### Métodos:

- `AddBook(Book book)`: Agrega un libro a la lista.
- `RemoveBook(int bookId)`: Elimina un libro de la lista según su identificador.
- `DisplayBooks()`: Muestra por consola la información de todos los libros en la biblioteca.

## `Program`
1. Crea una instancia de la clase Library.
2. Crea instancias de la clase Book con información relevante.
3. Utiliza el método AddBook de la instancia de Library para agregar los libros a la lista.
4. Llama al método DisplayBooks de la instancia de Library para mostrar la información de todos los libros en la biblioteca.
5. Intenta eliminar un libro con un identificador inválido utilizando el método RemoveBook.
6. Elimina un libro específico utilizando el método RemoveBook y muestra la lista actualizada de libros utilizando el método DisplayBooks.

## Instrucciones

1. Ejecuta el programa.
2. Observa las salidas en la consola.

## Ejecución del Programa
```
+------------------------------------------------------+
|                       OUTPUT                         |
+------------------------------------------------------+
| --- Add Books ---                                    |
| Title: Harry Potter and the philosopher's stone      |
| Author: J. K. Rowling                                |
| Year of publication: 1997                            |
|                                                      | 
| Title: Harry Potter and the secret chamber           |
| Author: J. K. Rowling                                |
| Year of publication: 1998                            |
|                                                      |
| --- Try remove invalid ID ---                        |
| No books were found with the Id:'9'                  |
|                                                      |
| --- Remove book with ID 1 ---                        |
| Book(s) with the Id:'1' have been removed            |
|                                                      |
| Title: Harry Potter and the secret chamber           |
| Author: J. K. Rowling                                |
| Year of publication: 1998                            |
+------------------------------------------------------+
```


