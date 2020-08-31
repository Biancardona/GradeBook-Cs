using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
     {
          [Fact]
        public void StringsBehaveLikeValueTypes()
        {
          string name = "Bianca";
          var upper= MakeUpperCase(name);
          Assert.Equal("Bianca", name);
          Assert.Equal("BIANCA", upper);
        }

        private string MakeUpperCase(string parameter)
        {
          return  parameter.ToUpper();
        }

        [Fact]
        public void CSharpPassByValue()
        {
          var book1 = GetBook("Book1");
          GetBookSetName(book1, "New Name"); //Method with two parameters

          Assert.Equal("Book1", book1.Name);

        }
         private void GetBookSetName(Book book, string name)//Invoking method setName
        {
           book =new Book(name);
        }

        [Fact]
        public void CanSetNameFromreference()
        {
          var book1 = GetBook("Book1");
          SetName(book1, "New Name"); //Method with two parameters

          Assert.Equal("New Name", book1.Name);

        }

        private void SetName(Book book, string name)//Invoking method setName
        {
           book.Name = name;//Seeting the name field
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
          var book1 = GetBook("Book 1");
          var book2 = GetBook("Book 2");

          Assert.Equal("Book 1", book1.Name);
          Assert.Equal("Book 2", book2.Name);


        }

         Book GetBook(string name)
        {
            return new Book(name);//New instance of the book class and passing the name parameter
        }
    }
}
