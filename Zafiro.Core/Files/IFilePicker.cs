﻿using System;
using System.Collections.Generic;

namespace Zafiro.Core.Files
{
    public interface IFilePicker
    {
        IObservable<ZafiroFile> Pick(string title, string[] extensions);
        IObservable<ZafiroFile> PickSave(string title, KeyValuePair<string, IList<string>>[] extensions);
    }
}