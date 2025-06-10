﻿namespace HotelBooking.Application.Services;

public interface IRedisCacheService
{
    Task SetAsync<T>(string key, T value, TimeSpan expiry);
    Task<T> GetAsync<T>(string key);
    Task RemoveAsync(string key);
}
