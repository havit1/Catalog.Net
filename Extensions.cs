using System;
using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }

        public static Item AsNewItem(this CreateItemDto itemDto)
        {

            return new Item
            {
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                CreatedDate = DateTimeOffset.UtcNow
            };
        }
    }
}