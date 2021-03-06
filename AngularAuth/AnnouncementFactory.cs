﻿using System.Collections.Generic;

namespace AngularAuth
{
    public class AnnouncementFactory
    {
        public static IEnumerable<Announcement> CreateAnnouncements()
        {
            yield return new Announcement { Title = "Announcement 1", Content = "Announcement 1" };
            yield return new Announcement { Title = "Announcement 2", Content = "Announcement 2" };
        }
    }
}