using System;
using console_library.Interfaces;

namespace console_library.Models
{
  class Rental : ICheckoutable
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }
    public AgeGroup AgeGroup { get; private set; }
    public string DeweyDec { get; set; }

    public Rental(string title, string author, AgeGroup ageGroup, string deweyDec)
    {
      Title = title;
      Author = author;
      AgeGroup = ageGroup;
      Available = true;
      DeweyDec = deweyDec;
    }

  }
  enum AgeGroup
  {
    Baby,
    Child,
    YoungAdult,
    Adult
  }
}