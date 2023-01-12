using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.DTOs
{
    internal class PhotoDTO
    {
        public int Id{get; set;}
        public string Url {get; set;}
        public bool IsMain {get; set;}
    }
}