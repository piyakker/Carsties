﻿using System.Security.Claims;

namespace AuctionService.IntegrationTests;

public class AuthHelper
{
    public static Dictionary<string, object> GetBearerForUser(string userName)
    {
        return new Dictionary<string, object>
        {
            {ClaimTypes.Name, userName},
        };
    }
}
