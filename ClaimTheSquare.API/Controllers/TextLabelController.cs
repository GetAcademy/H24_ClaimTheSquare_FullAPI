using ClaimTheSquare.API.Models;
using ClaimTheSquare.API.Storage;
using Microsoft.AspNetCore.Mvc;

namespace ClaimTheSquare.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TextLabelController : ControllerBase
{
    private TextLabelStorage _textLabelStorage;

    public TextLabelController()
    {
        _textLabelStorage = new TextLabelStorage();
    }
    
    [HttpGet]
    public List<TextLabel> GetAllTextLabels()
    {
        return _textLabelStorage.GetTextLabels();
    }

    [HttpPost]
    public void AddTextLabel(TextLabel textLabel)
    {
        _textLabelStorage.SaveTextLabel(textLabel);
    }
}