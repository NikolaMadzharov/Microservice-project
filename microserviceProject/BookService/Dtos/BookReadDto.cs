﻿using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Dtos
{
    public class BookReadDto
    {
       
        public int Id { get; set; }
     
        public string Title { get; set; } = null!;

        public string Author { get; set; } = null!;
        
        public decimal Price { get; set; }
    }
}
