﻿namespace RevolvoCore.Commands
{
    class QuestConditionUpdateCommand
    {
        public const short ID = 9201;

        public static Command write(int questConditionId, QuestConditionStateModule state)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(questConditionId);
            cmd.AddBytes(state.write());
            return new Command(cmd.ToByteArray(), false);
        }

    }
}
