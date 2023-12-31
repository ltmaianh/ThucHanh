using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models{
    //Le Thi Mai Anh-2021050076
    public class DaiLy{
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }
        public string MaHTPP { get; set; }
        [ForeignKey("MaHTPP")]
        public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }

        
    }
}