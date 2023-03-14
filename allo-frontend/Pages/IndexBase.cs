namespace allo_frontend;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
public class IndexBase : ComponentBase
{
    public IEnumerable<User> user { get; set; }
    protected override async Task OnInitializedAsync()
    {
        //user = await Services.GetAllUser();       
    }
}