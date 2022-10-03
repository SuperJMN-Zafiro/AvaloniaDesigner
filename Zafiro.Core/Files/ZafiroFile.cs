﻿using System.IO;
using System.Threading.Tasks;

namespace Zafiro.Core.Files
{
    public abstract class ZafiroFile
    {
        public abstract Task<Stream> OpenForRead();
        public abstract Task<Stream> OpenForWrite();
        public abstract string Name { get; }
    }
}