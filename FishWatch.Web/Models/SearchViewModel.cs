using FishWatch.Models;

namespace FishWatch.Web.Models;

public class SearchViewModel
{
    public string Query { get; set; }
    public List<Fish> Results { get; set; }
}