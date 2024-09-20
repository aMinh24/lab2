using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lap2.Models
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string IconLink { get; set; }
        public string Meta { get; set; }
        public int OrderRow { get; set; }
        public bool Hide { get; set; }
        [DataType(DataType.Date)] // Chỉ định kiểu dữ liệu là ngày (không bao gồm giờ)
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] // Đặt giá trị mặc định được tính toán bởi database
        public DateTime DateBegin { get; set; }

    }
}
