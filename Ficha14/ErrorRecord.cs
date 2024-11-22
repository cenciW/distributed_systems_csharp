using System.Xml.Serialization;

namespace Ficha14
{
    [XmlRoot("RegistroErro")]
    public class ErrorRecord
    {
        [XmlElement("DetectadoPor")]
        public string ReportedBy { get; set; }

        [XmlElement("ComponenteAfetado")]
        public string AffectedComponent { get; set; }

        [XmlElement("Descricao")]
        public string ErrorDescription { get; set; }

        [XmlArray("ListaAccaoCorrecao")]
        [XmlArrayItem("AccaoCorrecao")]
        public List<string> CorrectiveActions { get; set; }

        [XmlElement("Estado")]
        public string Status { get; set; }

        public ErrorRecord()
        {
            CorrectiveActions = new List<string>();
            Status = "Por resolver";
            ReportedBy = "Desconhecido";
            AffectedComponent = "Desconhecido";
            ErrorDescription = "Desconhecido";
        }
    }
}