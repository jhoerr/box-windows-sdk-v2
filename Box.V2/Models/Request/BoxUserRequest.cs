﻿using Newtonsoft.Json;

namespace Box.V2.Models
{
    /// <summary>
    /// A request class for making user requests
    /// </summary>
    public class BoxUserRequest : BoxRequestEntity
    {
        /// <summary>
        /// Setting this to null will roll the user out of the enterprise and make them a free user
        /// </summary>
        [JsonProperty(PropertyName = "enterprise")]
        public string Enterprise { get; set; }

        /// <summary>
        /// The name of this user
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// This user’s enterprise role. Can be coadmin or user
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// The language of this user
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Whether or not this user can use Box Sync
        /// </summary>
        [JsonProperty(PropertyName = "is_sync_enabled")]
        public bool? IsSyncEnabled { get; set; }

        /// <summary>
        /// The user’s job title
        /// </summary>
        [JsonProperty(PropertyName = "job_title")]
        public string JobTitle { get; set; }

        /// <summary>
        /// The user’s phone number
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The user’s address
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// The user’s total available space amount in byte. A value of -1 grants unlimited storage.
        /// </summary>
        [JsonProperty(PropertyName = "space_amount")]
        public double SpaceAmount { get; set; }

        /// <summary>
        /// An array of key/value pairs set by the user’s admin
        /// </summary>
        [JsonProperty(PropertyName = "tracking_codes")]
        public string[] TrackingCodes { get; set; }

        /// <summary>
        /// Whether this user can see other enterprise users in its contact list
        /// </summary>
        [JsonProperty(PropertyName = "can_see_managed_users")]
        public bool CanSeeManagedUsers { get; set; }

        /// <summary>
        /// Can be active or inactive
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Whether to exempt this user from Enterprise device limits
        /// </summary>
        [JsonProperty(PropertyName = "is_exempt_from_device_limits")]
        public bool? IsExemptFromDeviceLimits { get; set; }

        /// <summary>
        /// Whether or not this user must use two-factor authentication
        /// </summary>
        [JsonProperty(PropertyName = "is_exempt_from_login_verification")]
        public bool? IsExemptFromLoginVerification { get; set; }

        /// <summary>
        /// Whether or not the user is required to reset password
        /// </summary>
        [JsonProperty(PropertyName = "is_password_reset_required")]
        public bool? IsPasswordResetRequired { get; set; }
    }
}
