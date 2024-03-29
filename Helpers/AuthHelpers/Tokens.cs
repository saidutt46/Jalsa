﻿using System;
using Jalsa.Domain.IRepositories;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;
using Jalsa.Domain.Models;

namespace Jalsa.Helpers.AuthHelpers
{
    public static class Tokens
    {
        public static async Task<string> GenerateJwt(ClaimsIdentity identity, IJwtFactory jwtFactory, string userName, JwtIssuerOptions jwtOptions, JsonSerializerSettings serializerSettings)
        {
            var response = new
            {
                id = identity.Claims.Single(c => c.Type == "id").Value,
                auth_token = await jwtFactory.GenerateEncodedToken(userName, identity),
                expires_in = (int)jwtOptions.ValidFor.TotalSeconds
            };

            return JsonConvert.SerializeObject(response, serializerSettings);
        }
    }
}
