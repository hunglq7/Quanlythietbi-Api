using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models.Thongsokythuattoitruc
{
    public class ThongsokythuattoitrucEdit
    {
        public int Id { get; set; }
        public int DanhmuctoitrucId { get; set; }
        public string NoiDung { get; set; } = string.Empty;
        public string DonViTinh { get; set; } = string.Empty;
        public string ThongSo { get; set; } = string.Empty;
    }
}