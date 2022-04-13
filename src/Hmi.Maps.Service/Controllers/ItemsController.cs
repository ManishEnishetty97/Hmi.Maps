using System.Collections.Generic;
using Hmi.Maps.Service.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;


namespace Hmi.Maps.Service.Controllers
{
  [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private static readonly List<ItemDto> items= new()
        {
            new ItemDto(Guid.NewGuid(), "Potion", "restores a small amount", 5, System.DateTimeOffset.UtcNow),
            new ItemDto(Guid.NewGuid(), "Antidote", "Cures posion", 7, System.DateTimeOffset.UtcNow),
            new ItemDto(Guid.NewGuid(), "Bronze sword", "Deals a small amount of damage", 20, System.DateTimeOffset.UtcNow),

        };
        [HttpGet]
        public IEnumerable<ItemDto> Get()
        {
            return items;
        }

    };
}