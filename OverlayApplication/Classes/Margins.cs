﻿using System.Runtime.InteropServices;

namespace OverlayApplication
{
    [StructLayout(LayoutKind.Sequential)]
    public class Margins
    {
        public int Left, Right, Top, Bottom;
    }
}
