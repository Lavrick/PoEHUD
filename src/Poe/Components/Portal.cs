﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Controllers;

namespace PoeHUD.Poe.Components
{
    public class Portal : Component
    {
        public WorldArea Area => GameController.Instance.Files.WorldAreas.GetAreaByAddress(M.ReadLong(Address + 0x28));
    }
}
