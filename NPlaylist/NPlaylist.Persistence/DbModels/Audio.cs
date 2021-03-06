﻿using System;
using System.Collections.Generic;

namespace NPlaylist.Persistence.DbModels
{
    public class Audio
    {
        public Guid AudioId { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime UtcCreatedTime { get; set; }
        public string Path { get; set; }
        public AudioMeta Meta { get; set; }
        public ICollection<AudioPlaylists> AudioPlaylists { get; set; }
    }
}
