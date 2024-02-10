﻿using System;

namespace PlanA_Assessment.Application.Features.Products.Queries.GetProductList
{
    public class GetProductsListViewModel
    {
 
        public Guid Id { get; set; }
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public string Number_of_Views { get; set; }

        public string Dietary_flags { get; set; }
     

        public CategoryDto Category { get; set; }
    }
}
