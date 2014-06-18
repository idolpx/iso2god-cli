﻿using System;

namespace Chilano.Xbox360.Iso
{
   [Flags]
   public enum GDFDirEntryAttrib : byte
    {
        Archive = 0x20,
        Directory = 0x10,
        Hidden = 2,
        Normal = 0x80,
        ReadOnly = 1,
        System = 4
    }
}

