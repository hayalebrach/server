﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SaleService
    {
        DAL.Model.SaleModel model = new DAL.Model.SaleModel();
        public List<DTO.SaleDTO> Get()
        {
            return convert.SaleConvert.Convert(model.Get());
        }

        public DTO.SaleDTO AddSale(DTO.SaleDTO Sale)
        {
            return convert.SaleConvert.Convert(model.AddSale(convert.SaleConvert.Convert(Sale)));
        }
    }
}
