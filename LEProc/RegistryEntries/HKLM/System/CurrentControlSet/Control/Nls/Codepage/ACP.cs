﻿using System.Globalization;
using LECommonLibrary;

namespace LEProc.RegistryEntries.HKLM.System.CurrentControlSet.Control.Nls.Codepage
{
    class ACP : IRegistryEntry
    {
        public bool IsAdvanced => false;

        public string Root => "HKEY_LOCAL_MACHINE";

        public string Key => @"System\CurrentControlSet\Control\Nls\CodePage";

        public string Name => "ACP";

        public string Type => "REG_SZ";

        public string GetValue(CultureInfo culture)
        {
            return culture.TextInfo.ANSICodePage.ToString();
        }
    }
}
