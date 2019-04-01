using System.Collections.Generic;

namespace RevolvoCore.Commands
{
    public class ShipInitializationCommand
    {
        public const short ID = 26642;

        public int userId;
        public string userName;
        public int shipType;
        public int speed;
        public int shield;
        public int shieldMax;
        public int hitPoints;
        public int hitMax;
        public int cargoSpace;
        public int cargoSpaceMax;
        public int nanoHull;
        public int maxNanoHull;
        public int x;
        public int y;
        public int mapId;
        public int factionId;
        public int clanId;
        public int laserBatteriesMax;
        public int rocketsMax;
        public int expansionStage;
        public bool premium;
        public double ep;
        public double honourPoints;
        public int level;
        public double credits;
        public double uridium;
        public float jackpot;
        public int dailyRank;
        public string clanTag;
        public int galaxyGatesDone;
        public bool useSystemFont;
        public bool cloaked;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            userId = parser.readInt();
            userName = parser.readUTF();
            shipType = parser.readInt();
            speed = parser.readInt();
            shield = parser.readInt();
            shieldMax = parser.readInt();
            hitPoints = parser.readInt();
            hitMax = parser.readInt();
            cargoSpace = parser.readInt();
            cargoSpaceMax = parser.readInt();
            nanoHull = parser.readInt();
            maxNanoHull = parser.readInt();
            x = parser.readInt();
            y = parser.readInt();
            mapId = parser.readInt();
            factionId = parser.readInt();
            clanId = parser.readInt();
            laserBatteriesMax = parser.readInt();
            rocketsMax = parser.readInt();
            expansionStage = parser.readInt();
            premium = parser.readBool();
            ep = parser.readDouble();
            honourPoints = parser.readDouble();
            level = parser.readInt();
            credits = parser.readDouble();
            uridium = parser.readDouble();
            jackpot = parser.readFloat();
            dailyRank = parser.readInt();
            clanTag = parser.readUTF();
            galaxyGatesDone = parser.readInt();
            useSystemFont = parser.readBool();
            cloaked = parser.readBool();
        }

        public static Command write(int userId, string userName, int shipType, int speed, int shield, int shieldMax,
            int hitPoints, int hitMax,
            int cargoSpace, int cargoSpaceMax, int nanoHull, int maxNanoHull, int x, int y, int mapId, int factionId,
            int clanId, int laserBatteriesMax,
            int rocketsMax, int expansionStage, bool premium, double ep, double honourPoints, int level, double credits,
            double uridium, float jackpot, int dailyRank,
            string clanTag, int galaxyGatesDone, bool useSystemFont, bool cloaked,
            List<VisualModifierCommand> modifiers)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(userId);
            cmd.UTF(userName);
            cmd.Integer(shipType);
            cmd.Integer(speed);
            cmd.Integer(shield);
            cmd.Integer(shieldMax);
            cmd.Integer(hitPoints);
            cmd.Integer(hitMax);
            cmd.Integer(cargoSpace);
            cmd.Integer(cargoSpaceMax);
            cmd.Integer(nanoHull);
            cmd.Integer(maxNanoHull);
            cmd.Integer(x);
            cmd.Integer(y);
            cmd.Integer(mapId);
            cmd.Integer(factionId);
            cmd.Integer(clanId);
            cmd.Integer(laserBatteriesMax);
            cmd.Integer(rocketsMax);
            cmd.Integer(expansionStage);
            cmd.Boolean(premium);
            cmd.Double(ep);
            cmd.Double(honourPoints);
            cmd.Integer(level);
            cmd.Double(credits);
            cmd.Double(uridium);
            cmd.Float(jackpot);
            cmd.Integer(dailyRank);
            cmd.UTF(clanTag);
            cmd.Integer(galaxyGatesDone);
            cmd.Boolean(useSystemFont);
            cmd.Boolean(cloaked);
            cmd.Integer(modifiers.Count);
            foreach (var modifier in modifiers)
            {
                cmd.AddBytes(modifier.write());
            }

            return new Command(cmd.ToByteArray(), false);
        }
    }
}
