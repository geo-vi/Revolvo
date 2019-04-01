using System.Collections.Generic;

namespace RevolvoCore.Commands
{
    class EquippedModulesModule
    {
        public const short ID = 14861;

        public List<StationModuleModule> modules;

        public EquippedModulesModule(List<StationModuleModule> modules)
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
