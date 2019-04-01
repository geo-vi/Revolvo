﻿namespace RevolvoCore.Commands
{
    class AssetRemoveCommand
    {
        public const short ID = 22922;

        public static Command write(AssetTypeModule assetType, int uid)
        {
            var cmd = new ByteArray(ID);
            cmd.AddBytes(assetType.write());
            cmd.Integer(uid);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
