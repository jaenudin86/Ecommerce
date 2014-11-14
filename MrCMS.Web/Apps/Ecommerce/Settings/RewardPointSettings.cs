﻿using System.ComponentModel;
using MrCMS.Settings;
using MrCMS.Web.Apps.Ecommerce.Entities.Orders;

namespace MrCMS.Web.Apps.Ecommerce.Settings
{
    public class RewardPointSettings : SiteSettingsBase
    {
        public RewardPointSettings()
        {
            StatusToAward = OrderStatus.Complete;
        }
        [DisplayName("Exchange Rate")]
        public decimal ExchangeRate { get; set; }
        [DisplayName("Minimum Usage")]
        public int MinimumUsage { get; set; }
        [DisplayName("Points For Registration")]
        public int PointsForRegistration { get; set; }
        [DisplayName("Points Per Purchase")]
        public int PointsPerPurchase { get; set; }
        [DisplayName("Status To Award")]
        public OrderStatus StatusToAward { get; set; }
    }
}