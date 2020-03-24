using console_library.Interfaces;

namespace console_library.Models
{

  public class DVD : ICheckoutable
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }
    public AgeGroup AgeGroup { get; private set; }
    public string DeweyDec { get; set; }


    public DVD(string title, string author, AgeGroup ageGroup, string deweyDec)
    {
      Title = title;
      Author = author;
      AgeGroup = ageGroup;
      Available = true;
      DeweyDec = deweyDec;

    }
  }

  public enum AgeGroup
  {
    Baby,
    Child,
    YoungAdult,
    Adult
  }
}