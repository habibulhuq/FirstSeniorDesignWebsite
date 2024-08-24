using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RazorPagesMovie.Pages;

public class BookletModel : PageModel
{
    private readonly ILogger<BookletModel> _logger;

    public BookletModel(ILogger<BookletModel> logger)
    {
        _logger = logger;
    }

    public string TestString;

    //List of all Booklets
    public List<string> expBooklets = new();

    public List<string> expBookletLink = new();


    public void OnGet()
    {

        expBooklets.Add("Book1.pptx");
        expBookletLink.Add("TestPPTx.pptx");
        expBookletLink.Add("https://docs.google.com/presentation/d/1kQdyt9Bc3eCrSJQb25sY9ALxNh83jaxhU2RgrnXGfcg/edit?usp=sharing");
        expBooklets.Add("Book2.pptx");
        expBookletLink.Add("https://docs.google.com/presentation/d/1kQdyt9Bc3eCrSJQb25sY9ALxNh83jaxhU2RgrnXGfcg/edit?usp=sharing");
        expBooklets.Add("Book3.pptx");
        expBooklets.Add("Book4.pptx");

    }

}