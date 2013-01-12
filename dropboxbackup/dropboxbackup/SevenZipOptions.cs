using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropboxbackup
{
    enum CompressionLevels
    {
        Low,
        Medium,
        Normal,
        Maximum,
        Ultra
    }
    class SevenZipOptions
    {
        public string PathForBackup { get; set; }
        public string Password { get; set; }
        public bool PasswordEnabled { get; set; }
        public CompressionLevels CompressionLevel { get; set; }
    }
}
