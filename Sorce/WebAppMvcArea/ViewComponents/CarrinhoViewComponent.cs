using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcArea.ViewComponents
{
    //[ViewComponent(Name = "Index")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponent()
        {
            ItensCarrinho = 7;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ItensCarrinho);
        }
    }
}
