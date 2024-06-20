
namespace dotnetMVC.ViewModels
{
    public class MenuLoaiVM
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public int SoLuong { get;  set;}

        public MenuLoaiVM(int MaLoai,string TenLoai, int SoLuong)
        {
            this.MaLoai = MaLoai;   
            this.TenLoai = TenLoai;
            this.SoLuong = SoLuong;
        }
    }
}
