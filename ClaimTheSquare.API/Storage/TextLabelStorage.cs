using System.Text.Json;
using ClaimTheSquare.API.Models;

namespace ClaimTheSquare.API.Storage;

public class TextLabelStorage
{
    private const string Filename = "textLabels.json";

    public List<TextLabel> GetTextLabels()
    {
        List<TextLabel> textLabels;
        if (File.Exists(Filename))
        {
            var json = File.ReadAllText(Filename);
            textLabels = JsonSerializer.Deserialize<List<TextLabel>>(json);
        }
        else
        {
            textLabels = new List<TextLabel>();
        }
        
        return textLabels;
    }

    public void SaveTextLabel(TextLabel textLabel)
    {
        var existingLabels = GetTextLabels();
        existingLabels.Add(textLabel);
        File.WriteAllText(Filename, JsonSerializer.Serialize(existingLabels));
    }
}