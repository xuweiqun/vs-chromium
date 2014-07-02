﻿using System;
using System.Runtime.InteropServices;

namespace VsChromium.Core.Win32.Jobs {
  [StructLayout(LayoutKind.Sequential)]
  public struct SECURITY_ATTRIBUTES {
    public int nLength;
    public IntPtr lpSecurityDescriptor;
    public int bInheritHandle;
  }
}