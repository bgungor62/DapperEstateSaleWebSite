﻿namespace DapperApi.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string CoverImage { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string CategoryID { get; set; }
    }
}
