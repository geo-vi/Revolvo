namespace RevolvoCore.Commands.requests
{
    class ClanMemberInvitationRequest
    {
        public const short ID = 24022;

        public int inviterId;

        public int candidateId;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            inviterId = parser.readInt();
            candidateId = parser.readInt();
        }
    }
}
