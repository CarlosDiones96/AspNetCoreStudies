using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection1
{
    public class IndexModel : PageModel
    {
        private readonly MyDependency _dependency = new MyDependency();

        public void OnGet()
        {
            _dependency.WriteMessage("IndexModel.OnGet");
        }
    }
}
