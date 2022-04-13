using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using GoogleApi.Entities.Common;


namespace Hmi.Maps.Service.Dtos
{
    public record ItemDto(Guid Id, string Name, string destination, decimal price, DateTimeOffset CreatedDate);
    public record CreateItemDto(string Name, string Description, decimal price);

    public record UpdateItemDto(string Name, string Description, decimal price);

    public record LocationDto(string Destination);

    public record createLocationDto(string name, string Address, BasicGeoposition position);

}