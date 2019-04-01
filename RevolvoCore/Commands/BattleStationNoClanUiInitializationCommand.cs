﻿namespace RevolvoCore.Commands
{
    class BattleStationNoClanUiInitializationCommand
    {
        public const short ID = 28532;

        public static Command write(int mapAssetId)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(mapAssetId);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
