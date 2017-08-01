using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph.Compatibility
{
    public class TagValueCompatibility : ICompatibilityStrategy
    {
        public bool CanConnect(NodeConnector from, NodeConnector to)
        {
            if (null == from.Item.Tag || null == to.Item.Tag) return false;
            if (from.Item.Tag == to.Item.Tag)
            {
                return true;
            }
            return false;
        }
    }
}
