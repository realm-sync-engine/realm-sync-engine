using System;

using Realms;
using RealmSync.SyncService;

namespace RealmSync.Tests.Client
{
    public class DbSyncClientObject : RealmObject, IRealmSyncObjectClient
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Text { get; set; }
        public string Tags { get; set; }

        public string MobilePrimaryKey => Id;
    }

    public class DbSyncWithDoNotUpload : RealmObject, IRealmSyncObjectClient
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Text { get; set; }
        [DoNotUpload]
        public string Tags { get; set; }

        public string MobilePrimaryKey => Id;
    }
}