// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetShipperNameByShipperIdRepository : IGetShipperNameByShipperIdRepository
    {
        public int PgArg0 { get; set; }

        public string Execute()
        {
            return "FizzBuzz";
        }
    }
}