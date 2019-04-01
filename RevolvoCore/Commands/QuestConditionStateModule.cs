namespace RevolvoCore.Commands
{
    class QuestConditionStateModule
    {
        public const short ID = 3724;

        public double currentValue;
        public bool active;
        public bool completed;

        public QuestConditionStateModule(double currentValue, bool active, bool completed)
        {
            this.currentValue = currentValue;
            this.active = active;
            this.completed = completed;
        }

        public byte[] write()
        {
            var cmd = new ByteArray(ID);
            cmd.Double(currentValue);
            cmd.Boolean(active);
            cmd.Boolean(completed);
            return cmd.Message.ToArray();
        }
    }
}
