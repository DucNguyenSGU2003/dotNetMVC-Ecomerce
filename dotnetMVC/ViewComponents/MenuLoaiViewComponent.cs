using dotnetMVC.Data;
using dotnetMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dotnetMVC.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly Hshop2023Context db;

        public MenuLoaiViewComponent(Hshop2023Context context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiVM(lo.MaLoai,lo.TenLoai,lo.HangHoas.Count));
            return View(data); // send file Default.html
        }
    }
}
