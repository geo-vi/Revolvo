﻿namespace RevolvoCore.Commands
{
    class BattleStationBuildingStateCommand
    {
        public const short ID = 23487;
        public static Command write(int mapAssetId, int battleStationId, string battleStationName, int secondsLeft, int totalSeconds, string ownerClan, FactionModule affiliatedFaction)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(mapAssetId);
            cmd.Integer(battleStationId);
            cmd.UTF(battleStationName);
            cmd.Integer(secondsLeft);
            cmd.Integer(totalSeconds);
            cmd.UTF(ownerClan);
            cmd.AddBytes(affiliatedFaction.write());
            return new Command(cmd.ToByteArray(),false);
        }
    }
}
