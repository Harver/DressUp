﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DressUp.Scl.Model.ServiceModel
{
    public class ConciseOrder
    {
        public int GoodsNum { get; set; }
        public Guid GoodsId { get; set; }
        public int ShopCartsId { get; set; }
        public string IfChecked { get; set; }
    }
}