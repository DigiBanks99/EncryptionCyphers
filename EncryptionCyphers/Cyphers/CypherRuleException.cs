using System;

namespace EncryptionCyphers.Cyphers
{
  public class CypherRuleException : Exception
  {
    private eCypher _cypher = eCypher.Default;

    public string Rule { get; set; }
    public new string Message { get; internal set; }
    public string CypherName { get
      {
        var name = string.Empty;

        switch (_cypher)
        {
          case eCypher.Vernam:
            name = "Vernam";
            break;
          default:
            name = "No cypher specified";
            break;
        }

        return name;
      }
    }

    public CypherRuleException(string rule, eCypher cypher, string message)
    {
      Message = message;
      Rule = rule;
      _cypher = cypher;
    }

    public CypherRuleException(string rule, eCypher cypher)
    {
      Rule = rule;
      _cypher = cypher;
      Message = "A cypher rule has been broken: " + rule;
    }
  }
}
