﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Realmius.Server;
using Realms;

namespace Realmius.Tests.Server.Models
{
    public class DbSyncObjectWithIgnoredFields : IRealmiusObjectServer
    {
        public string Text { get; set; }
        [JsonIgnore]
        public string Tags { get; set; }

        #region IRealmiusObject

        [PrimaryKey]
        [Key]
        public string Id { get; set; }

        public string MobilePrimaryKey => Id;

        #endregion
    }
}