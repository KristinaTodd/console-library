using System;
using console_library.Interfaces;

namespace console_library.Models
{
  public class Book : ICheckoutable
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }
    public AgeGroup AgeGroup { get; private set; }
    public string DeweyDec { get; set; }

    public Book(string title, string author, AgeGroup ageGroup, string deweyDec)
    {
      Title = title;
      Author = author;
      AgeGroup = ageGroup;
      Available = true;
      DeweyDec = deweyDec;
    }

  }

}