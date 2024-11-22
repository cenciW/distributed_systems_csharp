using System;
using System.IO;
using System.Xml.Serialization;
using Ficha14;

public class Program
{
    static void Main(string[] args)
    {
        ErrorRecord record = new ErrorRecord
        {
            ReportedBy = "Jose testes",
            AffectedComponent = "Componente 1",
            ErrorDescription = "Descricao do erro.",
            CorrectiveActions = new List<string>
            {
                "Corrigir o erro",
                "Corrigir o erro 2"
            },
            Status = "Por resolver"
        };

        // Caminho absoluto para a pasta do projeto
        string projectDirectory = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName;

        // Caminho para a pasta "databases" no diretório do projeto
        string databasePath = Path.Combine(projectDirectory, "database");

        // Garantir que a pasta "databases" exista
        if (!Directory.Exists(databasePath))
        {
            Directory.CreateDirectory(databasePath);
        }

        // Caminho completo para o arquivo XML
        string filePath = Path.Combine(databasePath, "errorRecord.xml");

        // Salvar o arquivo XML
        SaveErrorRecordToXml(record, filePath);

        Console.WriteLine($"Arquivo salvo com sucesso no caminho: {filePath}");
    }

    public static void SaveErrorRecordToXml(ErrorRecord record, string filePath)
    {
        var serializer = new XmlSerializer(typeof(ErrorRecord));
        using (var writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, record);
        }
    }
}