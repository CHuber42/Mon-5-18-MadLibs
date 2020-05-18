namespace Madlib.Models
{
  public class MadlibVariable
  {
    public string Noun1 { get; set; }
    public string Noun2 { get; set; }
    public string Noun3 { get; set; }

    public string Verb1 { get; set; }
    public string Adjective2 { get; set; }
    public string Adjective1 { get; set; }
    public MadlibVariable(string noun1, string noun2, string noun3, string verb1, string adjective1, string adjective2)
    {
      Noun1 = noun1;
      Noun2 = noun2;
      Noun3 = noun3;
      Verb1 = verb1;
      Adjective1 = adjective1;
      Adjective2 = adjective2;
    }
  }

  public class MadlibVariableB
  {
    public string Color1 { get; set; }
    public string Verb1 { get; set; }
    public string Liquid { get; set; }

    public string Noun2 { get; set; }
    public string PastVerb { get; set; }
    public string Time { get; set; }
    public MadlibVariableB(string color1, string verb1, string liquid, string noun2, string pastverb, string time)
    {
      Color1 = color1;
      Verb1 = verb1;
      Liquid = liquid;
      Noun2 = noun2;
      PastVerb = pastverb;
      Time = time;
    }
  }
}