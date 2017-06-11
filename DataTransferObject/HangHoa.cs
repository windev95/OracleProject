namespace DataTransferObject
{
    public class HangHoa : LoaiHangHoa
    {
        public decimal MAHANGHOA { get; set; }
        public string TENHANGHOA { get; set; }
        public long? GIANHAP { get; set; }
        public decimal? SOLUONGTON { get; set; }
        public string MOTA { get; set; }
        public decimal MANSX { get; set; }
        public string TENNSX { get; set; }
    }
    public class GioHang
    {
        public decimal MAHANGHOA { get; set; }
        public string TENHANGHOA { get; set; }
        public long? GIANBAN { get; set; }
        public decimal? SOLUONG { get; set; }
        public string TENNSX { get; set; }
        public string TENLOAIHANG { get; set; }
        public decimal THANHTIEN => (decimal)(GIANBAN * SOLUONG);
    }
}
