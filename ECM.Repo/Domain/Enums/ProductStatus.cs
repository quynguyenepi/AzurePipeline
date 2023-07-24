using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.Repo.Domain.Enums
{
    public enum ProductStatus
    {
        [Description("Đang bán")]
        Available,
        [Description("Hết hàng")]
        OutOfStock,
        [Description("Ngừng kinh doanh")]
        StopBusiness
    }
}
