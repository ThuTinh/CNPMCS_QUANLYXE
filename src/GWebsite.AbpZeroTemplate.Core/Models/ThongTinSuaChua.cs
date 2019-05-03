﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public class ThongTinSuaChua : FullAuditModel
    {
        public string soXe { get; set; }
        public string ngaySuaChua { get; set; }
        public string ngayDuKienSuaXong { get; set; }
        public string chiPhiSuaChua { get;set;}
        public string noiDungSuaChuaThucTe { get; set; }
        public bool trangThaiDuyet { get; set; }
        public string ghiChu { get; set; }
    }
}