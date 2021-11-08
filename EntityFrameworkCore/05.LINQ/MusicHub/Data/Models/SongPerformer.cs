﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Data.Models
{
    public class SongPerformer
    {
        /*•	SongId – Integer, Primary Key
•	Song – the performer’s Song(required)
•	PerformerId – Integer, Primary Key
•	Performer – the song’s Performer(required)*/

        public int SongId { get; set; }

        public Song Song { get; set; }

        public int PerformerId { get; set; }

        public Performer Performer { get; set; }

    }
}
