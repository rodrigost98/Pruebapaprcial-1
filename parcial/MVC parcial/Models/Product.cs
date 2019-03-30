﻿using System.ComponentModel.DataAnnotations;

namespace MVC_parcial.Models
{
    public enum UniType
    {
        Botella,
        Metro,
        Litro,
        Caja
    }

    public enum StatusType
    {
        Activo,
        Inacitvo
    }

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [Required]

        public UniType Unit { get; set; }

        public StatusType Status { get; set; }

    }
}