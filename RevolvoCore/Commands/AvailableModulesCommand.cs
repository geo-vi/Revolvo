﻿using System.Collections.Generic;

namespace RevolvoCore.Commands
{
    class AvailableModulesCommand
    {
        public const short ID = 28039;

        public List<StationModuleModule> modules;

        public AvailableModulesCommand(List<StationModuleModule> modules)
        {
            this.modules = modules;
        }

        public byte[] write()
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(modules.Count);
            foreach (var module in modules)
                cmd.AddBytes(module.write());
            return cmd.Message.ToArray();
        }
    }
}
