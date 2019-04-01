﻿using System.Collections.Generic;

namespace RevolvoCore.Commands
{
    class MapAddPOICommand
    {
        public const short ID = 578;

        public static byte[] write(string poiId, POITypeModule poiType, string poiTypeSpecification, POIDesignModule design,
            short shape, List<int> shapeCoordinates, bool inverted, bool active)
        {
            var cmd = new ByteArray(ID);
            cmd.UTF(poiId);
            cmd.AddBytes(poiType.write());
            cmd.UTF(poiTypeSpecification);
            cmd.AddBytes(design.write());
            cmd.Short(shape);
            cmd.Integer(shapeCoordinates.Count);
            foreach(var _loc2_ in shapeCoordinates)
            {
                cmd.Integer(_loc2_);
            }
            cmd.Boolean(inverted);
            cmd.Boolean(active);
            return cmd.ToByteArray();
        }
    }
}