using System;

namespace Policy.Application.DTOs
{
    public class AppSetting
    {
        public string Key { get; set; }
        public double AccessTokenExpired { get; set; }
        public double RefreshTokenExpired { get; set; }
    }
}
