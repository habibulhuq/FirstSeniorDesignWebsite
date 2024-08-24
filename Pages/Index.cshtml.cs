using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public string TestString;

    //List of all Booklets


    public List<string> Booklets { get; set; }
    public List<string> BookletLink { get; set; }

    public void OnGet()
    {
        TestString = "Here are all the Booklets:";


        Booklets = new List<string>
            {
                "Book1.pptx",
                "Book2.pptx",
                "Book3.pptx",
                "Book4.pptx",
                "Book5.pptx"
            };

        BookletLink = new List<string>
            {
                "https://colonialcoatings.com/",
                "https://docs.google.com/presentation/d/1kQdyt9Bc3eCrSJQb25sY9ALxNh83jaxhU2RgrnXGfcg/edit?usp=sharing",
                "PPTxs/Masking_Book_Template.pptx",
                "Photos/logo.jpg",
                "/Users/habibulhuq/Desktop/SeniorDesignWebsite/RazorPagesMovie/PPTxs"
            };




        try
        {
            String connectionString = "";

        }
        catch (Exception ex)
        {

        }

    }



    public List<ClientInfo> listClients = new List<ClientInfo>();

}


public class ClientInfo
{
    public String id;
    public String name;
    public String email;

    public String phone;
    public String address;

}